using Opc.UaFx;
using Opc.UaFx.Client;
using ScottPlot;
using System.Drawing.Drawing2D;

namespace ProcessControl
{
    public partial class Form1 : Form
    {
        private OpcClient client;
        private int totalBottleNumber = 0;
        private List<string> tagList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InitializePictureBoxControls();
            InitializeControls();
        }

        private void InitializeControls()
        {
            timeUnitComboBox.SelectedIndex = 0;
            fromDateTime.CustomFormat = Constants.DateTimeFormat;
            toDateTime.CustomFormat = Constants.DateTimeFormat;
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
                string endpoint = txtEndpointUrl.Text;
                /*if (endpoint == "")
                {
                    endpoint = "opc.tcp://desktop-n88p201:62640/IntegrationObjects/ServerSimulator";
                }*/
                client = new OpcClient(endpoint);
                client.Connect();
                btnConnectDisconnect.Text = Constants.Disconnect;
                DrawPlotItemRatio();
                LoadCurrentBottleLabel();
                LoadTotalNumberOfBottles();
                DrawLogs();
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
                client = null;
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

            mainPlot.Plot.Clear();
            mainPlot.Refresh();

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
            if (liveModeCheckBox.Checked)
            {
                DrawLogs();
            }
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
                case Constants.Flavor:
                    return Color.Green;
                case Constants.BottleNumber:
                    return Color.DarkCyan;
                case Constants.TotalNumberOfBottles:
                    return Color.Purple;
                case Constants.Temperature:
                    return Color.Orange;
                default:
                    return Color.Black;
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

        private void DrawLogs()
        {
            if (client == null)
            {
                return;
            }
            mainPlot.Plot.Clear();
            DateTime start = DetermineStartDateTime();
            DateTime end = DetermineEndDateTime();
            var logs = client.ReadNodesHistory(start, end, nodeIds: DetermineNodeIds());

            foreach (var log in logs)
            {
                List<double> values = new List<double>();
                List<double> timestamps = new List<double>();
                foreach (var data in log.Value)
                {
                    if (data.Value != null && double.TryParse(data.Value.ToString(), out double value))
                    {
                        values.Add(value);
                        timestamps.Add(data.Timestamp.AddHours(Constants.TimeZoneDifference).ToOADate());
                    }
                }
                if (timestamps.Count > 0)
                {
                    string label = ResolveNameFromHistoricalTag(log.Key.ToString());
                    Color color = ResolveItemColor(label);
                    var scatter = mainPlot.Plot.AddScatter(timestamps.ToArray(), values.ToArray(), label: label, color: color);
                    scatter.MarkerSize = 3;
                }
            }

            mainPlot.Plot.XAxis.DateTimeFormat(true);
            var legend = mainPlot.Plot.Legend();
            legend.Location = Alignment.UpperLeft;
            mainPlot.Plot.AxisAuto();
            mainPlot.Refresh();
        }

        private DateTime DetermineStartDateTime()
        {
            if (liveModeCheckBox.Checked)
            {
                return CalculateStartTime();
            }
            else
            {
                return fromDateTime.Value.AddHours(-Constants.TimeZoneDifference);
            }
        }

        private DateTime DetermineEndDateTime()
        {
            if (liveModeCheckBox.Checked)
            {
                return DateTime.UtcNow;
            }
            else
            {
                return toDateTime.Value.AddHours(-Constants.TimeZoneDifference);
            }
        }

        private DateTime CalculateStartTime()
        {
            double value = double.Parse(lastXNumeric.Value.ToString());
            if (value <= 0)
            {
                return DateTime.UtcNow;
            }
            switch (timeUnitComboBox.SelectedItem)
            {
                case Constants.Seconds:
                    return DateTime.UtcNow.AddSeconds(-value);
                case Constants.Minutes:
                    return DateTime.UtcNow.AddMinutes(-value);
                default:
                    return DateTime.UtcNow.AddHours(-value);
            }
        }

        private OpcNodeId[] DetermineNodeIds()
        {
            OpcNodeId[] nodeIds = new OpcNodeId[tagList.Count];
            for (int i = 0; i < tagList.Count; i++)
            {
                nodeIds[i] = tagList[i];
            }
            return nodeIds;
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

        private void clearTagsBtn_Click(object sender, EventArgs e)
        {
            if (tagsListBox.Items.Count > 0)
            {
                tagsListBox.Items.Clear();
                tagList.Clear();
                DrawLogs();
            }
            else
            {
                MessageBox.Show("There are no items to remove.");
            }
        }

        private void removeTagBtn_Click(object sender, EventArgs e)
        {
            if (tagsListBox.SelectedItems.Count > 0)
            {
                string itemToRemove = tagsListBox.SelectedItem.ToString();
                tagsListBox.Items.Remove(itemToRemove);
                tagList.Remove(ResolveHistoricalTag(itemToRemove));
                DrawLogs();
            }
            else
            {
                MessageBox.Show("There is no selected item.");
            }
        }

        private void addTagBtn_Click(object sender, EventArgs e)
        {
            if (tagComboBox.SelectedIndex >= 0 && !isTagAlreadyAdded((string)tagComboBox.SelectedItem))
            {
                tagsListBox.Items.Add(tagComboBox.SelectedItem);
                tagList.Add(ResolveHistoricalTag((string)tagComboBox.SelectedItem));
                DrawLogs();
            }
            else
            {
                MessageBox.Show("Please, choose an item that is not in the list.");
            }
        }

        private bool isTagAlreadyAdded(string item)
        {
            for (int i = 0; i < tagsListBox.Items.Count; i++)
            {
                if ((string)tagsListBox.Items[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        private string ResolveHistoricalTag(string name)
        {
            switch (name)
            {
                case Constants.Water:
                    return Constants.WaterHistoricalTag;
                case Constants.Color:
                    return Constants.ColorHistoricalTag;
                case Constants.Flavor:
                    return Constants.FlavorHistoricalTag;
                case Constants.BottleNumber:
                    return Constants.BottleNumberHistoricalTag;
                case Constants.TotalNumberOfBottles:
                    return Constants.TotalNumberOfBottlesHistoricalTag;
                default:
                    return Constants.TemperatureHistoricalTag;
            }
        }

        private string ResolveNameFromHistoricalTag(string name)
        {
            switch (name)
            {
                case Constants.WaterHistoricalTag:
                    return Constants.Water;
                case Constants.ColorHistoricalTag:
                    return Constants.Color;
                case Constants.FlavorHistoricalTag:
                    return Constants.Flavor;
                case Constants.BottleNumberHistoricalTag:
                    return Constants.BottleNumber;
                case Constants.TotalNumberOfBottlesHistoricalTag:
                    return Constants.TotalNumberOfBottles;
                default:
                    return Constants.Temperature;
            }
        }

        private void liveModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (liveModeCheckBox.Checked)
            {
                fromDateTime.Enabled= false;
                toDateTime.Enabled = false;
                lastXNumeric.Enabled = true;
                timeUnitComboBox.Enabled = true;
                forecastValuesCheckBox.Enabled= true;
                horizonNumeric.Enabled= true;
            }
            else
            {
                fromDateTime.Enabled = true;
                toDateTime.Enabled = true;
                lastXNumeric.Enabled = false;
                timeUnitComboBox.Enabled = false;
                forecastValuesCheckBox.Enabled = false;
                horizonNumeric.Enabled = false;
            }
            DrawLogs();
        }

        private void fromDateTime_ValueChanged(object sender, EventArgs e)
        {
            DrawLogs();
        }

        private void toDateTime_ValueChanged(object sender, EventArgs e)
        {
            DrawLogs();
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            if (tagsListBox.SelectedItems.Count > 0 && client != null)
            {
                string item = tagsListBox.SelectedItem.ToString();
                string tag = ResolveHistoricalTag(item);
                MessageBox.Show($"Statistic of {item} log:\n" + GetStatistics(tag));
            }
            else
            {
                MessageBox.Show("There is no selected item or there is no connection to the OPC server.");
            }
        }

        private string GetStatistics(string tag)
        {
            string statistics = "";
            DateTime startTime = DetermineStartDateTime();
            DateTime endTime = DetermineEndDateTime();
            var minimum = client.ReadNodeHistoryProcessed(startTime, endTime, OpcAggregateType.Minimum, tag);
            foreach (var min in minimum)
            { 
                if (min.Value != null)
                {
                    statistics += $"minimum: {min.Value}\n";
                }
            }
            var maximum = client.ReadNodeHistoryProcessed(startTime, endTime, OpcAggregateType.Maximum, tag);
            foreach (var max in maximum)
            {
                if (max.Value != null)
                {
                    statistics += $"maximum: {max.Value}\n";
                }
            }
            var average = client.ReadNodeHistoryProcessed(startTime, endTime, OpcAggregateType.Average, tag);
            foreach (var avg in average)
            {
                if (avg.Value != null)
                {
                    statistics += $"average: {avg.Value}\n";
                }
            }
            return statistics;
        }
    }
}