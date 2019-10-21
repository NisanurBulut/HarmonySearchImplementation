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
using Harmony_Search_Implements.Helpers;
using Harmony_Search_Implements.Screens;
using Harmony_Search_Implements.SearchingProcess;
using Harmony_Search_Implements.Styling;
using NCalc;

namespace Harmony_Search_Implements
{
    public partial class ConfigForm : Form
    {
        private Expression objective;
        private ClassicSearch classicHS;
        private HarmonySearchVariant currentVariant;
        private int totalNotesControls = 2;
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

            HarmonyOptimalForm graphs = new HarmonyOptimalForm();
            graphs.classicHS = classicHS;
            graphs.improvedHS = improvedHS;
            graphs.globalHS = globalHS;
            graphs.adaptiveHS = adaptiveHS;
            graphs.ShowAll = showAllCheckBox.Checked;
            graphs.activationFlag = true;
            graphs.Configuration = this;

            this.Hide();
            graphs.Show();
        }
        private Boolean isInputOk()
        {
            if (ObjectiveRichTextBox.Text.Equals("") || ObjectiveRichTextBox.Text == null)
            {
                ControlStyle.MessageBoxStyle("The objective function is null or empty.");
                return false;
            }
            objective = new Expression(ObjectiveRichTextBox.Text);
            if (objective.HasErrors())
            {
                ControlStyle.MessageBoxStyle("Amaç fonksiyonu doğrulanabilir değildir. \n\n" + objective.Error);
                return false;
            }
            if (objective == null)
            {
                ControlStyle.MessageBoxStyle("Amaç fonksiyonu doğrulanabilir değildir. Lütfen tekrar deneyiniz.");
                return false;
            }
            if (totalNotesControls < 2)
            {
                ControlStyle.MessageBoxStyle("Algoritma çalışmak için en az iki değişkene ihtiyaç duyar.");
                return false;
            }
            try
            {
                for (int k = 1; k <= totalNotesControls; k++)
                {
                    objective.Parameters["x" + k] = 5;
                }
                object res = objective.Evaluate();
            }
            catch (Exception e)
            {
                ControlStyle.MessageBoxStyle("Amaç fonksiyonu doğrulanabilir değildir. Lütfen tekrar deneyiniz.");
                return false;
            }

            for (int i = 0; i < totalNotesControls; i++)
            {
                TextBox minTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MinTextBox", true)[0];
                TextBox maxTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MaxTextBox", true)[0];
                if (!ConfigurationRules.areExtremeValuesValid(minTextBox.Text, maxTextBox.Text))
                {
                    ControlStyle.MessageBoxStyle("Karar değişkenlerinin " + "X" + (i + 1) + " değerleri tanımsızdır.");
                    return false;
                }
            }
            if (!ConfigurationRules.isNIValid(NITextBox.Text))
            {
                ControlStyle.MessageBoxStyle("İterasyon sayısı tanımsız değerdir. Lütfen tekrar deneyiniz.");

                return false;
            }
            if (!ConfigurationRules.isHMSValid(HMSTextBox.Text))
            {
                ControlStyle.MessageBoxStyle("HMS(Harmony Memory Size) Harmoni hafıza boyutu tanımsızdır. Lütfen tekrar deneyiniz.");

                return false;
            }
            if (!ConfigurationRules.isHMCRValid(HMCRTextBox.Text))
            {
                ControlStyle.MessageBoxStyle("HMCR(Harmony Memory Consideration Rate) Harmoni dikkate alma oranı tanımsızdır. Lütfen tekrar deneyiniz.");
                return false;
            }


            if (!ConfigurationRules.arePARExtremesValid(PARMinTextBox.Text, PARMaxTextBox.Text))
            {
                ControlStyle.MessageBoxStyle("PAR(Pitch Adjustment Rate) ton ayarlama değeri tanımsızdır.");

                return false;
            }
            if (!ConfigurationRules.areΒWExtremesValid(BWMinTextBox.Text, BWMaxTextBox.Text))
            {
                ControlStyle.MessageBoxStyle("BW(Bandwidth) Bant genişliği tanımlı değildir.");

                return false;
            }
            return true;
        }

        private void setHarmonySearch()
        {
            if (currentVariant == HarmonySearchVariant.Classic)
            {
                classicHS = ClassicSearch.Instance;
                classicHS.Objective = objective;//Amaç fonksıyonunu alır
                if (MaxRadioBtn.Checked)
                    classicHS.Optimum = OptimizationGoal.Max;
                if (MinRadioBtn.Checked)
                    classicHS.Optimum = OptimizationGoal.Min;//amaç fonksıyonu minimuma indirgenmeye çalışılır
                if (MinAbsRadioBtn.Checked)
                    classicHS.Optimum = OptimizationGoal.MinAbs;
                classicHS.NI = Convert.ToInt32(NITextBox.Text);//İterasyon sayısı
                classicHS.TotalNotes = countDecisionVariables();//Nota tür sayısı
                classicHS.MinimumValues = new double[classicHS.TotalNotes];
                classicHS.MaximumValues = new double[classicHS.TotalNotes];
                for (int i = 0; i < classicHS.TotalNotes; i++)
                {
                    TextBox minTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MinTextBox", true)[0];
                    classicHS.MinimumValues[i] = double.Parse(minTextBox.Text, CultureInfo.InvariantCulture);
                    TextBox maxTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MaxTextBox", true)[0];
                    classicHS.MaximumValues[i] = double.Parse(maxTextBox.Text, CultureInfo.InvariantCulture);
                }

                classicHS.HMSize = Convert.ToInt32(HMSTextBox.Text);
                classicHS.HMCR = float.Parse(HMCRTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.PAR = float.Parse(PARTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.BW = double.Parse(BWTextBox.Text, CultureInfo.InvariantCulture);
            }
        }
        private int countDecisionVariables()
        {
            int counter = 1;
            while (true)
            {
                if (ObjectiveRichTextBox.Text.Contains("x" + counter))
                    counter++;
                else
                    return --counter;
            }
        }
    }
}
