using Opc.UaFx.Client;
using ScottPlot;
using System.Drawing.Drawing2D;

namespace ProcessControl
{
    public partial class Form1 : Form
    {
        private OpcClient client;
        private int totalBottleNumber = 0;

        public Form1()
        {
            InitializeComponent();
            InitializePictureBoxControls();
        }

        private void InitializePictureBoxControls()
        {
            //circle shape instead of square
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picFillingSilos.Width, picFillingSilos.Height);
            picFillingSilos.Region = new Region(path);
            picStopFillingSilos.Region = new Region(path);
            picFillingBottles.Region = new Region(path);
            picStopFillingBottles.Region = new Region(path);
        }

        private void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (btnConnectDisconnect.Text == Constants.Connect)
            {
                ConnectToOPCServer();
                DrawPlotItemRatio();
            }
            else
            {
                DisconnectFromOPCServer();
                ResetAllControls();
            }
        }

        private void ConnectToOPCServer()
        {
            try
            {
                string endpoint = "opc.tcp://desktop-n88p201:62640/IntegrationObjects/ServerSimulator";
                client = new OpcClient(endpoint); //txtEndpointUrl.Text
                client.Connect();
                btnConnectDisconnect.Text = Constants.Disconnect;
                LoadCurrentBottleLabel();
                LoadTotalNumberOfBottles();
                timer.Start();
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
                var res = client.ReadNode(Constants.BottleLabelTag);
                txtBottleLabel.Text = res.ToString();
            }
            catch (Exception ex)
            {
                lblServerError.Visible = true;
            }
        }

        private void LoadTotalNumberOfBottles()
        {
            try
            {
                string res = client.ReadNode(Constants.TotalNumberOfBottlesTag).ToString();
                this.totalBottleNumber = int.Parse(res);
                lblTotalBottleNumber.Text = res;
            }
            catch (Exception ex)
            {
                lblServerError.Visible = true;
            }
        }

        private void DrawPlotItemRatio()
        {
            double[] values = { 7, 2, 1 };
            string[] labels = { Constants.Water, Constants.Color, Constants.Flavor };
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
                btnConnectDisconnect.Text = Constants.Connect;
            }
        }

        private void ResetAllControls()
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
            DrawJuiceProductionItemValue(Constants.Water);
            DrawJuiceProductionItemValue(Constants.Color);
            DrawJuiceProductionItemValue(Constants.Flavor);

            DetermineStatus(Constants.FillingSilos);
            DetermineStatus(Constants.StopFillingSilos);
            DetermineStatus(Constants.FillingBottles);
            DetermineStatus(Constants.StopFillingBottles);

            DetermineTotalBottleNumber();
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
                case Constants.Water:
                    return Constants.WaterTag;
                case Constants.Color:
                    return Constants.ColorTag;
                default:
                    return Constants.FlavorTag;
            }
        }

        private FormsPlot ResolveItemPlot(string item)
        {
            switch (item)
            {
                case Constants.Water:
                    return plotWater;
                case Constants.Color:
                    return plotColor;
                default:
                    return plotFlavor;
            }
        }

        private Color ResolveItemColor(string item)
        {
            switch (item)
            {
                case Constants.Water:
                    return Color.Blue;
                case Constants.Color:
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
                case Constants.FillingSilos:
                    return picFillingSilos;
                case Constants.StopFillingSilos:
                    return picStopFillingSilos;
                case Constants.FillingBottles:
                    return picFillingBottles;
                default:
                    return picStopFillingBottles;
            }
        }

        private string ResolveStatusTag(string statusName)
        {
            switch (statusName)
            {
                case Constants.FillingSilos:
                    return Constants.FillingSilosTag;
                case Constants.StopFillingSilos:
                    return Constants.StopFillingSilosTag;
                case Constants.FillingBottles:
                    return Constants.FillingBottlesTag;
                default:
                    return Constants.StopFillingBottlesTag;
            }
        }

        private void SetPictureBoxVisibility(PictureBox pic, bool value)
        {
            pic.Visible = value;
        }

        private void DetermineTotalBottleNumber()
        {
            try
            {
                var res = client.ReadNode(Constants.BottleNumberTag);
                int n = int.Parse(res.ToString());
                if (n > 0)
                {
                    this.totalBottleNumber += n;
                    lblTotalBottleNumber.Text = this.totalBottleNumber.ToString();
                    client.WriteNode(Constants.TotalNumberOfBottlesTag, this.totalBottleNumber);
                }
            }
            catch
            {
                lblServerError.Visible = true;
                lblTotalBottleNumber.Text = "NaN";
            }
        }

        private void btnBottleLabel_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.WriteNode(Constants.BottleLabelTag, txtBottleLabel.Text);
                MessageBox.Show(txtBottleLabel.Text + " as a new bottle label is set.");
            }
            else
            {
                MessageBox.Show("You are not connected to the OPC server.");
            }
        }
    }
}