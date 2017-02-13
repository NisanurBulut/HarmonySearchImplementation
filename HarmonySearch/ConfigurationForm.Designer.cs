﻿namespace HarmonySearch
{
    partial class ConfigurationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.playButton = new System.Windows.Forms.Button();
            this.HarmonySearchLabel = new System.Windows.Forms.Label();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.ObjectiveLabel = new System.Windows.Forms.Label();
            this.x2Label = new System.Windows.Forms.Label();
            this.x1Label = new System.Windows.Forms.Label();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.HMSLabel = new System.Windows.Forms.Label();
            this.NILabel = new System.Windows.Forms.Label();
            this.PARMaxLabel = new System.Windows.Forms.Label();
            this.PARMinLabel = new System.Windows.Forms.Label();
            this.BWMinLabel = new System.Windows.Forms.Label();
            this.BWMaxLabel = new System.Windows.Forms.Label();
            this.BWLabel = new System.Windows.Forms.Label();
            this.PARLabel = new System.Windows.Forms.Label();
            this.HMCRLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.problemTab = new System.Windows.Forms.TabPage();
            this.showAllCheckBox = new System.Windows.Forms.CheckBox();
            this.RunOptionsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaxRadioBtn = new System.Windows.Forms.RadioButton();
            this.MinRadioBtn = new System.Windows.Forms.RadioButton();
            this.ObjectiveTextBox = new System.Windows.Forms.TextBox();
            this.variablesTab = new System.Windows.Forms.TabPage();
            this.x2MaxTextBox = new System.Windows.Forms.TextBox();
            this.x2MinTextBox = new System.Windows.Forms.TextBox();
            this.x1MinTextBox = new System.Windows.Forms.TextBox();
            this.x1MaxTextBox = new System.Windows.Forms.TextBox();
            this.algorithmTab = new System.Windows.Forms.TabPage();
            this.ParametersLabel = new System.Windows.Forms.Label();
            this.PARTextBox = new System.Windows.Forms.TextBox();
            this.HMCRTextBox = new System.Windows.Forms.TextBox();
            this.BWMinTextBox = new System.Windows.Forms.TextBox();
            this.BWMaxTextBox = new System.Windows.Forms.TextBox();
            this.PARMaxTextBox = new System.Windows.Forms.TextBox();
            this.PARMinTextBox = new System.Windows.Forms.TextBox();
            this.BWTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImprovedRadioButton = new System.Windows.Forms.RadioButton();
            this.AdaptiveRadioButton = new System.Windows.Forms.RadioButton();
            this.GlobalRadioButton = new System.Windows.Forms.RadioButton();
            this.ClassicRadioButton = new System.Windows.Forms.RadioButton();
            this.HSVariantsLabel = new System.Windows.Forms.Label();
            this.HMSTextBox = new System.Windows.Forms.TextBox();
            this.NITextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.problemTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.variablesTab.SuspendLayout();
            this.algorithmTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(437, 609);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(160, 48);
            this.playButton.TabIndex = 28;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // HarmonySearchLabel
            // 
            this.HarmonySearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HarmonySearchLabel.AutoSize = true;
            this.HarmonySearchLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HarmonySearchLabel.Location = new System.Drawing.Point(379, 9);
            this.HarmonySearchLabel.Name = "HarmonySearchLabel";
            this.HarmonySearchLabel.Size = new System.Drawing.Size(302, 31);
            this.HarmonySearchLabel.TabIndex = 29;
            this.HarmonySearchLabel.Text = "HARMONY SEARCH LAB";
            this.HarmonySearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ObjectiveLabel
            // 
            this.ObjectiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectiveLabel.AutoSize = true;
            this.ObjectiveLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ObjectiveLabel.Location = new System.Drawing.Point(396, 38);
            this.ObjectiveLabel.Name = "ObjectiveLabel";
            this.ObjectiveLabel.Size = new System.Drawing.Size(198, 18);
            this.ObjectiveLabel.TabIndex = 100;
            this.ObjectiveLabel.Text = "Objective Function:";
            this.Tips.SetToolTip(this.ObjectiveLabel, "Objective Function");
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.x2Label.Location = new System.Drawing.Point(150, 152);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(28, 18);
            this.x2Label.TabIndex = 127;
            this.x2Label.Text = "X2";
            this.Tips.SetToolTip(this.x2Label, "X2 Decision Variable");
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.x1Label.Location = new System.Drawing.Point(150, 102);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(28, 18);
            this.x1Label.TabIndex = 120;
            this.x1Label.Text = "X1";
            this.Tips.SetToolTip(this.x1Label, "X1 Decision Variable");
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MinValueLabel.Location = new System.Drawing.Point(279, 58);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(138, 18);
            this.MinValueLabel.TabIndex = 119;
            this.MinValueLabel.Text = "Minimum Value";
            this.Tips.SetToolTip(this.MinValueLabel, "Minimum Value of Decision Variable");
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MaxValueLabel.Location = new System.Drawing.Point(629, 58);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(138, 18);
            this.MaxValueLabel.TabIndex = 118;
            this.MaxValueLabel.Text = "Maximum Value";
            this.Tips.SetToolTip(this.MaxValueLabel, "Maximum Value of Decision Variable");
            // 
            // HMSLabel
            // 
            this.HMSLabel.AutoSize = true;
            this.HMSLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HMSLabel.Location = new System.Drawing.Point(67, 91);
            this.HMSLabel.Name = "HMSLabel";
            this.HMSLabel.Size = new System.Drawing.Size(38, 18);
            this.HMSLabel.TabIndex = 25;
            this.HMSLabel.Tag = "";
            this.HMSLabel.Text = "HMS";
            this.Tips.SetToolTip(this.HMSLabel, "Harmony Memory Size");
            // 
            // NILabel
            // 
            this.NILabel.AutoSize = true;
            this.NILabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NILabel.Location = new System.Drawing.Point(67, 60);
            this.NILabel.Name = "NILabel";
            this.NILabel.Size = new System.Drawing.Size(28, 18);
            this.NILabel.TabIndex = 23;
            this.NILabel.Text = "NI";
            this.Tips.SetToolTip(this.NILabel, "Number of Imrpovisations");
            // 
            // PARMaxLabel
            // 
            this.PARMaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PARMaxLabel.AutoSize = true;
            this.PARMaxLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PARMaxLabel.Location = new System.Drawing.Point(560, 398);
            this.PARMaxLabel.Name = "PARMaxLabel";
            this.PARMaxLabel.Size = new System.Drawing.Size(68, 18);
            this.PARMaxLabel.TabIndex = 108;
            this.PARMaxLabel.Tag = "";
            this.PARMaxLabel.Text = "PARmax";
            this.Tips.SetToolTip(this.PARMaxLabel, "Maximum Pitch Adjustment Rate");
            this.PARMaxLabel.Visible = false;
            // 
            // PARMinLabel
            // 
            this.PARMinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PARMinLabel.AutoSize = true;
            this.PARMinLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PARMinLabel.Location = new System.Drawing.Point(560, 361);
            this.PARMinLabel.Name = "PARMinLabel";
            this.PARMinLabel.Size = new System.Drawing.Size(68, 18);
            this.PARMinLabel.TabIndex = 107;
            this.PARMinLabel.Tag = "";
            this.PARMinLabel.Text = "PARmin";
            this.Tips.SetToolTip(this.PARMinLabel, "Minimum Pitch Adjustment Rate");
            this.PARMinLabel.Visible = false;
            // 
            // BWMinLabel
            // 
            this.BWMinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BWMinLabel.AutoSize = true;
            this.BWMinLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BWMinLabel.Location = new System.Drawing.Point(772, 361);
            this.BWMinLabel.Name = "BWMinLabel";
            this.BWMinLabel.Size = new System.Drawing.Size(58, 18);
            this.BWMinLabel.TabIndex = 106;
            this.BWMinLabel.Tag = "";
            this.BWMinLabel.Text = "BWmin";
            this.Tips.SetToolTip(this.BWMinLabel, "Minimum Bandwidth");
            this.BWMinLabel.Visible = false;
            // 
            // BWMaxLabel
            // 
            this.BWMaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BWMaxLabel.AutoSize = true;
            this.BWMaxLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BWMaxLabel.Location = new System.Drawing.Point(772, 398);
            this.BWMaxLabel.Name = "BWMaxLabel";
            this.BWMaxLabel.Size = new System.Drawing.Size(58, 18);
            this.BWMaxLabel.TabIndex = 105;
            this.BWMaxLabel.Tag = "";
            this.BWMaxLabel.Text = "BWmax";
            this.Tips.SetToolTip(this.BWMaxLabel, "Maximum Bandwidth");
            this.BWMaxLabel.Visible = false;
            // 
            // BWLabel
            // 
            this.BWLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BWLabel.AutoSize = true;
            this.BWLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BWLabel.Location = new System.Drawing.Point(772, 325);
            this.BWLabel.Name = "BWLabel";
            this.BWLabel.Size = new System.Drawing.Size(28, 18);
            this.BWLabel.TabIndex = 104;
            this.BWLabel.Tag = "";
            this.BWLabel.Text = "BW";
            this.Tips.SetToolTip(this.BWLabel, "Bandwidth");
            // 
            // PARLabel
            // 
            this.PARLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PARLabel.AutoSize = true;
            this.PARLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PARLabel.Location = new System.Drawing.Point(560, 325);
            this.PARLabel.Name = "PARLabel";
            this.PARLabel.Size = new System.Drawing.Size(38, 18);
            this.PARLabel.TabIndex = 103;
            this.PARLabel.Tag = "";
            this.PARLabel.Text = "PAR";
            this.Tips.SetToolTip(this.PARLabel, "Pitch Adjustment Rate");
            // 
            // HMCRLabel
            // 
            this.HMCRLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HMCRLabel.AutoSize = true;
            this.HMCRLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HMCRLabel.Location = new System.Drawing.Point(560, 291);
            this.HMCRLabel.Name = "HMCRLabel";
            this.HMCRLabel.Size = new System.Drawing.Size(48, 18);
            this.HMCRLabel.TabIndex = 102;
            this.HMCRLabel.Tag = "";
            this.HMCRLabel.Text = "HMCR";
            this.Tips.SetToolTip(this.HMCRLabel, "Harmony Memory Consideration Rate");
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.problemTab);
            this.tabControl1.Controls.Add(this.variablesTab);
            this.tabControl1.Controls.Add(this.algorithmTab);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(-6, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 568);
            this.tabControl1.TabIndex = 118;
            // 
            // problemTab
            // 
            this.problemTab.Controls.Add(this.showAllCheckBox);
            this.problemTab.Controls.Add(this.RunOptionsLabel);
            this.problemTab.Controls.Add(this.panel2);
            this.problemTab.Controls.Add(this.ObjectiveTextBox);
            this.problemTab.Controls.Add(this.ObjectiveLabel);
            this.problemTab.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.problemTab.Location = new System.Drawing.Point(4, 22);
            this.problemTab.Name = "problemTab";
            this.problemTab.Padding = new System.Windows.Forms.Padding(3);
            this.problemTab.Size = new System.Drawing.Size(1023, 542);
            this.problemTab.TabIndex = 0;
            this.problemTab.Text = "Problem Settings";
            this.problemTab.UseVisualStyleBackColor = true;
            // 
            // showAllCheckBox
            // 
            this.showAllCheckBox.AutoSize = true;
            this.showAllCheckBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.showAllCheckBox.Location = new System.Drawing.Point(361, 440);
            this.showAllCheckBox.Name = "showAllCheckBox";
            this.showAllCheckBox.Size = new System.Drawing.Size(257, 22);
            this.showAllCheckBox.TabIndex = 104;
            this.showAllCheckBox.Text = "Show all improvisations";
            this.showAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunOptionsLabel
            // 
            this.RunOptionsLabel.AutoSize = true;
            this.RunOptionsLabel.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RunOptionsLabel.Location = new System.Drawing.Point(420, 400);
            this.RunOptionsLabel.Name = "RunOptionsLabel";
            this.RunOptionsLabel.Size = new System.Drawing.Size(128, 18);
            this.RunOptionsLabel.TabIndex = 103;
            this.RunOptionsLabel.Text = "Run Options:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.MaxRadioBtn);
            this.panel2.Controls.Add(this.MinRadioBtn);
            this.panel2.Location = new System.Drawing.Point(410, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 87);
            this.panel2.TabIndex = 102;
            // 
            // MaxRadioBtn
            // 
            this.MaxRadioBtn.AutoSize = true;
            this.MaxRadioBtn.Checked = true;
            this.MaxRadioBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MaxRadioBtn.Location = new System.Drawing.Point(22, 19);
            this.MaxRadioBtn.Name = "MaxRadioBtn";
            this.MaxRadioBtn.Size = new System.Drawing.Size(106, 22);
            this.MaxRadioBtn.TabIndex = 16;
            this.MaxRadioBtn.TabStop = true;
            this.MaxRadioBtn.Text = "Maximize";
            this.MaxRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MinRadioBtn
            // 
            this.MinRadioBtn.AutoSize = true;
            this.MinRadioBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MinRadioBtn.Location = new System.Drawing.Point(22, 47);
            this.MinRadioBtn.Name = "MinRadioBtn";
            this.MinRadioBtn.Size = new System.Drawing.Size(106, 22);
            this.MinRadioBtn.TabIndex = 17;
            this.MinRadioBtn.Text = "Minimize";
            this.MinRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ObjectiveTextBox
            // 
            this.ObjectiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectiveTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ObjectiveTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ObjectiveTextBox.Location = new System.Drawing.Point(3, 79);
            this.ObjectiveTextBox.Name = "ObjectiveTextBox";
            this.ObjectiveTextBox.Size = new System.Drawing.Size(1006, 26);
            this.ObjectiveTextBox.TabIndex = 101;
            this.ObjectiveTextBox.Text = "Sin(x1) * Sin(x2)";
            this.ObjectiveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // variablesTab
            // 
            this.variablesTab.AutoScroll = true;
            this.variablesTab.Controls.Add(this.x2Label);
            this.variablesTab.Controls.Add(this.x2MaxTextBox);
            this.variablesTab.Controls.Add(this.x2MinTextBox);
            this.variablesTab.Controls.Add(this.x1Label);
            this.variablesTab.Controls.Add(this.MinValueLabel);
            this.variablesTab.Controls.Add(this.MaxValueLabel);
            this.variablesTab.Controls.Add(this.x1MinTextBox);
            this.variablesTab.Controls.Add(this.x1MaxTextBox);
            this.variablesTab.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.variablesTab.Location = new System.Drawing.Point(4, 22);
            this.variablesTab.Name = "variablesTab";
            this.variablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.variablesTab.Size = new System.Drawing.Size(1023, 533);
            this.variablesTab.TabIndex = 1;
            this.variablesTab.Text = "Decision Variables";
            this.variablesTab.UseVisualStyleBackColor = true;
            this.variablesTab.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // x2MaxTextBox
            // 
            this.x2MaxTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.x2MaxTextBox.Location = new System.Drawing.Point(567, 150);
            this.x2MaxTextBox.Name = "x2MaxTextBox";
            this.x2MaxTextBox.Size = new System.Drawing.Size(250, 22);
            this.x2MaxTextBox.TabIndex = 122;
            this.x2MaxTextBox.Text = "6.28318530718";
            this.x2MaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x2MinTextBox
            // 
            this.x2MinTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.x2MinTextBox.Location = new System.Drawing.Point(222, 150);
            this.x2MinTextBox.Name = "x2MinTextBox";
            this.x2MinTextBox.Size = new System.Drawing.Size(250, 22);
            this.x2MinTextBox.TabIndex = 121;
            this.x2MinTextBox.Text = "0";
            this.x2MinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x1MinTextBox
            // 
            this.x1MinTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.x1MinTextBox.Location = new System.Drawing.Point(222, 100);
            this.x1MinTextBox.Name = "x1MinTextBox";
            this.x1MinTextBox.Size = new System.Drawing.Size(250, 22);
            this.x1MinTextBox.TabIndex = 117;
            this.x1MinTextBox.Tag = "";
            this.x1MinTextBox.Text = "0";
            this.x1MinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x1MaxTextBox
            // 
            this.x1MaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x1MaxTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.x1MaxTextBox.Location = new System.Drawing.Point(567, 100);
            this.x1MaxTextBox.Name = "x1MaxTextBox";
            this.x1MaxTextBox.Size = new System.Drawing.Size(250, 22);
            this.x1MaxTextBox.TabIndex = 116;
            this.x1MaxTextBox.Tag = "";
            this.x1MaxTextBox.Text = "6.28318530718";
            this.x1MaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // algorithmTab
            // 
            this.algorithmTab.Controls.Add(this.ParametersLabel);
            this.algorithmTab.Controls.Add(this.PARTextBox);
            this.algorithmTab.Controls.Add(this.HMCRTextBox);
            this.algorithmTab.Controls.Add(this.BWMinTextBox);
            this.algorithmTab.Controls.Add(this.BWMaxTextBox);
            this.algorithmTab.Controls.Add(this.PARMaxTextBox);
            this.algorithmTab.Controls.Add(this.PARMinTextBox);
            this.algorithmTab.Controls.Add(this.PARMaxLabel);
            this.algorithmTab.Controls.Add(this.PARMinLabel);
            this.algorithmTab.Controls.Add(this.BWMinLabel);
            this.algorithmTab.Controls.Add(this.BWMaxLabel);
            this.algorithmTab.Controls.Add(this.BWLabel);
            this.algorithmTab.Controls.Add(this.PARLabel);
            this.algorithmTab.Controls.Add(this.HMCRLabel);
            this.algorithmTab.Controls.Add(this.BWTextBox);
            this.algorithmTab.Controls.Add(this.panel1);
            this.algorithmTab.Controls.Add(this.HSVariantsLabel);
            this.algorithmTab.Controls.Add(this.HMSLabel);
            this.algorithmTab.Controls.Add(this.HMSTextBox);
            this.algorithmTab.Controls.Add(this.NILabel);
            this.algorithmTab.Controls.Add(this.NITextBox);
            this.algorithmTab.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.algorithmTab.Location = new System.Drawing.Point(4, 22);
            this.algorithmTab.Name = "algorithmTab";
            this.algorithmTab.Size = new System.Drawing.Size(1023, 533);
            this.algorithmTab.TabIndex = 2;
            this.algorithmTab.Text = "Algorithm Settings";
            this.algorithmTab.UseVisualStyleBackColor = true;
            // 
            // ParametersLabel
            // 
            this.ParametersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametersLabel.AutoSize = true;
            this.ParametersLabel.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ParametersLabel.Location = new System.Drawing.Point(543, 253);
            this.ParametersLabel.Name = "ParametersLabel";
            this.ParametersLabel.Size = new System.Drawing.Size(418, 18);
            this.ParametersLabel.TabIndex = 115;
            this.ParametersLabel.Text = "Parameters of the Classic Harmony Search:";
            // 
            // PARTextBox
            // 
            this.PARTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PARTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PARTextBox.Location = new System.Drawing.Point(636, 321);
            this.PARTextBox.Name = "PARTextBox";
            this.PARTextBox.Size = new System.Drawing.Size(80, 26);
            this.PARTextBox.TabIndex = 114;
            this.PARTextBox.Tag = "";
            this.PARTextBox.Text = "0.15";
            this.PARTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HMCRTextBox
            // 
            this.HMCRTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HMCRTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HMCRTextBox.Location = new System.Drawing.Point(636, 286);
            this.HMCRTextBox.Name = "HMCRTextBox";
            this.HMCRTextBox.Size = new System.Drawing.Size(80, 26);
            this.HMCRTextBox.TabIndex = 113;
            this.HMCRTextBox.Tag = "";
            this.HMCRTextBox.Text = "0.90";
            this.HMCRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BWMinTextBox
            // 
            this.BWMinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BWMinTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BWMinTextBox.Location = new System.Drawing.Point(842, 356);
            this.BWMinTextBox.Name = "BWMinTextBox";
            this.BWMinTextBox.Size = new System.Drawing.Size(80, 26);
            this.BWMinTextBox.TabIndex = 112;
            this.BWMinTextBox.Tag = "";
            this.BWMinTextBox.Text = "0.001";
            this.BWMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BWMinTextBox.Visible = false;
            // 
            // BWMaxTextBox
            // 
            this.BWMaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BWMaxTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BWMaxTextBox.Location = new System.Drawing.Point(842, 390);
            this.BWMaxTextBox.Name = "BWMaxTextBox";
            this.BWMaxTextBox.Size = new System.Drawing.Size(80, 26);
            this.BWMaxTextBox.TabIndex = 111;
            this.BWMaxTextBox.Tag = "";
            this.BWMaxTextBox.Text = "0.1";
            this.BWMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BWMaxTextBox.Visible = false;
            // 
            // PARMaxTextBox
            // 
            this.PARMaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PARMaxTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PARMaxTextBox.Location = new System.Drawing.Point(636, 391);
            this.PARMaxTextBox.Name = "PARMaxTextBox";
            this.PARMaxTextBox.Size = new System.Drawing.Size(80, 26);
            this.PARMaxTextBox.TabIndex = 110;
            this.PARMaxTextBox.Tag = "";
            this.PARMaxTextBox.Text = "0.85";
            this.PARMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PARMaxTextBox.Visible = false;
            // 
            // PARMinTextBox
            // 
            this.PARMinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PARMinTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PARMinTextBox.Location = new System.Drawing.Point(636, 356);
            this.PARMinTextBox.Name = "PARMinTextBox";
            this.PARMinTextBox.Size = new System.Drawing.Size(80, 26);
            this.PARMinTextBox.TabIndex = 109;
            this.PARMinTextBox.Tag = "";
            this.PARMinTextBox.Text = "0.1";
            this.PARMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PARMinTextBox.Visible = false;
            // 
            // BWTextBox
            // 
            this.BWTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BWTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BWTextBox.Location = new System.Drawing.Point(842, 322);
            this.BWTextBox.Name = "BWTextBox";
            this.BWTextBox.Size = new System.Drawing.Size(80, 26);
            this.BWTextBox.TabIndex = 101;
            this.BWTextBox.Tag = "";
            this.BWTextBox.Text = "0.1";
            this.BWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImprovedRadioButton);
            this.panel1.Controls.Add(this.AdaptiveRadioButton);
            this.panel1.Controls.Add(this.GlobalRadioButton);
            this.panel1.Controls.Add(this.ClassicRadioButton);
            this.panel1.Location = new System.Drawing.Point(70, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 119);
            this.panel1.TabIndex = 100;
            // 
            // ImprovedRadioButton
            // 
            this.ImprovedRadioButton.AutoSize = true;
            this.ImprovedRadioButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ImprovedRadioButton.Location = new System.Drawing.Point(3, 33);
            this.ImprovedRadioButton.Name = "ImprovedRadioButton";
            this.ImprovedRadioButton.Size = new System.Drawing.Size(256, 22);
            this.ImprovedRadioButton.TabIndex = 93;
            this.ImprovedRadioButton.Tag = "ImprovedHS";
            this.ImprovedRadioButton.Text = "Improved Harmony Search";
            this.ImprovedRadioButton.UseVisualStyleBackColor = true;
            // 
            // AdaptiveRadioButton
            // 
            this.AdaptiveRadioButton.AutoSize = true;
            this.AdaptiveRadioButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AdaptiveRadioButton.Location = new System.Drawing.Point(3, 89);
            this.AdaptiveRadioButton.Name = "AdaptiveRadioButton";
            this.AdaptiveRadioButton.Size = new System.Drawing.Size(306, 22);
            this.AdaptiveRadioButton.TabIndex = 95;
            this.AdaptiveRadioButton.Tag = "SelfAdaptiveHS";
            this.AdaptiveRadioButton.Text = "Self Adaptive Harmony Search";
            this.AdaptiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // GlobalRadioButton
            // 
            this.GlobalRadioButton.AutoSize = true;
            this.GlobalRadioButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GlobalRadioButton.Location = new System.Drawing.Point(3, 61);
            this.GlobalRadioButton.Name = "GlobalRadioButton";
            this.GlobalRadioButton.Size = new System.Drawing.Size(286, 22);
            this.GlobalRadioButton.TabIndex = 94;
            this.GlobalRadioButton.Tag = "GlobalBestHS";
            this.GlobalRadioButton.Text = "Global Best Harmony Search";
            this.GlobalRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClassicRadioButton
            // 
            this.ClassicRadioButton.AutoSize = true;
            this.ClassicRadioButton.Checked = true;
            this.ClassicRadioButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ClassicRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ClassicRadioButton.Name = "ClassicRadioButton";
            this.ClassicRadioButton.Size = new System.Drawing.Size(246, 22);
            this.ClassicRadioButton.TabIndex = 92;
            this.ClassicRadioButton.TabStop = true;
            this.ClassicRadioButton.Tag = "ClassicHS";
            this.ClassicRadioButton.Text = "Classic Harmony Search";
            this.ClassicRadioButton.UseVisualStyleBackColor = true;
            // 
            // HSVariantsLabel
            // 
            this.HSVariantsLabel.AutoSize = true;
            this.HSVariantsLabel.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HSVariantsLabel.Location = new System.Drawing.Point(91, 253);
            this.HSVariantsLabel.Name = "HSVariantsLabel";
            this.HSVariantsLabel.Size = new System.Drawing.Size(248, 18);
            this.HSVariantsLabel.TabIndex = 99;
            this.HSVariantsLabel.Text = "Harmony Search Variants:";
            // 
            // HMSTextBox
            // 
            this.HMSTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HMSTextBox.Location = new System.Drawing.Point(111, 91);
            this.HMSTextBox.Name = "HMSTextBox";
            this.HMSTextBox.Size = new System.Drawing.Size(57, 22);
            this.HMSTextBox.TabIndex = 24;
            this.HMSTextBox.Tag = "";
            this.HMSTextBox.Text = "20";
            this.HMSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NITextBox
            // 
            this.NITextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NITextBox.Location = new System.Drawing.Point(111, 60);
            this.NITextBox.Name = "NITextBox";
            this.NITextBox.Size = new System.Drawing.Size(57, 22);
            this.NITextBox.TabIndex = 22;
            this.NITextBox.Text = "500";
            this.NITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 669);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.HarmonySearchLabel);
            this.Controls.Add(this.playButton);
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "HARMONY SEARCH";
            this.tabControl1.ResumeLayout(false);
            this.problemTab.ResumeLayout(false);
            this.problemTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.variablesTab.ResumeLayout(false);
            this.variablesTab.PerformLayout();
            this.algorithmTab.ResumeLayout(false);
            this.algorithmTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label HarmonySearchLabel;
        private System.Windows.Forms.ToolTip Tips;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage problemTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton MaxRadioBtn;
        private System.Windows.Forms.RadioButton MinRadioBtn;
        private System.Windows.Forms.TextBox ObjectiveTextBox;
        private System.Windows.Forms.Label ObjectiveLabel;
        private System.Windows.Forms.TabPage variablesTab;
        private System.Windows.Forms.TabPage algorithmTab;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.TextBox x2MaxTextBox;
        private System.Windows.Forms.TextBox x2MinTextBox;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.TextBox x1MinTextBox;
        private System.Windows.Forms.TextBox x1MaxTextBox;
        private System.Windows.Forms.CheckBox showAllCheckBox;
        private System.Windows.Forms.Label RunOptionsLabel;
        private System.Windows.Forms.Label ParametersLabel;
        private System.Windows.Forms.TextBox PARTextBox;
        private System.Windows.Forms.TextBox HMCRTextBox;
        private System.Windows.Forms.TextBox BWMinTextBox;
        private System.Windows.Forms.TextBox BWMaxTextBox;
        private System.Windows.Forms.TextBox PARMaxTextBox;
        private System.Windows.Forms.TextBox PARMinTextBox;
        private System.Windows.Forms.Label PARMaxLabel;
        private System.Windows.Forms.Label PARMinLabel;
        private System.Windows.Forms.Label BWMinLabel;
        private System.Windows.Forms.Label BWMaxLabel;
        private System.Windows.Forms.Label BWLabel;
        private System.Windows.Forms.Label PARLabel;
        private System.Windows.Forms.Label HMCRLabel;
        private System.Windows.Forms.TextBox BWTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ImprovedRadioButton;
        private System.Windows.Forms.RadioButton AdaptiveRadioButton;
        private System.Windows.Forms.RadioButton GlobalRadioButton;
        private System.Windows.Forms.RadioButton ClassicRadioButton;
        private System.Windows.Forms.Label HSVariantsLabel;
        private System.Windows.Forms.Label HMSLabel;
        private System.Windows.Forms.TextBox HMSTextBox;
        private System.Windows.Forms.Label NILabel;
        private System.Windows.Forms.TextBox NITextBox;
    }
}

