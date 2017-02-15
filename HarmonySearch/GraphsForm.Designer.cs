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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BestHarmonyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.numericsTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.aestheticsTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WorstHarmonyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NewHarmonyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.notesTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.BestHarmonyChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.numericsTab.SuspendLayout();
            this.aestheticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorstHarmonyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewHarmonyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BestHarmonyChart
            // 
            chartArea7.Name = "ChartArea1";
            this.BestHarmonyChart.ChartAreas.Add(chartArea7);
            this.BestHarmonyChart.Location = new System.Drawing.Point(15, 94);
            this.BestHarmonyChart.Name = "BestHarmonyChart";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.BestHarmonyChart.Series.Add(series7);
            this.BestHarmonyChart.Size = new System.Drawing.Size(421, 445);
            this.BestHarmonyChart.TabIndex = 5;
            this.BestHarmonyChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(87, 43);
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
            this.label10.Location = new System.Drawing.Point(546, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "HARMONY SEARCH LAB";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(12, 43);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(59, 61);
            this.BackButton.TabIndex = 32;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchProgress
            // 
            this.SearchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgress.Location = new System.Drawing.Point(-5, 754);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(1407, 52);
            this.SearchProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SearchProgress.TabIndex = 37;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.numericsTab);
            this.tabControl1.Controls.Add(this.aestheticsTab);
            this.tabControl1.Controls.Add(this.notesTab);
            this.tabControl1.Location = new System.Drawing.Point(-5, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1407, 636);
            this.tabControl1.TabIndex = 38;
            // 
            // numericsTab
            // 
            this.numericsTab.Controls.Add(this.label4);
            this.numericsTab.Controls.Add(this.button2);
            this.numericsTab.Controls.Add(this.richTextBox1);
            this.numericsTab.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericsTab.Location = new System.Drawing.Point(4, 22);
            this.numericsTab.Name = "numericsTab";
            this.numericsTab.Padding = new System.Windows.Forms.Padding(3);
            this.numericsTab.Size = new System.Drawing.Size(1399, 610);
            this.numericsTab.TabIndex = 0;
            this.numericsTab.Text = "Numeric Results";
            this.numericsTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Best Harmony";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(619, 34);
            this.button2.TabIndex = 36;
            this.button2.Text = "Show me the average";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(757, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(619, 516);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // aestheticsTab
            // 
            this.aestheticsTab.Controls.Add(this.label3);
            this.aestheticsTab.Controls.Add(this.label2);
            this.aestheticsTab.Controls.Add(this.label1);
            this.aestheticsTab.Controls.Add(this.WorstHarmonyChart);
            this.aestheticsTab.Controls.Add(this.NewHarmonyChart);
            this.aestheticsTab.Controls.Add(this.BestHarmonyChart);
            this.aestheticsTab.Location = new System.Drawing.Point(4, 22);
            this.aestheticsTab.Name = "aestheticsTab";
            this.aestheticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.aestheticsTab.Size = new System.Drawing.Size(1399, 610);
            this.aestheticsTab.TabIndex = 1;
            this.aestheticsTab.Text = "Aesthetics Charts";
            this.aestheticsTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(1114, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Worst Harmony";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(651, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Harmony";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(170, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Best Harmony";
            // 
            // WorstHarmonyChart
            // 
            chartArea8.Name = "ChartArea1";
            this.WorstHarmonyChart.ChartAreas.Add(chartArea8);
            this.WorstHarmonyChart.Location = new System.Drawing.Point(963, 94);
            this.WorstHarmonyChart.Name = "WorstHarmonyChart";
            series8.ChartArea = "ChartArea1";
            series8.Name = "Series1";
            this.WorstHarmonyChart.Series.Add(series8);
            this.WorstHarmonyChart.Size = new System.Drawing.Size(421, 445);
            this.WorstHarmonyChart.TabIndex = 7;
            this.WorstHarmonyChart.Text = "chart2";
            // 
            // NewHarmonyChart
            // 
            chartArea9.Name = "ChartArea1";
            this.NewHarmonyChart.ChartAreas.Add(chartArea9);
            this.NewHarmonyChart.Location = new System.Drawing.Point(492, 94);
            this.NewHarmonyChart.Name = "NewHarmonyChart";
            series9.ChartArea = "ChartArea1";
            series9.Name = "Series1";
            this.NewHarmonyChart.Series.Add(series9);
            this.NewHarmonyChart.Size = new System.Drawing.Size(421, 445);
            this.NewHarmonyChart.TabIndex = 6;
            this.NewHarmonyChart.Text = "chart1";
            // 
            // notesTab
            // 
            this.notesTab.AutoScroll = true;
            this.notesTab.Location = new System.Drawing.Point(4, 22);
            this.notesTab.Name = "notesTab";
            this.notesTab.Size = new System.Drawing.Size(1399, 610);
            this.notesTab.TabIndex = 2;
            this.notesTab.Text = "Notes Charts";
            this.notesTab.UseVisualStyleBackColor = true;
            // 
            // GraphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 806);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SearchProgress);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Name = "GraphsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harmony Search";
            this.Activated += new System.EventHandler(this.GraphsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BestHarmonyChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.numericsTab.ResumeLayout(false);
            this.numericsTab.PerformLayout();
            this.aestheticsTab.ResumeLayout(false);
            this.aestheticsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorstHarmonyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewHarmonyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BestHarmonyChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ProgressBar SearchProgress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage numericsTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage aestheticsTab;
        private System.Windows.Forms.TabPage notesTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart WorstHarmonyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart NewHarmonyChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}