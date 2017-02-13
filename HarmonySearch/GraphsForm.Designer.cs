namespace HarmonySearch
{
    partial class GraphsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BestHarmonyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.X2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X1Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.BestHarmonyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // BestHarmonyChart
            // 
            chartArea4.Name = "ChartArea1";
            this.BestHarmonyChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BestHarmonyChart.Legends.Add(legend4);
            this.BestHarmonyChart.Location = new System.Drawing.Point(23, 170);
            this.BestHarmonyChart.Name = "BestHarmonyChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.BestHarmonyChart.Series.Add(series4);
            this.BestHarmonyChart.Size = new System.Drawing.Size(695, 578);
            this.BestHarmonyChart.TabIndex = 5;
            this.BestHarmonyChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(23, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 61);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(501, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "HARMONY SEARCH LAB";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(23, 53);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 27);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1137, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 278);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1180, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Show me the average";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // X2Chart
            // 
            chartArea5.Name = "ChartArea1";
            this.X2Chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.X2Chart.Legends.Add(legend5);
            this.X2Chart.Location = new System.Drawing.Point(724, 170);
            this.X2Chart.Name = "X2Chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.X2Chart.Series.Add(series5);
            this.X2Chart.Size = new System.Drawing.Size(306, 294);
            this.X2Chart.TabIndex = 35;
            this.X2Chart.Text = "chart1";
            // 
            // X1Chart
            // 
            chartArea6.Name = "ChartArea1";
            this.X1Chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.X1Chart.Legends.Add(legend6);
            this.X1Chart.Location = new System.Drawing.Point(724, 454);
            this.X1Chart.Name = "X1Chart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.X1Chart.Series.Add(series6);
            this.X1Chart.Size = new System.Drawing.Size(306, 294);
            this.X1Chart.TabIndex = 36;
            this.X1Chart.Text = "chart2";
            // 
            // SearchProgress
            // 
            this.SearchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgress.Location = new System.Drawing.Point(-5, 754);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(1375, 52);
            this.SearchProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SearchProgress.TabIndex = 37;
            // 
            // GraphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 806);
            this.Controls.Add(this.SearchProgress);
            this.Controls.Add(this.X1Chart);
            this.Controls.Add(this.X2Chart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BestHarmonyChart);
            this.Name = "GraphsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harmony Search";
            this.Activated += new System.EventHandler(this.GraphsForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.BestHarmonyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BestHarmonyChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart X2Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart X1Chart;
        private System.Windows.Forms.ProgressBar SearchProgress;
    }
}