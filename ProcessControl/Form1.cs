using Opc.UaFx.Client;
using ScottPlot;

namespace ProcessControl
{
    public partial class Form1 : Form
    {
        private OpcClient client;
        private int bottleNumber = 0;

        public Form1()
        {
            InitializeComponent();
            InitializePictureBoxControls();
        }

        private void InitializePictureBoxControls()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, picFillingSilos.Width, picFillingSilos.Height);
            picFillingSilos.Region = new Region(path);
            picStopFillingSilos.Region = new Region(path);
            picFillingBottles.Region = new Region(path);
            picStopFillingBottles.Region = new Region(path);
        }

        private void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (btnConnectDisconnect.Text == "Connect")
            {
                ConnectToOPCServer();
                DrawPlotItemRatio();
            }
            else
            {
                DisconnectFromOPCServer();
                ClearAllControls();
            }
        }

        private void ConnectToOPCServer()
        {
            try
            {
                string endpoint = "opc.tcp://desktop-n88p201:62640/IntegrationObjects/ServerSimulator";
                client = new OpcClient(endpoint); //txtEndpointUrl.Text
                client.Connect();
                btnConnectDisconnect.Text = "Disconnect";
                timer.Start();
                LoadCurrentBottleLabel();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can not connect to the OPC server:\n" + e.ToString());
            }
        }

        private void LoadCurrentBottleLabel()
        {
            try
            {
                string tag = "ns=2;s=BottleLabel";
                var res = client.ReadNode(tag);
                txtBottleLabel.Text = res.ToString();
            }
            catch (Exception ex)
            {
                lblServerError.Visible = true;
            }
        }

        private void DrawPlotItemRatio()
        {
            double[] values = { 7, 2, 1 };
            string[] labels = { "Water", "Color", "Flavor" };
            Color[] colors = { Color.Blue, Color.Red, Color.Green };
            var pie = plotItemRatio.Plot.AddPie(values);
            pie.SliceLabels = labels;
            pie.SliceFillColors = colors;
            pie.ShowPercentages = true;
            plotItemRatio.Plot.Legend();
            plotItemRatio.Refresh();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectFromOPCServer();
        }

        private void DisconnectFromOPCServer()
        {
            if (client != null)
            {
                client.Disconnect();
                btnConnectDisconnect.Text = "Connect";
            }
        }

        private void ClearAllControls()
        {
            timer.Stop();
            plotWater.Plot.Clear();
            plotWater.Refresh();
            plotColor.Plot.Clear();
            plotColor.Refresh();
            plotFlavor.Plot.Clear();
            plotFlavor.Refresh();
            plotItemRatio.Plot.Clear();
            plotItemRatio.Refresh();
            picFillingSilos.Visible = false;
            picStopFillingSilos.Visible = false;
            picFillingBottles.Visible = false;
            picStopFillingBottles.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DrawJuiceProductionItemValue("Water");
            DrawJuiceProductionItemValue("Color");
            DrawJuiceProductionItemValue("Flavor");
            DetermineStatus("FillingSilos");
            DetermineStatus("StopFillingSilos");
            DetermineStatus("FillingBottles");
            DetermineStatus("StopFillingBottles");
            DetermineBottleNumber();
        }

        private void DrawJuiceProductionItemValue(string item)
        {
            string tag = ResolveItemTag(item);
            FormsPlot plot = ResolveItemPlot(item);
            plot.Plot.Clear();

            try
            {
                var a = client.ReadNode(tag);
                double[] values = { double.Parse(a.ToString()) };
                lblServerError.Visible = false;

                var bar = plot.Plot.AddBar(values);
                bar.ShowValuesAboveBars = true;
                bar.Font.Size = 16;
                Color color = ResolveItemColor(item);
                bar.Font.Color = color;
                bar.FillColor = color;
            }
            catch (Exception ex)
            {
                lblServerError.Visible = true;
            }

            plot.Plot.SetAxisLimits(yMin: 0, yMax: 800);
            plot.Plot.XTicks(new[] { item });
            plot.Refresh();

        }

        private string ResolveItemTag(string item)
        {
            switch (item)
            {
                case "Water":
                    return "ns=2;s=Water";
                case "Color":
                    return "ns=2;s=Color";
                default:
                    return "ns=2;s=Flavor";
            }
        }

        private FormsPlot ResolveItemPlot(string item)
        {
            switch (item)
            {
                case "Water":
                    return plotWater;
                case "Color":
                    return plotColor;
                default:
                    return plotFlavor;
            }
        }

        private Color ResolveItemColor(string item)
        {
            switch (item)
            {
                case "Water":
                    return Color.Blue;
                case "Color":
                    return Color.Red;
                default:
                    return Color.Green;
            }
        }

        private void DetermineStatus(string statusName)
        {
            PictureBox pic = ResolveStatusPictureBox(statusName);
            try
            {
                string tag = ResolveStatusTag(statusName);
                var res = client.ReadNode(tag);
                if (bool.Parse(res.ToString()))
                {
                    SetPictureBoxVisibility(pic, true);
                }
                else
                {
                    SetPictureBoxVisibility(pic, false);
                }
            }
            catch
            {
                SetPictureBoxVisibility(pic, false);
            }
        }

        private PictureBox ResolveStatusPictureBox(string statusName)
        {
            switch (statusName)
            {
                case "FillingSilos":
                    return picFillingSilos;
                case "StopFillingSilos":
                    return picStopFillingSilos;
                case "FillingBottles":
                    return picFillingBottles;
                default:
                    return picStopFillingBottles;
            }
        }

        private string ResolveStatusTag(string statusName)
        {
            switch (statusName)
            {
                case "FillingSilos":
                    return "ns=2;s=FillingSilos";
                case "StopFillingSilos":
                    return "ns=2;s=StopFillingSilos";
                case "FillingBottles":
                    return "ns=2;s=FillingBottles";
                default:
                    return "ns=2;s=StopFillingBottles";
            }
        }

        private void SetPictureBoxVisibility(PictureBox pic, bool value)
        {
            pic.Visible = value;
        }

        private void DetermineBottleNumber()
        {
            try
            {
                string tag = "ns=2;s=BottleNumber";
                var res = client.ReadNode(tag);
                int n = int.Parse(res.ToString());
                this.bottleNumber += n;
                lblBottleNumber.Text = this.bottleNumber.ToString();
            }
            catch
            {
                lblBottleNumber.Text = "NaN";
            }
        }

        private void btnBottleLabel_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.WriteNode("ns=2;s=BottleLabel", txtBottleLabel.Text);
                MessageBox.Show(txtBottleLabel.Text + " as a new bottle label is set.");
            }
            else
            {
                MessageBox.Show("You are not connected to the OPC server.");
            }
        }
    }
}