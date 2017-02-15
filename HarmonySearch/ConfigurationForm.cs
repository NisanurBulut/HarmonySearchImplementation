using NCalc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

        private int totalNotesControls = 2;

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
            graphs.ShowAll = showAllCheckBox.Checked;
            graphs.Show();

            this.Hide();
        }

        private void setHarmonySearch()
        {
            if (isInputOk())
            {
                if(ClassicRadioButton.Checked == true)
                {
                    classicHS = ClassicSearch.Instance;
                    classicHS.Objective = new Expression(ObjectiveTextBox.Text);
                    classicHS.Maximize = MaxRadioBtn.Checked;
                    classicHS.NI = Convert.ToInt32(NITextBox.Text);
                    classicHS.TotalNotes = countDecisionVariables();
                    classicHS.MinimumValues = new double[classicHS.TotalNotes];
                    classicHS.MaximumValues = new double[classicHS.TotalNotes];
                    for(int i = 0; i < classicHS.TotalNotes; i++)
                    {
                        TextBox minTextBox = (TextBox) this.Controls.Find("x" + (i + 1) + "MinTextBox", true)[0];
                        classicHS.MinimumValues[i] = double.Parse(minTextBox.Text, CultureInfo.InvariantCulture);
                        TextBox maxTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MaxTextBox", true)[0];
                        classicHS.MaximumValues[i] = double.Parse(maxTextBox.Text, CultureInfo.InvariantCulture);
                    }
                    classicHS.HMSize = Convert.ToInt32(HMSTextBox.Text);
                    classicHS.HMCR = float.Parse(HMCRTextBox.Text, CultureInfo.InvariantCulture);
                    classicHS.PAR = float.Parse(PARTextBox.Text, CultureInfo.InvariantCulture);
                    classicHS.BW = double.Parse(BWTextBox.Text, CultureInfo.InvariantCulture);
                }
                if (ImprovedRadioButton.Checked == true)
                {
                    improvedHS = ImprovedSearch.Instance;
                    improvedHS.Objective = new Expression(ObjectiveTextBox.Text);
                    improvedHS.Maximize = MaxRadioBtn.Checked;
                    improvedHS.NI = Convert.ToInt32(NITextBox.Text);
                    improvedHS.TotalNotes = countDecisionVariables();
                    improvedHS.MinimumValues = new double[improvedHS.TotalNotes];
                    improvedHS.MaximumValues = new double[improvedHS.TotalNotes];
                    for (int i = 0; i < improvedHS.TotalNotes; i++)
                    {
                        TextBox minTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MinTextBox", true)[0];
                        improvedHS.MinimumValues[i] = double.Parse(minTextBox.Text, CultureInfo.InvariantCulture);
                        TextBox maxTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MaxTextBox", true)[0];
                        improvedHS.MaximumValues[i] = double.Parse(maxTextBox.Text, CultureInfo.InvariantCulture);
                    }
                    improvedHS.HMSize = Convert.ToInt32(HMSTextBox.Text);
                    improvedHS.HMCR = float.Parse(HMCRTextBox.Text, CultureInfo.InvariantCulture);
                    improvedHS.PARmin = float.Parse(PARMinTextBox.Text, CultureInfo.InvariantCulture);
                    improvedHS.PARmax = float.Parse(PARMaxTextBox.Text, CultureInfo.InvariantCulture);
                    improvedHS.BWmin = float.Parse(BWMinTextBox.Text, CultureInfo.InvariantCulture);
                    improvedHS.BWmax = float.Parse(BWMaxTextBox.Text, CultureInfo.InvariantCulture);
                }
                if (GlobalRadioButton.Checked == true)
                {
                    globalHS = GlobalBestSearch.Instance;
                    globalHS.Objective = new Expression(ObjectiveTextBox.Text);
                    globalHS.Maximize = MaxRadioBtn.Checked;
                    globalHS.NI = Convert.ToInt32(NITextBox.Text);
                    globalHS.TotalNotes = countDecisionVariables();
                    globalHS.MinimumValues = new double[globalHS.TotalNotes];
                    globalHS.MaximumValues = new double[globalHS.TotalNotes];
                    for (int i = 0; i < globalHS.TotalNotes; i++)
                    {
                        TextBox minTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MinTextBox", true)[0];
                        globalHS.MinimumValues[i] = double.Parse(minTextBox.Text, CultureInfo.InvariantCulture);
                        TextBox maxTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MaxTextBox", true)[0];
                        globalHS.MaximumValues[i] = double.Parse(maxTextBox.Text, CultureInfo.InvariantCulture);
                    }
                    globalHS.HMSize = Convert.ToInt32(HMSTextBox.Text);
                    globalHS.HMCR = float.Parse(HMCRTextBox.Text, CultureInfo.InvariantCulture);
                    globalHS.PAR = float.Parse(PARTextBox.Text, CultureInfo.InvariantCulture);
                }
                if (AdaptiveRadioButton.Checked == true)
                {
                    adaptiveHS = SelfAdaptiveSearch.Instance;
                    adaptiveHS.Objective = new Expression(ObjectiveTextBox.Text);
                    adaptiveHS.Maximize = MaxRadioBtn.Checked;
                    adaptiveHS.NI = Convert.ToInt32(NITextBox.Text);
                    adaptiveHS.TotalNotes = countDecisionVariables();
                    adaptiveHS.MinimumValues = new double[adaptiveHS.TotalNotes];
                    adaptiveHS.MaximumValues = new double[adaptiveHS.TotalNotes];
                    for (int i = 0; i < adaptiveHS.TotalNotes; i++)
                    {
                        TextBox minTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MinTextBox", true)[0];
                        adaptiveHS.MinimumValues[i] = double.Parse(minTextBox.Text, CultureInfo.InvariantCulture);
                        TextBox maxTextBox = (TextBox)this.Controls.Find("x" + (i + 1) + "MaxTextBox", true)[0];
                        adaptiveHS.MaximumValues[i] = double.Parse(maxTextBox.Text, CultureInfo.InvariantCulture);
                    }
                    adaptiveHS.HMCR = float.Parse(HMCRTextBox.Text, CultureInfo.InvariantCulture);
                    adaptiveHS.PAR = float.Parse(PARTextBox.Text, CultureInfo.InvariantCulture);
                }
            }
        }

        private Boolean isInputOk()
        {
            if (!ConfigurationRules.isNIValid(NITextBox.Text))
                return false;
            if (!ConfigurationRules.isHMSValid(HMSTextBox.Text))
                return false;
            if (!ConfigurationRules.isHMCRValid(HMCRTextBox.Text))
                return false;
            if (!ConfigurationRules.isPARValid(PARTextBox.Text))
                return false;
            if (!ConfigurationRules.arePARExtremesValid(PARMinTextBox.Text, PARMaxTextBox.Text))
                return false;
            if (!ConfigurationRules.isBWValid(BWTextBox.Text))
                return false;
            if (!ConfigurationRules.isBWValid(BWMinTextBox.Text))
                return false;
            if (!ConfigurationRules.isBWValid(BWMaxTextBox.Text))
                return false;
            if (!ConfigurationRules.areExtremeValuesValid(x1MinTextBox.Text, x1MaxTextBox.Text))
                return false;

            return true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton senderRadioButton = sender as RadioButton;
            if(senderRadioButton.Tag.Equals("ClassicHS"))
            {
                PARTextBox.Visible = true;
                PARMinTextBox.Visible = false;
                PARMaxTextBox.Visible = false;
                BWTextBox.Visible = true;
                BWMaxTextBox.Visible = false;
                BWMinTextBox.Visible = false;
                PARLabel.Visible = true;
                PARMinLabel.Visible = false;
                PARMaxLabel.Visible = false;
                BWLabel.Visible = true;
                BWMaxLabel.Visible = false;
                BWMinLabel.Visible = false;
                ParametersLabel.Text = "Parameters of the Classic Harmony Search:";
            }
            if (senderRadioButton.Tag.Equals("ImprovedHS"))
            {
                PARTextBox.Visible = false;
                PARMinTextBox.Visible = true;
                PARMaxTextBox.Visible = true;
                BWTextBox.Visible = false;
                BWMaxTextBox.Visible = true;
                BWMinTextBox.Visible = true;
                PARLabel.Visible = false;
                PARMinLabel.Visible = true;
                PARMaxLabel.Visible = true;
                BWLabel.Visible = false;
                BWMaxLabel.Visible = true;
                BWMinLabel.Visible = true;
                ParametersLabel.Text = "Parameters of the Improved Harmony Search:";
            }
            if (senderRadioButton.Tag.Equals("GlobalBestHS"))
            {
                PARTextBox.Visible = true;
                PARMinTextBox.Visible = false;
                PARMaxTextBox.Visible = false;
                BWTextBox.Visible = false;
                BWMaxTextBox.Visible = false;
                BWMinTextBox.Visible = false;
                PARLabel.Visible = true;
                PARMinLabel.Visible = false;
                PARMaxLabel.Visible = false;
                BWLabel.Visible = false;
                BWMaxLabel.Visible = false;
                BWMinLabel.Visible = false;
                ParametersLabel.Text = "Parameters of the Global Best Harmony Search:";
            }
            if (senderRadioButton.Tag.Equals("SelfAdaptiveHS"))
            {
                PARTextBox.Visible = true;
                PARMinTextBox.Visible = false;
                PARMaxTextBox.Visible = false;
                BWTextBox.Visible = false;
                BWMaxTextBox.Visible = false;
                BWMinTextBox.Visible = false;
                PARLabel.Visible = true;
                PARMinLabel.Visible = false;
                PARMaxLabel.Visible = false;
                BWLabel.Visible = false;
                BWMaxLabel.Visible = false;
                BWMinLabel.Visible = false;
                ParametersLabel.Text = "Parameters of the Self Adaptive Harmony Search:";
            }
        }

        private int countDecisionVariables()
        {
            int counter = 1;
            while(true)
            {
                if (ObjectiveTextBox.Text.Contains("x" + counter))
                    counter++;
                else
                    return --counter;
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            int totalNotes = countDecisionVariables();
            if(totalNotes > totalNotesControls)
            {
                createNewTextbox(totalNotes);
            }
            else if(totalNotes < totalNotesControls)
            {
                deleteTextbox(totalNotes);
            }
            totalNotesControls = totalNotes;
        }

        private void createNewTextbox(int totalNotes)
        {
            for(int i = totalNotesControls + 1; i <= totalNotes; i++)
            {
                TextBox minTextBox = new TextBox();
                minTextBox.Name = "x" + i + "MinTextBox";
                TextBox maxTextBox = new TextBox();
                maxTextBox.Name = "x" + i + "MaxTextBox";
                Label label = new Label();
                label.Name = "x" + i + "Label";

                ControlStyle.TextBoxStyle(minTextBox, i);
                ControlStyle.TextBoxStyle(maxTextBox, i);
                ControlStyle.ConfigurationLabelStyle(label, i);
                variablesTab.Controls.Add(minTextBox);
                variablesTab.Controls.Add(maxTextBox);
                variablesTab.Controls.Add(label);
            }
        }

        private void deleteTextbox(int totalNotes)
        {
            for(int i = totalNotesControls; i > totalNotes; i--)
            {
                variablesTab.Controls.RemoveByKey("x" + i + "MinTextBox");
                variablesTab.Controls.RemoveByKey("x" + i + "MaxTextBox");
                variablesTab.Controls.RemoveByKey("x" + i + "Label");
            }
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel1.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "http://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            linkLabel1.LinkVisited = true;
        }
    }
}
