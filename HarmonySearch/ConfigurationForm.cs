using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public partial class ConfigurationForm : Form
    {
        ClassicSearch classicHS;
        ImprovedSearch improvedHS;
        GlobalBestSearch globalHS;
        SelfAdaptiveSearch adaptiveHS;

        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            setHarmonySearch();
            
            GraphsForm graphs = new GraphsForm();
            graphs.classicHS = classicHS;
            graphs.improvedHS = improvedHS;
            graphs.globalHS = globalHS;
            graphs.adaptiveHS = adaptiveHS;
            graphs.Show();

            this.Hide();
        }

        private void setHarmonySearch()
        {
            if (isInputOk())
            {
                classicHS = new ClassicSearch();
                improvedHS = new ImprovedSearch();
                globalHS = new GlobalBestSearch();
                adaptiveHS = new SelfAdaptiveSearch();
                classicHS.NI = Convert.ToInt32(NITextBox.Text);
                classicHS.TotalNotes = Convert.ToInt32(TotalNotesTextBox.Text);
                classicHS.MaximumValue = double.Parse(MaxValueTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.MinimumValue = double.Parse(MinValueTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.HMSize = Convert.ToInt32(classicHMS.Text);
                classicHS.HMCR = float.Parse(ClassicHMCR.Text, CultureInfo.InvariantCulture);
                classicHS.PAR = float.Parse(ClassicPAR.Text, CultureInfo.InvariantCulture);
                classicHS.BW = double.Parse(ClassicBW.Text, CultureInfo.InvariantCulture);
                improvedHS.NI = Convert.ToInt32(NITextBox.Text);
                improvedHS.TotalNotes = Convert.ToInt32(TotalNotesTextBox.Text);
                improvedHS.MaximumValue = double.Parse(MaxValueTextBox.Text, CultureInfo.InvariantCulture);
                improvedHS.MinimumValue = double.Parse(MinValueTextBox.Text, CultureInfo.InvariantCulture);
                improvedHS.HMSize = Convert.ToInt32(classicHMS.Text);
                improvedHS.HMCR = float.Parse(ImprovedHMCR.Text, CultureInfo.InvariantCulture);
                improvedHS.PARmin = float.Parse(ImprovedPARmin.Text, CultureInfo.InvariantCulture);
                improvedHS.PARmax = float.Parse(ImprovedPARmax.Text, CultureInfo.InvariantCulture);
                improvedHS.BWmin = float.Parse(ImprovedBWmin.Text, CultureInfo.InvariantCulture);
                improvedHS.BWmax = float.Parse(ImprovedBWmax.Text, CultureInfo.InvariantCulture);
                globalHS.NI = Convert.ToInt32(NITextBox.Text);
                globalHS.TotalNotes = Convert.ToInt32(TotalNotesTextBox.Text);
                globalHS.MaximumValue = double.Parse(MaxValueTextBox.Text, CultureInfo.InvariantCulture);
                globalHS.MinimumValue = double.Parse(MinValueTextBox.Text, CultureInfo.InvariantCulture);
                globalHS.HMSize = Convert.ToInt32(globalHMS.Text);
                globalHS.HMCR = float.Parse(globalHMCR.Text, CultureInfo.InvariantCulture);
                globalHS.PAR = float.Parse(globalPAR.Text, CultureInfo.InvariantCulture);
                adaptiveHS.NI = Convert.ToInt32(NITextBox.Text);
                adaptiveHS.TotalNotes = Convert.ToInt32(TotalNotesTextBox.Text);
                adaptiveHS.HMSize = Convert.ToInt32(classicHMS.Text);
                adaptiveHS.MaximumValue = double.Parse(MaxValueTextBox.Text, CultureInfo.InvariantCulture);
                adaptiveHS.MinimumValue = double.Parse(MinValueTextBox.Text, CultureInfo.InvariantCulture);
                adaptiveHS.HMCR = float.Parse(adaptiveHMCR.Text, CultureInfo.InvariantCulture);
                adaptiveHS.PAR = float.Parse(adaptivePAR.Text, CultureInfo.InvariantCulture);
            }
        }

        private Boolean isInputOk()
        {
            if (!ConfigurationRules.isNIValid(NITextBox.Text))
                return false;
            if (!ConfigurationRules.areTotalVariablesValid(TotalNotesTextBox.Text))
                return false;
            if (!ConfigurationRules.isHMSValid(classicHMS.Text))
                return false;
            if (!ConfigurationRules.isHMSValid(ImprovedHMS.Text))
                return false;
            if (!ConfigurationRules.isHMSValid(globalHMS.Text))
                return false;
            if (!ConfigurationRules.isHMSValid(adaptiveHMS.Text))
                return false;
            if (!ConfigurationRules.isHMCRValid(ClassicHMCR.Text))
                return false;
            if (!ConfigurationRules.isHMCRValid(ImprovedHMCR.Text))
                return false;
            if (!ConfigurationRules.isHMCRValid(globalHMCR.Text))
                return false;
            if (!ConfigurationRules.isHMCRValid(adaptiveHMCR.Text))
                return false;
            if (!ConfigurationRules.isPARValid(ClassicPAR.Text))
                return false;
            if (!ConfigurationRules.arePARExtremesValid(ImprovedPARmin.Text, ImprovedPARmax.Text))
                return false;
            if (!ConfigurationRules.isPARValid(globalPAR.Text))
                return false;
            if (!ConfigurationRules.isPARValid(adaptivePAR.Text))
                return false;
            if (!ConfigurationRules.isBWValid(ClassicBW.Text))
                return false;
            if (!ConfigurationRules.isBWValid(ImprovedBWmin.Text))
                return false;
            if (!ConfigurationRules.isBWValid(ImprovedBWmax.Text))
                return false;
            if (!ConfigurationRules.areExtremeValuesValid(MinValueTextBox.Text, MaxValueTextBox.Text))
                return false;

            return true;
        }

        private void EditCHSButton_Click(object sender, EventArgs e)
        {
            NITextBox.Enabled = true;
            ClassicHMCR.Enabled = true;
            ClassicPAR.Enabled = true;
            ClassicBW.Enabled = true;
            classicHMS.Enabled = true;
            TotalNotesTextBox.Enabled = true;
            MaxValueTextBox.Enabled = true;
            MinValueTextBox.Enabled = true;
            MaxRadioBtn.Enabled = true;
            MinRadioBtn.Enabled = true;
            EditCHSButton.Enabled = false;
        }

        private void EditIHSButton_Click(object sender, EventArgs e)
        {
            ImprovedHMCR.Enabled = true;
            ImprovedPARmin.Enabled = true;
            ImprovedPARmax.Enabled = true;
            ImprovedBWmin.Enabled = true;
            ImprovedBWmax.Enabled = true;
            ImprovedHMS.Enabled = true;
            EditIHSButton.Enabled = false;
        }

        private void EditGBHSButton_Click(object sender, EventArgs e)
        {
            globalHMCR.Enabled = true;
            globalPAR.Enabled = true;
            globalPAR.Enabled = true;
            globalHMS.Enabled = true;
            EditGBHSButton.Enabled = false;
        }

        private void EditSAHSButton_Click(object sender, EventArgs e)
        {
            adaptiveHMCR.Enabled = true;
            adaptivePAR.Enabled = true;
            adaptiveHMS.Enabled = true;
            EditSAHSButton.Enabled = false;
        }

        private void ResetCHSButton_Click(object sender, EventArgs e)
        {
            NITextBox.Text = "250";
            ClassicHMCR.Text = "0.85";
            ClassicPAR.Text = "0.15";
            ClassicBW.Text = "2.048";
            classicHMS.Text = "30";
            TotalNotesTextBox.Text = "2";
            MaxValueTextBox.Text = "2.048";
            MinValueTextBox.Text = "-2.048";
            EditCHSButton.Enabled = true;
            ResetCHSButton.Enabled = false;
            NITextBox.Enabled = false;
            ClassicHMCR.Enabled = false;
            ClassicPAR.Enabled = false;
            ClassicBW.Enabled = false;
            classicHMS.Enabled = false;
            TotalNotesTextBox.Enabled = false;
            MaxValueTextBox.Enabled = false;
            MinValueTextBox.Enabled = false;
            MaxRadioBtn.Enabled = false;
            MinRadioBtn.Enabled = false;
        }

        private void ResetIHSButton_Click(object sender, EventArgs e)
        {
            ImprovedHMCR.Text = "0.90";
            ImprovedPARmin.Text = "0.1";
            ImprovedPARmax.Text = "0.85";
            ImprovedBWmin.Text = "0.001";
            ImprovedBWmax.Text = "0.8";
            ImprovedHMS.Text = "30";
            EditIHSButton.Enabled = true;
            ResetIHSButton.Enabled = false;
            ImprovedHMCR.Enabled = false;
            ImprovedPARmin.Enabled = false;
            ImprovedPARmax.Enabled = false;
            ImprovedBWmin.Enabled = false;
            ImprovedBWmax.Enabled = false;
            ImprovedHMS.Enabled = false;
        }

        private void ResetGBHSButton_Click(object sender, EventArgs e)
        {
            globalHMCR.Text = "0.85";
            globalPAR.Text = "0.15";
            globalHMS.Text = "30";
            EditGBHSButton.Enabled = true;
            ResetGBHSButton.Enabled = false;
            globalHMCR.Enabled = false;
            globalPAR.Enabled = false;
            globalHMS.Enabled = false;
        }

        private void ResetSAHSButton_Click(object sender, EventArgs e)
        {
            adaptiveHMCR.Text = "0.85";
            adaptivePAR.Text = "0.15";
            adaptiveHMS.Text = "30";
            EditSAHSButton.Enabled = true;
            ResetSAHSButton.Enabled = false;
            adaptiveHMCR.Enabled = false;
            adaptivePAR.Enabled = false;
            adaptiveHMS.Enabled = false;
        }

        private void TextBox_TextChanged(Object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if(textBox.Tag.Equals("ClassicHS"))
                ResetCHSButton.Enabled = true;
            if (textBox.Tag.Equals("ImprovedHS"))
                ResetIHSButton.Enabled = true;
            if (textBox.Tag.Equals("GlobalBestHS"))
                ResetGBHSButton.Enabled = true;
            if (textBox.Tag.Equals("SelfAdaptiveHS"))
                ResetSAHSButton.Enabled = true;
        }

    }
}
