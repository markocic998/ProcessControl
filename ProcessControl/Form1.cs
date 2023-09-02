using Opc.UaFx.Client;
using ScottPlot;

namespace ProcessControl
{
    public partial class Form1 : Form
    {
        private OpcClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (btnConnectDisconnect.Text == "Connect")
            {
                ConnectToOPCServer();
            }
            else
            {
                DisconnectFromOPCServer();
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
            }
            catch (Exception e)
            {
                MessageBox.Show("Can not connect to the OPC server:\n" + e.ToString());
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectFromOPCServer();
        }

        private void DisconnectFromOPCServer()
        {
            timer.Stop();
            plotWater.Plot.Clear();
            plotWater.Refresh();
            plotColor.Plot.Clear();
            plotColor.Refresh();
            plotFlavor.Plot.Clear();
            plotFlavor.Refresh();
            if (client != null)
            {
                client.Disconnect();
                btnConnectDisconnect.Text = "Connect";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DrawJuiceProductionItemValue("Water");
            DrawJuiceProductionItemValue("Color");
            DrawJuiceProductionItemValue("Flavor");
        }

        private void DrawJuiceProductionItemValue(string item)
        {
            string tag = resolveTag(item);
            FormsPlot plot = resolvePlot(item);
            plot.Plot.Clear();

            try
            {
                var a = client.ReadNode(tag);
                double[] values = { double.Parse(a.ToString()) };
                lblServerError.Visible = false;

                var bar = plot.Plot.AddBar(values);
                bar.ShowValuesAboveBars = true;
                bar.Font.Size = 16;
                Color color = resolveColor(item);
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

        private string resolveTag(string item)
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

        private FormsPlot resolvePlot(string item)
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

        private Color resolveColor(string item)
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
    }
}