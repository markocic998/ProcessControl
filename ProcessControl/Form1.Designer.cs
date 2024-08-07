﻿namespace ProcessControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.waterSilosPictureBox = new System.Windows.Forms.PictureBox();
            this.colorSilosPictureBox = new System.Windows.Forms.PictureBox();
            this.flavorSilosPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.txtEndpointUrl = new System.Windows.Forms.TextBox();
            this.lblEndpointUrl = new System.Windows.Forms.Label();
            this.plotWater = new ScottPlot.FormsPlot();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblJuiceProduction = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plotColor = new ScottPlot.FormsPlot();
            this.plotFlavor = new ScottPlot.FormsPlot();
            this.lblServerError = new System.Windows.Forms.Label();
            this.plotItemRatio = new ScottPlot.FormsPlot();
            this.picFillingSilos = new System.Windows.Forms.PictureBox();
            this.lblFillingSilos = new System.Windows.Forms.Label();
            this.bottlePictureBox = new System.Windows.Forms.PictureBox();
            this.lblFillingBottles = new System.Windows.Forms.Label();
            this.picFillingBottles = new System.Windows.Forms.PictureBox();
            this.lblStopFillingSilos = new System.Windows.Forms.Label();
            this.picStopFillingSilos = new System.Windows.Forms.PictureBox();
            this.lblStopFillingBottles = new System.Windows.Forms.Label();
            this.picStopFillingBottles = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalBottleNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBottleLabel = new System.Windows.Forms.TextBox();
            this.btnBottleLabel = new System.Windows.Forms.Button();
            this.mainPlot = new ScottPlot.FormsPlot();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.tagComboBox = new System.Windows.Forms.ComboBox();
            this.addTagBtn = new System.Windows.Forms.Button();
            this.removeTagBtn = new System.Windows.Forms.Button();
            this.clearTagsBtn = new System.Windows.Forms.Button();
            this.liveModeCheckBox = new System.Windows.Forms.CheckBox();
            this.lastXNumeric = new System.Windows.Forms.NumericUpDown();
            this.timeUnitComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fromDateTime = new System.Windows.Forms.DateTimePicker();
            this.toDateTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.forecastValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.horizonNumeric = new System.Windows.Forms.NumericUpDown();
            this.lblFutureValues = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waterSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillingSilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillingBottles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopFillingSilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopFillingBottles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastXNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizonNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // waterSilosPictureBox
            // 
            this.waterSilosPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("waterSilosPictureBox.Image")));
            this.waterSilosPictureBox.Location = new System.Drawing.Point(866, 168);
            this.waterSilosPictureBox.Name = "waterSilosPictureBox";
            this.waterSilosPictureBox.Size = new System.Drawing.Size(132, 294);
            this.waterSilosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.waterSilosPictureBox.TabIndex = 0;
            this.waterSilosPictureBox.TabStop = false;
            // 
            // colorSilosPictureBox
            // 
            this.colorSilosPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("colorSilosPictureBox.Image")));
            this.colorSilosPictureBox.Location = new System.Drawing.Point(1226, 168);
            this.colorSilosPictureBox.Name = "colorSilosPictureBox";
            this.colorSilosPictureBox.Size = new System.Drawing.Size(132, 294);
            this.colorSilosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorSilosPictureBox.TabIndex = 1;
            this.colorSilosPictureBox.TabStop = false;
            // 
            // flavorSilosPictureBox
            // 
            this.flavorSilosPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("flavorSilosPictureBox.Image")));
            this.flavorSilosPictureBox.Location = new System.Drawing.Point(1582, 168);
            this.flavorSilosPictureBox.Name = "flavorSilosPictureBox";
            this.flavorSilosPictureBox.Size = new System.Drawing.Size(132, 294);
            this.flavorSilosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flavorSilosPictureBox.TabIndex = 2;
            this.flavorSilosPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(938, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 5);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(938, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 50);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1299, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(5, 50);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(1655, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(5, 50);
            this.label4.TabIndex = 6;
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnectDisconnect.Location = new System.Drawing.Point(981, 19);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(134, 29);
            this.btnConnectDisconnect.TabIndex = 7;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.UseVisualStyleBackColor = true;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // txtEndpointUrl
            // 
            this.txtEndpointUrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndpointUrl.Location = new System.Drawing.Point(220, 18);
            this.txtEndpointUrl.Name = "txtEndpointUrl";
            this.txtEndpointUrl.Size = new System.Drawing.Size(755, 30);
            this.txtEndpointUrl.TabIndex = 8;
            // 
            // lblEndpointUrl
            // 
            this.lblEndpointUrl.AutoSize = true;
            this.lblEndpointUrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndpointUrl.Location = new System.Drawing.Point(26, 22);
            this.lblEndpointUrl.Name = "lblEndpointUrl";
            this.lblEndpointUrl.Size = new System.Drawing.Size(187, 22);
            this.lblEndpointUrl.TabIndex = 9;
            this.lblEndpointUrl.Text = "Server Endpoint URL:";
            // 
            // plotWater
            // 
            this.plotWater.Location = new System.Drawing.Point(1006, 168);
            this.plotWater.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plotWater.Name = "plotWater";
            this.plotWater.Size = new System.Drawing.Size(146, 332);
            this.plotWater.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblJuiceProduction
            // 
            this.lblJuiceProduction.AutoSize = true;
            this.lblJuiceProduction.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJuiceProduction.Location = new System.Drawing.Point(866, 76);
            this.lblJuiceProduction.Name = "lblJuiceProduction";
            this.lblJuiceProduction.Size = new System.Drawing.Size(234, 37);
            this.lblJuiceProduction.TabIndex = 11;
            this.lblJuiceProduction.Text = "Juice Production";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(1236, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(5, 70);
            this.label5.TabIndex = 14;
            // 
            // plotColor
            // 
            this.plotColor.Location = new System.Drawing.Point(1366, 168);
            this.plotColor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plotColor.Name = "plotColor";
            this.plotColor.Size = new System.Drawing.Size(146, 332);
            this.plotColor.TabIndex = 15;
            // 
            // plotFlavor
            // 
            this.plotFlavor.Location = new System.Drawing.Point(1722, 168);
            this.plotFlavor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plotFlavor.Name = "plotFlavor";
            this.plotFlavor.Size = new System.Drawing.Size(146, 332);
            this.plotFlavor.TabIndex = 16;
            // 
            // lblServerError
            // 
            this.lblServerError.AutoSize = true;
            this.lblServerError.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServerError.ForeColor = System.Drawing.Color.Red;
            this.lblServerError.Location = new System.Drawing.Point(1668, 9);
            this.lblServerError.Name = "lblServerError";
            this.lblServerError.Size = new System.Drawing.Size(202, 37);
            this.lblServerError.TabIndex = 17;
            this.lblServerError.Text = "Server Error";
            this.lblServerError.Visible = false;
            // 
            // plotItemRatio
            // 
            this.plotItemRatio.Location = new System.Drawing.Point(1655, 571);
            this.plotItemRatio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plotItemRatio.Name = "plotItemRatio";
            this.plotItemRatio.Size = new System.Drawing.Size(213, 211);
            this.plotItemRatio.TabIndex = 18;
            // 
            // picFillingSilos
            // 
            this.picFillingSilos.BackColor = System.Drawing.Color.Lime;
            this.picFillingSilos.Location = new System.Drawing.Point(940, 587);
            this.picFillingSilos.Name = "picFillingSilos";
            this.picFillingSilos.Size = new System.Drawing.Size(35, 35);
            this.picFillingSilos.TabIndex = 19;
            this.picFillingSilos.TabStop = false;
            this.picFillingSilos.Visible = false;
            // 
            // lblFillingSilos
            // 
            this.lblFillingSilos.AutoSize = true;
            this.lblFillingSilos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFillingSilos.Location = new System.Drawing.Point(981, 594);
            this.lblFillingSilos.Name = "lblFillingSilos";
            this.lblFillingSilos.Size = new System.Drawing.Size(119, 22);
            this.lblFillingSilos.TabIndex = 20;
            this.lblFillingSilos.Text = "Silos filling...";
            // 
            // bottlePictureBox
            // 
            this.bottlePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bottlePictureBox.Image")));
            this.bottlePictureBox.Location = new System.Drawing.Point(1187, 582);
            this.bottlePictureBox.Name = "bottlePictureBox";
            this.bottlePictureBox.Size = new System.Drawing.Size(103, 198);
            this.bottlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottlePictureBox.TabIndex = 21;
            this.bottlePictureBox.TabStop = false;
            // 
            // lblFillingBottles
            // 
            this.lblFillingBottles.AutoSize = true;
            this.lblFillingBottles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFillingBottles.Location = new System.Drawing.Point(981, 706);
            this.lblFillingBottles.Name = "lblFillingBottles";
            this.lblFillingBottles.Size = new System.Drawing.Size(134, 22);
            this.lblFillingBottles.TabIndex = 23;
            this.lblFillingBottles.Text = "Bottles filling...";
            // 
            // picFillingBottles
            // 
            this.picFillingBottles.BackColor = System.Drawing.Color.Lime;
            this.picFillingBottles.Location = new System.Drawing.Point(940, 699);
            this.picFillingBottles.Name = "picFillingBottles";
            this.picFillingBottles.Size = new System.Drawing.Size(35, 35);
            this.picFillingBottles.TabIndex = 22;
            this.picFillingBottles.TabStop = false;
            this.picFillingBottles.Visible = false;
            // 
            // lblStopFillingSilos
            // 
            this.lblStopFillingSilos.AutoSize = true;
            this.lblStopFillingSilos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopFillingSilos.Location = new System.Drawing.Point(981, 640);
            this.lblStopFillingSilos.Name = "lblStopFillingSilos";
            this.lblStopFillingSilos.Size = new System.Drawing.Size(142, 22);
            this.lblStopFillingSilos.TabIndex = 25;
            this.lblStopFillingSilos.Text = "Stop silos filling";
            // 
            // picStopFillingSilos
            // 
            this.picStopFillingSilos.BackColor = System.Drawing.Color.Red;
            this.picStopFillingSilos.Location = new System.Drawing.Point(940, 633);
            this.picStopFillingSilos.Name = "picStopFillingSilos";
            this.picStopFillingSilos.Size = new System.Drawing.Size(35, 35);
            this.picStopFillingSilos.TabIndex = 24;
            this.picStopFillingSilos.TabStop = false;
            this.picStopFillingSilos.Visible = false;
            // 
            // lblStopFillingBottles
            // 
            this.lblStopFillingBottles.AutoSize = true;
            this.lblStopFillingBottles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopFillingBottles.Location = new System.Drawing.Point(981, 752);
            this.lblStopFillingBottles.Name = "lblStopFillingBottles";
            this.lblStopFillingBottles.Size = new System.Drawing.Size(157, 22);
            this.lblStopFillingBottles.TabIndex = 27;
            this.lblStopFillingBottles.Text = "Stop bottles filling";
            // 
            // picStopFillingBottles
            // 
            this.picStopFillingBottles.BackColor = System.Drawing.Color.Red;
            this.picStopFillingBottles.Location = new System.Drawing.Point(940, 745);
            this.picStopFillingBottles.Name = "picStopFillingBottles";
            this.picStopFillingBottles.Size = new System.Drawing.Size(35, 35);
            this.picStopFillingBottles.TabIndex = 26;
            this.picStopFillingBottles.TabStop = false;
            this.picStopFillingBottles.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1315, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total number of monitored filled bottles:";
            // 
            // lblTotalBottleNumber
            // 
            this.lblTotalBottleNumber.AutoSize = true;
            this.lblTotalBottleNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBottleNumber.Location = new System.Drawing.Point(1315, 618);
            this.lblTotalBottleNumber.Name = "lblTotalBottleNumber";
            this.lblTotalBottleNumber.Size = new System.Drawing.Size(20, 22);
            this.lblTotalBottleNumber.TabIndex = 29;
            this.lblTotalBottleNumber.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1315, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Bottle label:";
            // 
            // txtBottleLabel
            // 
            this.txtBottleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBottleLabel.Location = new System.Drawing.Point(1315, 710);
            this.txtBottleLabel.Name = "txtBottleLabel";
            this.txtBottleLabel.Size = new System.Drawing.Size(332, 30);
            this.txtBottleLabel.TabIndex = 31;
            // 
            // btnBottleLabel
            // 
            this.btnBottleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBottleLabel.Location = new System.Drawing.Point(1526, 746);
            this.btnBottleLabel.Name = "btnBottleLabel";
            this.btnBottleLabel.Size = new System.Drawing.Size(121, 34);
            this.btnBottleLabel.TabIndex = 32;
            this.btnBottleLabel.Text = "Set";
            this.btnBottleLabel.UseVisualStyleBackColor = true;
            this.btnBottleLabel.Click += new System.EventHandler(this.btnBottleLabel_Click);
            // 
            // mainPlot
            // 
            this.mainPlot.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.mainPlot.Location = new System.Drawing.Point(-2, 340);
            this.mainPlot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mainPlot.Name = "mainPlot";
            this.mainPlot.Size = new System.Drawing.Size(860, 514);
            this.mainPlot.TabIndex = 33;
            // 
            // tagsListBox
            // 
            this.tagsListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 22;
            this.tagsListBox.Location = new System.Drawing.Point(364, 164);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(241, 158);
            this.tagsListBox.TabIndex = 34;
            // 
            // tagComboBox
            // 
            this.tagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tagComboBox.FormattingEnabled = true;
            this.tagComboBox.Items.AddRange(new object[] {
            "Water",
            "Color",
            "Flavor",
            "BottleNumber",
            "TotalNumberOfBottles",
            "Temperature"});
            this.tagComboBox.Location = new System.Drawing.Point(611, 164);
            this.tagComboBox.Name = "tagComboBox";
            this.tagComboBox.Size = new System.Drawing.Size(228, 30);
            this.tagComboBox.TabIndex = 35;
            // 
            // addTagBtn
            // 
            this.addTagBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTagBtn.Location = new System.Drawing.Point(611, 200);
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size(228, 29);
            this.addTagBtn.TabIndex = 36;
            this.addTagBtn.Text = "Add";
            this.addTagBtn.UseVisualStyleBackColor = true;
            this.addTagBtn.Click += new System.EventHandler(this.addTagBtn_Click);
            // 
            // removeTagBtn
            // 
            this.removeTagBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeTagBtn.Location = new System.Drawing.Point(611, 258);
            this.removeTagBtn.Name = "removeTagBtn";
            this.removeTagBtn.Size = new System.Drawing.Size(228, 29);
            this.removeTagBtn.TabIndex = 37;
            this.removeTagBtn.Text = "Remove";
            this.removeTagBtn.UseVisualStyleBackColor = true;
            this.removeTagBtn.Click += new System.EventHandler(this.removeTagBtn_Click);
            // 
            // clearTagsBtn
            // 
            this.clearTagsBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearTagsBtn.Location = new System.Drawing.Point(611, 293);
            this.clearTagsBtn.Name = "clearTagsBtn";
            this.clearTagsBtn.Size = new System.Drawing.Size(228, 29);
            this.clearTagsBtn.TabIndex = 38;
            this.clearTagsBtn.Text = "Clear";
            this.clearTagsBtn.UseVisualStyleBackColor = true;
            this.clearTagsBtn.Click += new System.EventHandler(this.clearTagsBtn_Click);
            // 
            // liveModeCheckBox
            // 
            this.liveModeCheckBox.AutoSize = true;
            this.liveModeCheckBox.Checked = true;
            this.liveModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.liveModeCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.liveModeCheckBox.Location = new System.Drawing.Point(26, 168);
            this.liveModeCheckBox.Name = "liveModeCheckBox";
            this.liveModeCheckBox.Size = new System.Drawing.Size(116, 26);
            this.liveModeCheckBox.TabIndex = 39;
            this.liveModeCheckBox.Text = "Live mode";
            this.liveModeCheckBox.UseVisualStyleBackColor = true;
            this.liveModeCheckBox.CheckedChanged += new System.EventHandler(this.liveModeCheckBox_CheckedChanged);
            // 
            // lastXNumeric
            // 
            this.lastXNumeric.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastXNumeric.Location = new System.Drawing.Point(90, 204);
            this.lastXNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lastXNumeric.Name = "lastXNumeric";
            this.lastXNumeric.Size = new System.Drawing.Size(124, 30);
            this.lastXNumeric.TabIndex = 40;
            this.lastXNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // timeUnitComboBox
            // 
            this.timeUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeUnitComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeUnitComboBox.FormattingEnabled = true;
            this.timeUnitComboBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.timeUnitComboBox.Location = new System.Drawing.Point(220, 204);
            this.timeUnitComboBox.Name = "timeUnitComboBox";
            this.timeUnitComboBox.Size = new System.Drawing.Size(120, 30);
            this.timeUnitComboBox.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Last";
            // 
            // fromDateTime
            // 
            this.fromDateTime.Enabled = false;
            this.fromDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTime.Location = new System.Drawing.Point(90, 280);
            this.fromDateTime.Name = "fromDateTime";
            this.fromDateTime.Size = new System.Drawing.Size(250, 30);
            this.fromDateTime.TabIndex = 43;
            this.fromDateTime.ValueChanged += new System.EventHandler(this.fromDateTime_ValueChanged);
            // 
            // toDateTime
            // 
            this.toDateTime.Enabled = false;
            this.toDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTime.Location = new System.Drawing.Point(90, 316);
            this.toDateTime.Name = "toDateTime";
            this.toDateTime.Size = new System.Drawing.Size(250, 30);
            this.toDateTime.TabIndex = 44;
            this.toDateTime.ValueChanged += new System.EventHandler(this.toDateTime_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(26, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "To:";
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statisticsBtn.Location = new System.Drawing.Point(364, 328);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(241, 29);
            this.statisticsBtn.TabIndex = 47;
            this.statisticsBtn.Text = "Read period time statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // forecastValuesCheckBox
            // 
            this.forecastValuesCheckBox.AutoSize = true;
            this.forecastValuesCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forecastValuesCheckBox.Location = new System.Drawing.Point(26, 240);
            this.forecastValuesCheckBox.Name = "forecastValuesCheckBox";
            this.forecastValuesCheckBox.Size = new System.Drawing.Size(100, 26);
            this.forecastValuesCheckBox.TabIndex = 39;
            this.forecastValuesCheckBox.Text = "Forecast";
            this.forecastValuesCheckBox.UseVisualStyleBackColor = true;
            this.forecastValuesCheckBox.CheckedChanged += new System.EventHandler(this.liveModeCheckBox_CheckedChanged);
            // 
            // horizonNumeric
            // 
            this.horizonNumeric.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horizonNumeric.Location = new System.Drawing.Point(132, 239);
            this.horizonNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.horizonNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horizonNumeric.Name = "horizonNumeric";
            this.horizonNumeric.Size = new System.Drawing.Size(60, 30);
            this.horizonNumeric.TabIndex = 40;
            this.horizonNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblFutureValues
            // 
            this.lblFutureValues.AutoSize = true;
            this.lblFutureValues.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFutureValues.Location = new System.Drawing.Point(210, 241);
            this.lblFutureValues.Name = "lblFutureValues";
            this.lblFutureValues.Size = new System.Drawing.Size(111, 22);
            this.lblFutureValues.TabIndex = 20;
            this.lblFutureValues.Text = "future values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 853);
            this.Controls.Add(this.statisticsBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toDateTime);
            this.Controls.Add(this.fromDateTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeUnitComboBox);
            this.Controls.Add(this.horizonNumeric);
            this.Controls.Add(this.lastXNumeric);
            this.Controls.Add(this.forecastValuesCheckBox);
            this.Controls.Add(this.liveModeCheckBox);
            this.Controls.Add(this.clearTagsBtn);
            this.Controls.Add(this.removeTagBtn);
            this.Controls.Add(this.addTagBtn);
            this.Controls.Add(this.tagComboBox);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.mainPlot);
            this.Controls.Add(this.btnBottleLabel);
            this.Controls.Add(this.txtBottleLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalBottleNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStopFillingBottles);
            this.Controls.Add(this.picStopFillingBottles);
            this.Controls.Add(this.lblStopFillingSilos);
            this.Controls.Add(this.picStopFillingSilos);
            this.Controls.Add(this.lblFillingBottles);
            this.Controls.Add(this.picFillingBottles);
            this.Controls.Add(this.bottlePictureBox);
            this.Controls.Add(this.lblFutureValues);
            this.Controls.Add(this.lblFillingSilos);
            this.Controls.Add(this.picFillingSilos);
            this.Controls.Add(this.plotItemRatio);
            this.Controls.Add(this.lblServerError);
            this.Controls.Add(this.plotFlavor);
            this.Controls.Add(this.plotColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJuiceProduction);
            this.Controls.Add(this.plotWater);
            this.Controls.Add(this.lblEndpointUrl);
            this.Controls.Add(this.txtEndpointUrl);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flavorSilosPictureBox);
            this.Controls.Add(this.colorSilosPictureBox);
            this.Controls.Add(this.waterSilosPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Process Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.waterSilosPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSilosPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorSilosPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillingSilos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillingBottles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopFillingSilos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopFillingBottles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastXNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizonNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox waterSilosPictureBox;
        private PictureBox colorSilosPictureBox;
        private PictureBox flavorSilosPictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConnectDisconnect;
        private TextBox txtEndpointUrl;
        private Label lblEndpointUrl;
        private ScottPlot.FormsPlot plotWater;
        private System.Windows.Forms.Timer timer;
        private Label lblJuiceProduction;
        private Label label5;
        private ScottPlot.FormsPlot plotColor;
        private ScottPlot.FormsPlot plotFlavor;
        private Label lblServerError;
        private ScottPlot.FormsPlot plotItemRatio;
        private PictureBox picFillingSilos;
        private Label lblFillingSilos;
        private PictureBox bottlePictureBox;
        private Label lblFillingBottles;
        private PictureBox picFillingBottles;
        private Label lblStopFillingSilos;
        private PictureBox picStopFillingSilos;
        private Label lblStopFillingBottles;
        private PictureBox picStopFillingBottles;
        private Label label6;
        private Label lblTotalBottleNumber;
        private Label label7;
        private TextBox txtBottleLabel;
        private Button btnBottleLabel;
        private ScottPlot.FormsPlot mainPlot;
        private ListBox tagsListBox;
        private ComboBox tagComboBox;
        private Button addTagBtn;
        private Button removeTagBtn;
        private Button clearTagsBtn;
        private CheckBox liveModeCheckBox;
        private NumericUpDown lastXNumeric;
        private ComboBox timeUnitComboBox;
        private Label label8;
        private DateTimePicker fromDateTime;
        private DateTimePicker toDateTime;
        private Label label9;
        private Label label10;
        private Button statisticsBtn;
        private CheckBox forecastValuesCheckBox;
        private NumericUpDown horizonNumeric;
        private Label lblFutureValues;
    }
}