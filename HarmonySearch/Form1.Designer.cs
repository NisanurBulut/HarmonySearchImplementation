namespace HarmonySearch
{
    partial class HarmonyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PlotButton = new System.Windows.Forms.Button();
            this.NITextBox = new System.Windows.Forms.TextBox();
            this.HMCRTextBox = new System.Windows.Forms.TextBox();
            this.PARTextBox = new System.Windows.Forms.TextBox();
            this.BwTextBox = new System.Windows.Forms.TextBox();
            this.ECRTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxRadioBtn = new System.Windows.Forms.RadioButton();
            this.MinRadioBtn = new System.Windows.Forms.RadioButton();
            this.HMSTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalNotesTextBox = new System.Windows.Forms.TextBox();
            this.MaxValueTextBox = new System.Windows.Forms.TextBox();
            this.MinValueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 191);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1054, 418);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // PlotButton
            // 
            this.PlotButton.Location = new System.Drawing.Point(1072, 191);
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.Size = new System.Drawing.Size(81, 40);
            this.PlotButton.TabIndex = 5;
            this.PlotButton.Text = "Plot";
            this.PlotButton.UseVisualStyleBackColor = true;
            this.PlotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // NITextBox
            // 
            this.NITextBox.Enabled = false;
            this.NITextBox.Location = new System.Drawing.Point(72, 31);
            this.NITextBox.Name = "NITextBox";
            this.NITextBox.Size = new System.Drawing.Size(57, 20);
            this.NITextBox.TabIndex = 6;
            this.NITextBox.Text = "250";
            this.NITextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // HMCRTextBox
            // 
            this.HMCRTextBox.Enabled = false;
            this.HMCRTextBox.Location = new System.Drawing.Point(72, 57);
            this.HMCRTextBox.Name = "HMCRTextBox";
            this.HMCRTextBox.Size = new System.Drawing.Size(57, 20);
            this.HMCRTextBox.TabIndex = 7;
            this.HMCRTextBox.Text = "0.80";
            this.HMCRTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PARTextBox
            // 
            this.PARTextBox.Enabled = false;
            this.PARTextBox.Location = new System.Drawing.Point(72, 83);
            this.PARTextBox.Name = "PARTextBox";
            this.PARTextBox.Size = new System.Drawing.Size(57, 20);
            this.PARTextBox.TabIndex = 8;
            this.PARTextBox.Text = "0.15";
            this.PARTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // BwTextBox
            // 
            this.BwTextBox.Enabled = false;
            this.BwTextBox.Location = new System.Drawing.Point(72, 109);
            this.BwTextBox.Name = "BwTextBox";
            this.BwTextBox.Size = new System.Drawing.Size(57, 20);
            this.BwTextBox.TabIndex = 9;
            this.BwTextBox.Text = "2.048";
            // 
            // ECRTextBox
            // 
            this.ECRTextBox.Enabled = false;
            this.ECRTextBox.Location = new System.Drawing.Point(72, 135);
            this.ECRTextBox.Name = "ECRTextBox";
            this.ECRTextBox.Size = new System.Drawing.Size(57, 20);
            this.ECRTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "HMCR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "PAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "BW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ECR";
            // 
            // MaxRadioBtn
            // 
            this.MaxRadioBtn.AutoSize = true;
            this.MaxRadioBtn.Enabled = false;
            this.MaxRadioBtn.Location = new System.Drawing.Point(157, 138);
            this.MaxRadioBtn.Name = "MaxRadioBtn";
            this.MaxRadioBtn.Size = new System.Drawing.Size(68, 17);
            this.MaxRadioBtn.TabIndex = 16;
            this.MaxRadioBtn.TabStop = true;
            this.MaxRadioBtn.Text = "Maximize";
            this.MaxRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MinRadioBtn
            // 
            this.MinRadioBtn.AutoSize = true;
            this.MinRadioBtn.Enabled = false;
            this.MinRadioBtn.Location = new System.Drawing.Point(231, 138);
            this.MinRadioBtn.Name = "MinRadioBtn";
            this.MinRadioBtn.Size = new System.Drawing.Size(65, 17);
            this.MinRadioBtn.TabIndex = 17;
            this.MinRadioBtn.TabStop = true;
            this.MinRadioBtn.Text = "Minimize";
            this.MinRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HMSTextBox
            // 
            this.HMSTextBox.Enabled = false;
            this.HMSTextBox.Location = new System.Drawing.Point(231, 31);
            this.HMSTextBox.Name = "HMSTextBox";
            this.HMSTextBox.Size = new System.Drawing.Size(57, 20);
            this.HMSTextBox.TabIndex = 18;
            this.HMSTextBox.Text = "30";
            this.HMSTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "HMS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Notes";
            // 
            // TotalNotesTextBox
            // 
            this.TotalNotesTextBox.Enabled = false;
            this.TotalNotesTextBox.Location = new System.Drawing.Point(231, 57);
            this.TotalNotesTextBox.Name = "TotalNotesTextBox";
            this.TotalNotesTextBox.Size = new System.Drawing.Size(57, 20);
            this.TotalNotesTextBox.TabIndex = 21;
            this.TotalNotesTextBox.Text = "2";
            this.TotalNotesTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MaxValueTextBox
            // 
            this.MaxValueTextBox.Enabled = false;
            this.MaxValueTextBox.Location = new System.Drawing.Point(231, 83);
            this.MaxValueTextBox.Name = "MaxValueTextBox";
            this.MaxValueTextBox.Size = new System.Drawing.Size(57, 20);
            this.MaxValueTextBox.TabIndex = 22;
            this.MaxValueTextBox.Text = "2.048";
            this.MaxValueTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MinValueTextBox
            // 
            this.MinValueTextBox.Enabled = false;
            this.MinValueTextBox.Location = new System.Drawing.Point(231, 109);
            this.MinValueTextBox.Name = "MinValueTextBox";
            this.MinValueTextBox.Size = new System.Drawing.Size(57, 20);
            this.MinValueTextBox.TabIndex = 23;
            this.MinValueTextBox.Text = "-2.048";
            this.MinValueTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Max Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Min Value";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(356, 29);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(356, 60);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 27;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HarmonyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 621);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MinValueTextBox);
            this.Controls.Add(this.MaxValueTextBox);
            this.Controls.Add(this.TotalNotesTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HMSTextBox);
            this.Controls.Add(this.MinRadioBtn);
            this.Controls.Add(this.MaxRadioBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ECRTextBox);
            this.Controls.Add(this.BwTextBox);
            this.Controls.Add(this.PARTextBox);
            this.Controls.Add(this.HMCRTextBox);
            this.Controls.Add(this.NITextBox);
            this.Controls.Add(this.PlotButton);
            this.Controls.Add(this.chart);
            this.Name = "HarmonyForm";
            this.Text = "Studio";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button PlotButton;
        private System.Windows.Forms.TextBox NITextBox;
        private System.Windows.Forms.TextBox HMCRTextBox;
        private System.Windows.Forms.TextBox PARTextBox;
        private System.Windows.Forms.TextBox BwTextBox;
        private System.Windows.Forms.TextBox ECRTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton MaxRadioBtn;
        private System.Windows.Forms.RadioButton MinRadioBtn;
        private System.Windows.Forms.TextBox HMSTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalNotesTextBox;
        private System.Windows.Forms.TextBox MaxValueTextBox;
        private System.Windows.Forms.TextBox MinValueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

