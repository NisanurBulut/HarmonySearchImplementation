using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harmony_Search_Implements.Enums;
using Harmony_Search_Implements.SearchingProcess;
using NCalc;

namespace Harmony_Search_Implements
{
    public partial class ConfigForm : Form
    {
        private Expression objective;
        private ClassicSearch classicHS;
        private HarmonySearchVariant currentVariant;
        public ConfigForm()
        {
            InitializeComponent();
            InitializeComponent();
            ObjectiveRichTextBox.SelectAll();
            ObjectiveRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            ObjectiveRichTextBox.DeselectAll();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (isInputOk())
                setHarmonySearch();
            else
                return;
        }
        private Boolean isInputOk()
        {
            objective = new Expression(ObjectiveRichTextBox.Text);
            return true;
        }

        private void setHarmonySearch()
        {
            if (currentVariant == HarmonySearchVariant.Classic)
            {
                classicHS = ClassicSearch.Instance;
                classicHS.Objective = objective;
                if (MaxRadioBtn.Checked)
                    classicHS.Optimum = OptimizationGoal.Max;
                if (MinRadioBtn.Checked)
                    classicHS.Optimum = OptimizationGoal.Min;
                if (MinAbsRadioBtn.Checked)
                    classicHS.Optimum = OptimizationGoal.MinAbs;
                classicHS.NI = Convert.ToInt32(NITextBox.Text);
                classicHS.TotalNotes = countDecisionVariables();
                classicHS.MinimumValues = new double[classicHS.TotalNotes];
                classicHS.MaximumValues = new double[classicHS.TotalNotes];
                for (int i = 0; i < classicHS.TotalNotes; i++)
                {
                    TextBox minTextBox = (TextBox) this.Controls.Find("x" + (i + 1) + "MinTextBox", true)[0];
                    classicHS.MinimumValues[i] = double.Parse(minTextBox.Text, CultureInfo.InvariantCulture);
                    TextBox maxTextBox = (TextBox) this.Controls.Find("x" + (i + 1) + "MaxTextBox", true)[0];
                    classicHS.MaximumValues[i] = double.Parse(maxTextBox.Text, CultureInfo.InvariantCulture);
                }

                classicHS.HMSize = Convert.ToInt32(HMSTextBox.Text);
                classicHS.HMCR = float.Parse(HMCRTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.PAR = float.Parse(PARTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.BW = double.Parse(BWTextBox.Text, CultureInfo.InvariantCulture);
            }
        }
    }
}
