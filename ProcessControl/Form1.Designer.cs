namespace ProcessControl
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
            ((System.ComponentModel.ISupportInitialize)(this.waterSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillingSilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFillingBottles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopFillingSilos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopFillingBottles)).BeginInit();
            this.SuspendLayout();
            // 
            // waterSilosPictureBox
            // 
            this.waterSilosPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("waterSilosPictureBox.Image")));
            this.waterSilosPictureBox.Location = new System.Drawing.Point(796, 168);
            this.waterSilosPictureBox.Name = "waterSilosPictureBox";
            this.waterSilosPictureBox.Size = new System.Drawing.Size(132, 294);
            this.waterSilosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.waterSilosPictureBox.TabIndex = 0;
            this.waterSilosPictureBox.TabStop = false;
            // 
            // colorSilosPictureBox
            // 
            this.colorSilosPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("colorSilosPictureBox.Image")));
            this.colorSilosPictureBox.Location = new System.Drawing.Point(1193, 168);
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
            this.label1.Location = new System.Drawing.Point(868, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 5);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(868, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 50);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1267, 465);
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
            this.btnConnectDisconnect.Location = new System.Drawing.Point(657, 19);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnectDisconnect.TabIndex = 7;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.UseVisualStyleBackColor = true;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // txtEndpointUrl
            // 
            this.txtEndpointUrl.Location = new System.Drawing.Point(165, 20);
            this.txtEndpointUrl.Name = "txtEndpointUrl";
            this.txtEndpointUrl.Size = new System.Drawing.Size(486, 27);
            this.txtEndpointUrl.TabIndex = 8;
            // 
            // lblEndpointUrl
            // 
            this.lblEndpointUrl.AutoSize = true;
            this.lblEndpointUrl.Location = new System.Drawing.Point(12, 23);
            this.lblEndpointUrl.Name = "lblEndpointUrl";
            this.lblEndpointUrl.Size = new System.Drawing.Size(147, 20);
            this.lblEndpointUrl.TabIndex = 9;
            this.lblEndpointUrl.Text = "Server Endpoint URL:";
            // 
            // plotWater
            // 
            this.plotWater.Location = new System.Drawing.Point(936, 168);
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
            this.lblJuiceProduction.Location = new System.Drawing.Point(1193, 82);
            this.lblJuiceProduction.Name = "lblJuiceProduction";
            this.lblJuiceProduction.Size = new System.Drawing.Size(234, 37);
            this.lblJuiceProduction.TabIndex = 11;
            this.lblJuiceProduction.Text = "Juice Production";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(1130, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(5, 70);
            this.label5.TabIndex = 14;
            // 
            // plotColor
            // 
            this.plotColor.Location = new System.Drawing.Point(1333, 168);
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
            this.lblServerError.Location = new System.Drawing.Point(1207, 23);
            this.lblServerError.Name = "lblServerError";
            this.lblServerError.Size = new System.Drawing.Size(202, 37);
            this.lblServerError.TabIndex = 17;
            this.lblServerError.Text = "Server Error";
            this.lblServerError.Visible = false;
            // 
            // plotItemRatio
            // 
            this.plotItemRatio.Location = new System.Drawing.Point(1635, 582);
            this.plotItemRatio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plotItemRatio.Name = "plotItemRatio";
            this.plotItemRatio.Size = new System.Drawing.Size(213, 211);
            this.plotItemRatio.TabIndex = 18;
            // 
            // picFillingSilos
            // 
            this.picFillingSilos.BackColor = System.Drawing.Color.Lime;
            this.picFillingSilos.Location = new System.Drawing.Point(822, 595);
            this.picFillingSilos.Name = "picFillingSilos";
            this.picFillingSilos.Size = new System.Drawing.Size(40, 40);
            this.picFillingSilos.TabIndex = 19;
            this.picFillingSilos.TabStop = false;
            this.picFillingSilos.Visible = false;
            // 
            // lblFillingSilos
            // 
            this.lblFillingSilos.AutoSize = true;
            this.lblFillingSilos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFillingSilos.Location = new System.Drawing.Point(868, 602);
            this.lblFillingSilos.Name = "lblFillingSilos";
            this.lblFillingSilos.Size = new System.Drawing.Size(137, 26);
            this.lblFillingSilos.TabIndex = 20;
            this.lblFillingSilos.Text = "Silos filling...";
            // 
            // bottlePictureBox
            // 
            this.bottlePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bottlePictureBox.Image")));
            this.bottlePictureBox.Location = new System.Drawing.Point(1079, 582);
            this.bottlePictureBox.Name = "bottlePictureBox";
            this.bottlePictureBox.Size = new System.Drawing.Size(103, 211);
            this.bottlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottlePictureBox.TabIndex = 21;
            this.bottlePictureBox.TabStop = false;
            // 
            // lblFillingBottles
            // 
            this.lblFillingBottles.AutoSize = true;
            this.lblFillingBottles.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFillingBottles.Location = new System.Drawing.Point(868, 714);
            this.lblFillingBottles.Name = "lblFillingBottles";
            this.lblFillingBottles.Size = new System.Drawing.Size(154, 26);
            this.lblFillingBottles.TabIndex = 23;
            this.lblFillingBottles.Text = "Bottles filling...";
            // 
            // picFillingBottles
            // 
            this.picFillingBottles.BackColor = System.Drawing.Color.Lime;
            this.picFillingBottles.Location = new System.Drawing.Point(822, 707);
            this.picFillingBottles.Name = "picFillingBottles";
            this.picFillingBottles.Size = new System.Drawing.Size(40, 40);
            this.picFillingBottles.TabIndex = 22;
            this.picFillingBottles.TabStop = false;
            this.picFillingBottles.Visible = false;
            // 
            // lblStopFillingSilos
            // 
            this.lblStopFillingSilos.AutoSize = true;
            this.lblStopFillingSilos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopFillingSilos.Location = new System.Drawing.Point(868, 648);
            this.lblStopFillingSilos.Name = "lblStopFillingSilos";
            this.lblStopFillingSilos.Size = new System.Drawing.Size(164, 26);
            this.lblStopFillingSilos.TabIndex = 25;
            this.lblStopFillingSilos.Text = "Stop silos filling";
            // 
            // picStopFillingSilos
            // 
            this.picStopFillingSilos.BackColor = System.Drawing.Color.Red;
            this.picStopFillingSilos.Location = new System.Drawing.Point(822, 641);
            this.picStopFillingSilos.Name = "picStopFillingSilos";
            this.picStopFillingSilos.Size = new System.Drawing.Size(40, 40);
            this.picStopFillingSilos.TabIndex = 24;
            this.picStopFillingSilos.TabStop = false;
            this.picStopFillingSilos.Visible = false;
            // 
            // lblStopFillingBottles
            // 
            this.lblStopFillingBottles.AutoSize = true;
            this.lblStopFillingBottles.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopFillingBottles.Location = new System.Drawing.Point(868, 760);
            this.lblStopFillingBottles.Name = "lblStopFillingBottles";
            this.lblStopFillingBottles.Size = new System.Drawing.Size(183, 26);
            this.lblStopFillingBottles.TabIndex = 27;
            this.lblStopFillingBottles.Text = "Stop bottles filling";
            // 
            // picStopFillingBottles
            // 
            this.picStopFillingBottles.BackColor = System.Drawing.Color.Red;
            this.picStopFillingBottles.Location = new System.Drawing.Point(822, 753);
            this.picStopFillingBottles.Name = "picStopFillingBottles";
            this.picStopFillingBottles.Size = new System.Drawing.Size(40, 40);
            this.picStopFillingBottles.TabIndex = 26;
            this.picStopFillingBottles.TabStop = false;
            this.picStopFillingBottles.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1207, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(391, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total number of monitored filled bottles:";
            // 
            // lblTotalBottleNumber
            // 
            this.lblTotalBottleNumber.AutoSize = true;
            this.lblTotalBottleNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBottleNumber.Location = new System.Drawing.Point(1207, 624);
            this.lblTotalBottleNumber.Name = "lblTotalBottleNumber";
            this.lblTotalBottleNumber.Size = new System.Drawing.Size(23, 26);
            this.lblTotalBottleNumber.TabIndex = 29;
            this.lblTotalBottleNumber.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1207, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Bottle label:";
            // 
            // txtBottleLabel
            // 
            this.txtBottleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBottleLabel.Location = new System.Drawing.Point(1207, 714);
            this.txtBottleLabel.Name = "txtBottleLabel";
            this.txtBottleLabel.Size = new System.Drawing.Size(391, 34);
            this.txtBottleLabel.TabIndex = 31;
            // 
            // btnBottleLabel
            // 
            this.btnBottleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBottleLabel.Location = new System.Drawing.Point(1477, 754);
            this.btnBottleLabel.Name = "btnBottleLabel";
            this.btnBottleLabel.Size = new System.Drawing.Size(121, 34);
            this.btnBottleLabel.TabIndex = 32;
            this.btnBottleLabel.Text = "Set";
            this.btnBottleLabel.UseVisualStyleBackColor = true;
            this.btnBottleLabel.Click += new System.EventHandler(this.btnBottleLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 853);
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
    }
}