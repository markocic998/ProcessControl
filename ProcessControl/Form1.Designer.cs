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
            ((System.ComponentModel.ISupportInitialize)(this.waterSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSilosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorSilosPictureBox)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(1267, 520);
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
            this.lblServerError.Size = new System.Drawing.Size(205, 38);
            this.lblServerError.TabIndex = 17;
            this.lblServerError.Text = "Server Error";
            this.lblServerError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 853);
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
    }
}