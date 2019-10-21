namespace Harmony_Search_Implements.Screens
{
    partial class HarmonyOptimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarmonyOptimalForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.numericsTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.averageButton = new System.Windows.Forms.Button();
            this.resultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.RerunButton = new System.Windows.Forms.Button();
            this.SearchProgress = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.numericsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SearchProgress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.numericsTab);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabControl1.Location = new System.Drawing.Point(3, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 331);
            this.tabControl1.TabIndex = 39;
            // 
            // numericsTab
            // 
            this.numericsTab.AutoScroll = true;
            this.numericsTab.Controls.Add(this.label4);
            this.numericsTab.Controls.Add(this.averageButton);
            this.numericsTab.Controls.Add(this.resultsRichTextBox);
            this.numericsTab.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericsTab.Location = new System.Drawing.Point(4, 27);
            this.numericsTab.Name = "numericsTab";
            this.numericsTab.Padding = new System.Windows.Forms.Padding(3);
            this.numericsTab.Size = new System.Drawing.Size(786, 300);
            this.numericsTab.TabIndex = 0;
            this.numericsTab.Text = "Sayısal Sonuçlar";
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
            this.label4.Text = "Optimal Uyum\r\n";
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(757, 557);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(619, 34);
            this.averageButton.TabIndex = 36;
            this.averageButton.Text = "Calculate average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Visible = false;
            // 
            // resultsRichTextBox
            // 
            this.resultsRichTextBox.Location = new System.Drawing.Point(434, 35);
            this.resultsRichTextBox.Name = "resultsRichTextBox";
            this.resultsRichTextBox.Size = new System.Drawing.Size(942, 516);
            this.resultsRichTextBox.TabIndex = 35;
            this.resultsRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.RerunButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 61);
            this.panel1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(9, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(59, 61);
            this.BackButton.TabIndex = 34;
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // RerunButton
            // 
            this.RerunButton.Image = ((System.Drawing.Image)(resources.GetObject("RerunButton.Image")));
            this.RerunButton.Location = new System.Drawing.Point(84, 9);
            this.RerunButton.Name = "RerunButton";
            this.RerunButton.Size = new System.Drawing.Size(58, 61);
            this.RerunButton.TabIndex = 33;
            this.RerunButton.UseVisualStyleBackColor = true;
            // 
            // SearchProgress
            // 
            this.SearchProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgress.Location = new System.Drawing.Point(3, 407);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(794, 40);
            this.SearchProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SearchProgress.TabIndex = 40;
            // 
            // HarmonyOptimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HarmonyOptimalForm";
            this.Text = "HarmonyOptimalForm";
            this.Activated += new System.EventHandler(this.HarmonyOptimalForm_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.numericsTab.ResumeLayout(false);
            this.numericsTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage numericsTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.RichTextBox resultsRichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RerunButton;
        private System.Windows.Forms.ProgressBar SearchProgress;
    }
}