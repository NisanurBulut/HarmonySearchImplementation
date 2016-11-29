namespace HarmonySearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.NITextBox = new System.Windows.Forms.TextBox();
            this.ClassicHMCR = new System.Windows.Forms.TextBox();
            this.ClassicPAR = new System.Windows.Forms.TextBox();
            this.ClassicBW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxRadioBtn = new System.Windows.Forms.RadioButton();
            this.MinRadioBtn = new System.Windows.Forms.RadioButton();
            this.classicHMS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalNotesTextBox = new System.Windows.Forms.TextBox();
            this.MaxValueTextBox = new System.Windows.Forms.TextBox();
            this.MinValueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EditCHSButton = new System.Windows.Forms.Button();
            this.ResetCHSButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.EditIHSButton = new System.Windows.Forms.Button();
            this.EditGBHSButton = new System.Windows.Forms.Button();
            this.EditSAHSButton = new System.Windows.Forms.Button();
            this.ResetGBHSButton = new System.Windows.Forms.Button();
            this.ResetSAHSButton = new System.Windows.Forms.Button();
            this.ResetIHSButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.ImprovedHMCR = new System.Windows.Forms.TextBox();
            this.ImprovedPARmin = new System.Windows.Forms.TextBox();
            this.ImprovedPARmax = new System.Windows.Forms.TextBox();
            this.ImprovedBWmax = new System.Windows.Forms.TextBox();
            this.ImprovedBWmin = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.globalHMS = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.globalPAR = new System.Windows.Forms.TextBox();
            this.globalHMCR = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.adaptiveHMS = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.adaptivePAR = new System.Windows.Forms.TextBox();
            this.adaptiveHMCR = new System.Windows.Forms.TextBox();
            this.ImprovedHMS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NITextBox
            // 
            this.NITextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NITextBox.Location = new System.Drawing.Point(57, 118);
            this.NITextBox.Name = "NITextBox";
            this.NITextBox.Size = new System.Drawing.Size(57, 22);
            this.NITextBox.TabIndex = 6;
            this.NITextBox.Text = "250";
            this.NITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClassicHMCR
            // 
            this.ClassicHMCR.Enabled = false;
            this.ClassicHMCR.Location = new System.Drawing.Point(182, 320);
            this.ClassicHMCR.Name = "ClassicHMCR";
            this.ClassicHMCR.Size = new System.Drawing.Size(57, 20);
            this.ClassicHMCR.TabIndex = 7;
            this.ClassicHMCR.Tag = "ClassicHS";
            this.ClassicHMCR.Text = "0.80";
            this.ClassicHMCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClassicHMCR.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ClassicPAR
            // 
            this.ClassicPAR.Enabled = false;
            this.ClassicPAR.Location = new System.Drawing.Point(182, 360);
            this.ClassicPAR.Name = "ClassicPAR";
            this.ClassicPAR.Size = new System.Drawing.Size(57, 20);
            this.ClassicPAR.TabIndex = 8;
            this.ClassicPAR.Tag = "ClassicHS";
            this.ClassicPAR.Text = "0.15";
            this.ClassicPAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClassicPAR.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ClassicBW
            // 
            this.ClassicBW.Enabled = false;
            this.ClassicBW.Location = new System.Drawing.Point(182, 398);
            this.ClassicBW.Name = "ClassicBW";
            this.ClassicBW.Size = new System.Drawing.Size(57, 20);
            this.ClassicBW.TabIndex = 9;
            this.ClassicBW.Tag = "ClassicHS";
            this.ClassicBW.Text = "2.048";
            this.ClassicBW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(65, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "NI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(39, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "HMCR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(39, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "PAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(39, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "BW";
            // 
            // MaxRadioBtn
            // 
            this.MaxRadioBtn.AutoSize = true;
            this.MaxRadioBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MaxRadioBtn.Location = new System.Drawing.Point(1069, 82);
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
            this.MinRadioBtn.Location = new System.Drawing.Point(1069, 122);
            this.MinRadioBtn.Name = "MinRadioBtn";
            this.MinRadioBtn.Size = new System.Drawing.Size(106, 22);
            this.MinRadioBtn.TabIndex = 17;
            this.MinRadioBtn.TabStop = true;
            this.MinRadioBtn.Text = "Minimize";
            this.MinRadioBtn.UseVisualStyleBackColor = true;
            // 
            // classicHMS
            // 
            this.classicHMS.Enabled = false;
            this.classicHMS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.classicHMS.Location = new System.Drawing.Point(182, 282);
            this.classicHMS.Name = "classicHMS";
            this.classicHMS.Size = new System.Drawing.Size(57, 22);
            this.classicHMS.TabIndex = 18;
            this.classicHMS.Tag = "ClassicHS";
            this.classicHMS.Text = "30";
            this.classicHMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.classicHMS.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(39, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "HMS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(132, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Decision Variables";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalNotesTextBox
            // 
            this.TotalNotesTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TotalNotesTextBox.Location = new System.Drawing.Point(208, 118);
            this.TotalNotesTextBox.Name = "TotalNotesTextBox";
            this.TotalNotesTextBox.Size = new System.Drawing.Size(57, 22);
            this.TotalNotesTextBox.TabIndex = 21;
            this.TotalNotesTextBox.Text = "2";
            this.TotalNotesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaxValueTextBox
            // 
            this.MaxValueTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MaxValueTextBox.Location = new System.Drawing.Point(921, 86);
            this.MaxValueTextBox.Name = "MaxValueTextBox";
            this.MaxValueTextBox.Size = new System.Drawing.Size(57, 22);
            this.MaxValueTextBox.TabIndex = 22;
            this.MaxValueTextBox.Tag = "";
            this.MaxValueTextBox.Text = "2.048";
            this.MaxValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinValueTextBox
            // 
            this.MinValueTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MinValueTextBox.Location = new System.Drawing.Point(921, 123);
            this.MinValueTextBox.Name = "MinValueTextBox";
            this.MinValueTextBox.Size = new System.Drawing.Size(57, 22);
            this.MinValueTextBox.TabIndex = 23;
            this.MinValueTextBox.Tag = "";
            this.MinValueTextBox.Text = "-2.048";
            this.MinValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(778, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Max Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(778, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Min Value";
            // 
            // EditCHSButton
            // 
            this.EditCHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EditCHSButton.Location = new System.Drawing.Point(42, 442);
            this.EditCHSButton.Name = "EditCHSButton";
            this.EditCHSButton.Size = new System.Drawing.Size(88, 38);
            this.EditCHSButton.TabIndex = 26;
            this.EditCHSButton.Text = "EDIT";
            this.EditCHSButton.UseVisualStyleBackColor = true;
            this.EditCHSButton.Click += new System.EventHandler(this.EditCHSButton_Click);
            // 
            // ResetCHSButton
            // 
            this.ResetCHSButton.Enabled = false;
            this.ResetCHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ResetCHSButton.Location = new System.Drawing.Point(151, 442);
            this.ResetCHSButton.Name = "ResetCHSButton";
            this.ResetCHSButton.Size = new System.Drawing.Size(88, 38);
            this.ResetCHSButton.TabIndex = 27;
            this.ResetCHSButton.Text = "RESET";
            this.ResetCHSButton.UseVisualStyleBackColor = true;
            this.ResetCHSButton.Click += new System.EventHandler(this.ResetCHSButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(594, 743);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(160, 63);
            this.playButton.TabIndex = 28;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(505, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 31);
            this.label10.TabIndex = 29;
            this.label10.Text = "HARMONY SEARCH LAB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(65, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Classic HS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.Location = new System.Drawing.Point(797, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 21);
            this.label13.TabIndex = 32;
            this.label13.Text = "Global Best HS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label14.Location = new System.Drawing.Point(1065, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 21);
            this.label14.TabIndex = 33;
            this.label14.Text = "Self Adaptive HS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label15.Location = new System.Drawing.Point(462, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Improved HS";
            // 
            // EditIHSButton
            // 
            this.EditIHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EditIHSButton.Location = new System.Drawing.Point(430, 479);
            this.EditIHSButton.Name = "EditIHSButton";
            this.EditIHSButton.Size = new System.Drawing.Size(88, 38);
            this.EditIHSButton.TabIndex = 35;
            this.EditIHSButton.Text = "EDIT";
            this.EditIHSButton.UseVisualStyleBackColor = true;
            this.EditIHSButton.Click += new System.EventHandler(this.EditIHSButton_Click);
            // 
            // EditGBHSButton
            // 
            this.EditGBHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EditGBHSButton.Location = new System.Drawing.Point(779, 392);
            this.EditGBHSButton.Name = "EditGBHSButton";
            this.EditGBHSButton.Size = new System.Drawing.Size(88, 38);
            this.EditGBHSButton.TabIndex = 36;
            this.EditGBHSButton.Text = "EDIT";
            this.EditGBHSButton.UseVisualStyleBackColor = true;
            this.EditGBHSButton.Click += new System.EventHandler(this.EditGBHSButton_Click);
            // 
            // EditSAHSButton
            // 
            this.EditSAHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EditSAHSButton.Location = new System.Drawing.Point(1069, 392);
            this.EditSAHSButton.Name = "EditSAHSButton";
            this.EditSAHSButton.Size = new System.Drawing.Size(88, 38);
            this.EditSAHSButton.TabIndex = 37;
            this.EditSAHSButton.Text = "EDIT";
            this.EditSAHSButton.UseVisualStyleBackColor = true;
            this.EditSAHSButton.Click += new System.EventHandler(this.EditSAHSButton_Click);
            // 
            // ResetGBHSButton
            // 
            this.ResetGBHSButton.Enabled = false;
            this.ResetGBHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ResetGBHSButton.Location = new System.Drawing.Point(890, 392);
            this.ResetGBHSButton.Name = "ResetGBHSButton";
            this.ResetGBHSButton.Size = new System.Drawing.Size(88, 38);
            this.ResetGBHSButton.TabIndex = 39;
            this.ResetGBHSButton.Text = "RESET";
            this.ResetGBHSButton.UseVisualStyleBackColor = true;
            this.ResetGBHSButton.Click += new System.EventHandler(this.ResetGBHSButton_Click);
            // 
            // ResetSAHSButton
            // 
            this.ResetSAHSButton.Enabled = false;
            this.ResetSAHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ResetSAHSButton.Location = new System.Drawing.Point(1163, 392);
            this.ResetSAHSButton.Name = "ResetSAHSButton";
            this.ResetSAHSButton.Size = new System.Drawing.Size(88, 38);
            this.ResetSAHSButton.TabIndex = 40;
            this.ResetSAHSButton.Text = "RESET";
            this.ResetSAHSButton.UseVisualStyleBackColor = true;
            this.ResetSAHSButton.Click += new System.EventHandler(this.ResetSAHSButton_Click);
            // 
            // ResetIHSButton
            // 
            this.ResetIHSButton.Enabled = false;
            this.ResetIHSButton.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ResetIHSButton.Location = new System.Drawing.Point(537, 479);
            this.ResetIHSButton.Name = "ResetIHSButton";
            this.ResetIHSButton.Size = new System.Drawing.Size(88, 38);
            this.ResetIHSButton.TabIndex = 42;
            this.ResetIHSButton.Text = "RESET";
            this.ResetIHSButton.UseVisualStyleBackColor = true;
            this.ResetIHSButton.Click += new System.EventHandler(this.ResetIHSButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label16.Location = new System.Drawing.Point(427, 447);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 18);
            this.label16.TabIndex = 43;
            this.label16.Text = "BWmax";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label17.Location = new System.Drawing.Point(427, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 18);
            this.label17.TabIndex = 44;
            this.label17.Text = "BWmin";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label18.Location = new System.Drawing.Point(427, 350);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 18);
            this.label18.TabIndex = 45;
            this.label18.Text = "PARmin";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label19.Location = new System.Drawing.Point(427, 379);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 18);
            this.label19.TabIndex = 46;
            this.label19.Text = "PARmax";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.Location = new System.Drawing.Point(421, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 18);
            this.label11.TabIndex = 47;
            this.label11.Text = "Objective Function";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(424, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 48;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label22.Location = new System.Drawing.Point(427, 278);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 18);
            this.label22.TabIndex = 58;
            this.label22.Text = "HMS";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label26.Location = new System.Drawing.Point(427, 319);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 18);
            this.label26.TabIndex = 54;
            this.label26.Text = "HMCR";
            // 
            // ImprovedHMCR
            // 
            this.ImprovedHMCR.Enabled = false;
            this.ImprovedHMCR.Location = new System.Drawing.Point(568, 317);
            this.ImprovedHMCR.Name = "ImprovedHMCR";
            this.ImprovedHMCR.Size = new System.Drawing.Size(57, 20);
            this.ImprovedHMCR.TabIndex = 50;
            this.ImprovedHMCR.Tag = "ImprovedHS";
            this.ImprovedHMCR.Text = "0.95";
            this.ImprovedHMCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImprovedHMCR.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ImprovedPARmin
            // 
            this.ImprovedPARmin.Enabled = false;
            this.ImprovedPARmin.Location = new System.Drawing.Point(568, 348);
            this.ImprovedPARmin.Name = "ImprovedPARmin";
            this.ImprovedPARmin.Size = new System.Drawing.Size(57, 20);
            this.ImprovedPARmin.TabIndex = 63;
            this.ImprovedPARmin.Tag = "ImprovedHS";
            this.ImprovedPARmin.Text = "0.1";
            this.ImprovedPARmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImprovedPARmin.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ImprovedPARmax
            // 
            this.ImprovedPARmax.Enabled = false;
            this.ImprovedPARmax.Location = new System.Drawing.Point(568, 379);
            this.ImprovedPARmax.Name = "ImprovedPARmax";
            this.ImprovedPARmax.Size = new System.Drawing.Size(57, 20);
            this.ImprovedPARmax.TabIndex = 64;
            this.ImprovedPARmax.Tag = "ImprovedHS";
            this.ImprovedPARmax.Text = "0.85";
            this.ImprovedPARmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImprovedPARmax.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ImprovedBWmax
            // 
            this.ImprovedBWmax.Enabled = false;
            this.ImprovedBWmax.Location = new System.Drawing.Point(568, 447);
            this.ImprovedBWmax.Name = "ImprovedBWmax";
            this.ImprovedBWmax.Size = new System.Drawing.Size(57, 20);
            this.ImprovedBWmax.TabIndex = 65;
            this.ImprovedBWmax.Tag = "ImprovedHS";
            this.ImprovedBWmax.Text = "0.8";
            this.ImprovedBWmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImprovedBWmax.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ImprovedBWmin
            // 
            this.ImprovedBWmin.Enabled = false;
            this.ImprovedBWmin.Location = new System.Drawing.Point(568, 412);
            this.ImprovedBWmin.Name = "ImprovedBWmin";
            this.ImprovedBWmin.Size = new System.Drawing.Size(57, 20);
            this.ImprovedBWmin.TabIndex = 66;
            this.ImprovedBWmin.Tag = "ImprovedHS";
            this.ImprovedBWmin.Text = "0.001";
            this.ImprovedBWmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImprovedBWmin.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label24.Location = new System.Drawing.Point(785, 282);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 18);
            this.label24.TabIndex = 74;
            this.label24.Text = "HMS";
            // 
            // globalHMS
            // 
            this.globalHMS.Enabled = false;
            this.globalHMS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.globalHMS.Location = new System.Drawing.Point(904, 278);
            this.globalHMS.Name = "globalHMS";
            this.globalHMS.Size = new System.Drawing.Size(57, 22);
            this.globalHMS.TabIndex = 73;
            this.globalHMS.Tag = "GlobalBestHS";
            this.globalHMS.Text = "30";
            this.globalHMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.globalHMS.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label27.Location = new System.Drawing.Point(785, 362);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 18);
            this.label27.TabIndex = 71;
            this.label27.Text = "PAR";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label28.Location = new System.Drawing.Point(785, 323);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 18);
            this.label28.TabIndex = 70;
            this.label28.Text = "HMCR";
            // 
            // globalPAR
            // 
            this.globalPAR.Enabled = false;
            this.globalPAR.Location = new System.Drawing.Point(904, 360);
            this.globalPAR.Name = "globalPAR";
            this.globalPAR.Size = new System.Drawing.Size(57, 20);
            this.globalPAR.TabIndex = 68;
            this.globalPAR.Tag = "GlobalBestHS";
            this.globalPAR.Text = "0.15";
            this.globalPAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.globalPAR.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // globalHMCR
            // 
            this.globalHMCR.Enabled = false;
            this.globalHMCR.Location = new System.Drawing.Point(904, 321);
            this.globalHMCR.Name = "globalHMCR";
            this.globalHMCR.Size = new System.Drawing.Size(57, 20);
            this.globalHMCR.TabIndex = 67;
            this.globalHMCR.Tag = "GlobalBestHS";
            this.globalHMCR.Text = "0.80";
            this.globalHMCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.globalHMCR.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label31.Location = new System.Drawing.Point(1066, 279);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 18);
            this.label31.TabIndex = 86;
            this.label31.Text = "HMS";
            // 
            // adaptiveHMS
            // 
            this.adaptiveHMS.Enabled = false;
            this.adaptiveHMS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.adaptiveHMS.Location = new System.Drawing.Point(1194, 277);
            this.adaptiveHMS.Name = "adaptiveHMS";
            this.adaptiveHMS.Size = new System.Drawing.Size(57, 22);
            this.adaptiveHMS.TabIndex = 85;
            this.adaptiveHMS.Tag = "SelfAdaptiveHS";
            this.adaptiveHMS.Text = "30";
            this.adaptiveHMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adaptiveHMS.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label33.Location = new System.Drawing.Point(1066, 359);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 18);
            this.label33.TabIndex = 83;
            this.label33.Text = "PAR";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label34.Location = new System.Drawing.Point(1066, 320);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 18);
            this.label34.TabIndex = 82;
            this.label34.Text = "HMCR";
            // 
            // adaptivePAR
            // 
            this.adaptivePAR.Enabled = false;
            this.adaptivePAR.Location = new System.Drawing.Point(1194, 357);
            this.adaptivePAR.Name = "adaptivePAR";
            this.adaptivePAR.Size = new System.Drawing.Size(57, 20);
            this.adaptivePAR.TabIndex = 80;
            this.adaptivePAR.Tag = "SelfAdaptiveHS";
            this.adaptivePAR.Text = "0.15";
            this.adaptivePAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adaptivePAR.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // adaptiveHMCR
            // 
            this.adaptiveHMCR.Enabled = false;
            this.adaptiveHMCR.Location = new System.Drawing.Point(1194, 318);
            this.adaptiveHMCR.Name = "adaptiveHMCR";
            this.adaptiveHMCR.Size = new System.Drawing.Size(57, 20);
            this.adaptiveHMCR.TabIndex = 79;
            this.adaptiveHMCR.Tag = "SelfAdaptiveHS";
            this.adaptiveHMCR.Text = "0.80";
            this.adaptiveHMCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adaptiveHMCR.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ImprovedHMS
            // 
            this.ImprovedHMS.Enabled = false;
            this.ImprovedHMS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ImprovedHMS.Location = new System.Drawing.Point(568, 274);
            this.ImprovedHMS.Name = "ImprovedHMS";
            this.ImprovedHMS.Size = new System.Drawing.Size(57, 22);
            this.ImprovedHMS.TabIndex = 91;
            this.ImprovedHMS.Tag = "ImprovedHS";
            this.ImprovedHMS.Text = "30";
            this.ImprovedHMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImprovedHMS.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 818);
            this.Controls.Add(this.ImprovedHMS);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.adaptiveHMS);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.adaptivePAR);
            this.Controls.Add(this.adaptiveHMCR);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.globalHMS);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.globalPAR);
            this.Controls.Add(this.globalHMCR);
            this.Controls.Add(this.ImprovedBWmin);
            this.Controls.Add(this.ImprovedBWmax);
            this.Controls.Add(this.ImprovedPARmax);
            this.Controls.Add(this.ImprovedPARmin);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.ImprovedHMCR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ResetIHSButton);
            this.Controls.Add(this.ResetSAHSButton);
            this.Controls.Add(this.ResetGBHSButton);
            this.Controls.Add(this.EditSAHSButton);
            this.Controls.Add(this.EditGBHSButton);
            this.Controls.Add(this.EditIHSButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.ResetCHSButton);
            this.Controls.Add(this.EditCHSButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MinValueTextBox);
            this.Controls.Add(this.MaxValueTextBox);
            this.Controls.Add(this.TotalNotesTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classicHMS);
            this.Controls.Add(this.MinRadioBtn);
            this.Controls.Add(this.MaxRadioBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassicBW);
            this.Controls.Add(this.ClassicPAR);
            this.Controls.Add(this.ClassicHMCR);
            this.Controls.Add(this.NITextBox);
            this.Name = "ConfigurationForm";
            this.Text = "HARMONY SEARCH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NITextBox;
        private System.Windows.Forms.TextBox ClassicHMCR;
        private System.Windows.Forms.TextBox ClassicPAR;
        private System.Windows.Forms.TextBox ClassicBW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton MaxRadioBtn;
        private System.Windows.Forms.RadioButton MinRadioBtn;
        private System.Windows.Forms.TextBox classicHMS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalNotesTextBox;
        private System.Windows.Forms.TextBox MaxValueTextBox;
        private System.Windows.Forms.TextBox MinValueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EditCHSButton;
        private System.Windows.Forms.Button ResetCHSButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button EditIHSButton;
        private System.Windows.Forms.Button EditGBHSButton;
        private System.Windows.Forms.Button EditSAHSButton;
        private System.Windows.Forms.Button ResetGBHSButton;
        private System.Windows.Forms.Button ResetSAHSButton;
        private System.Windows.Forms.Button ResetIHSButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox ImprovedHMCR;
        private System.Windows.Forms.TextBox ImprovedPARmin;
        private System.Windows.Forms.TextBox ImprovedPARmax;
        private System.Windows.Forms.TextBox ImprovedBWmax;
        private System.Windows.Forms.TextBox ImprovedBWmin;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox globalHMS;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox globalPAR;
        private System.Windows.Forms.TextBox globalHMCR;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox adaptiveHMS;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox adaptivePAR;
        private System.Windows.Forms.TextBox adaptiveHMCR;
        private System.Windows.Forms.TextBox ImprovedHMS;
    }
}

