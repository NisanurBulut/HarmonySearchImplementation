using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public partial class HarmonyForm : Form
    {
        ClassicSearch classicHS;
        ImprovedSearch improvedHS;

        public HarmonyForm()
        {
            InitializeComponent();
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            setHarmonySearch();
            classicHS.initializeMemory();
            classicHS.Run();
            improvedHS.initializeMemory();
            improvedHS.Run();
            plotChart();
        }

        private void plotChart()
        {
            chart.Series.Clear();

            chart.Series.Add("Classic Harmony Search");
            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].Color = System.Drawing.Color.Red;
            chart.Series.Add("Improved Harmony Search");
            chart.Series[1].ChartType = SeriesChartType.Line;
            chart.Series[1].Color = System.Drawing.Color.Blue;

            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            for (int i = 0; i < classicHS.NI; i++)
            {
                chart.Series[0].Points.AddXY(i, classicHS.bestHarmonies[i]);
                chart.Series[1].Points.AddXY(i, improvedHS.bestHarmonies[i]);
            }
        }

        private void setHarmonySearch()
        {
            if (isInputOk())
            {
                classicHS = new ClassicSearch();
                improvedHS = new ImprovedSearch();

                classicHS.NI = Convert.ToInt32(NITextBox.Text);
                classicHS.HMCR = double.Parse(HMCRTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.PAR = double.Parse(PARTextBox.Text, CultureInfo.InvariantCulture);
                //TODO: Some more parameters
                classicHS.HMSize = Convert.ToInt32(HMSTextBox.Text);
                classicHS.TotalNotes = Convert.ToInt32(TotalNotesTextBox.Text);
                classicHS.MaximumNote = double.Parse(MaxValueTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.MinimumNote = double.Parse(MinValueTextBox.Text, CultureInfo.InvariantCulture);
                classicHS.BW = 2.048;
                improvedHS.NI = Convert.ToInt32(NITextBox.Text);
                improvedHS.HMCR = 0.95f;
                improvedHS.PARmin = 0.1f;
                improvedHS.PARmax = 0.85f;
                improvedHS.BWmin = 0.001;
                improvedHS.BWmax = 0.8;
                //TODO: 
                improvedHS.HMSize = Convert.ToInt32(HMSTextBox.Text);
                improvedHS.TotalNotes = Convert.ToInt32(TotalNotesTextBox.Text);
                improvedHS.MaximumNote = double.Parse(MaxValueTextBox.Text, CultureInfo.InvariantCulture);
                improvedHS.MinimumNote = double.Parse(MinValueTextBox.Text, CultureInfo.InvariantCulture);
            }
        }

        private Boolean isInputOk()
        {
            if(NITextBox.Text == null || NITextBox.Text == "")
                return false;

            int NI = 0;
            if(!Int32.TryParse(NITextBox.Text, out NI))
                return false;

            if (HMSTextBox.Text == null || HMSTextBox.Text == "")
                return false;

            int HMS = 0;
            if (!Int32.TryParse(HMSTextBox.Text, out HMS))
                return false;

            if (TotalNotesTextBox.Text == null || TotalNotesTextBox.Text == "")
                return false;

            int TotalNotes = 0;
            if (!Int32.TryParse(TotalNotesTextBox.Text, out TotalNotes))
                return false;

            if (HMCRTextBox.Text == null || HMCRTextBox.Text == "")
                return false;

            float HMCR = 0;
            if (!float.TryParse(HMCRTextBox.Text, out HMCR))
                return false;

            if (PARTextBox.Text == null || PARTextBox.Text == "")
                return false;

            float PAR = 0;
            if (!float.TryParse(PARTextBox.Text, out PAR))
                return false;

            if (MaxValueTextBox.Text == null || MaxValueTextBox.Text == "")
                return false;

            double MaxValue = 0;
            if (!double.TryParse(MaxValueTextBox.Text, out MaxValue))
                return false;

            if (MinValueTextBox.Text == null || MinValueTextBox.Text == "")
                return false;

            double MinValue = 0;
            if (!double.TryParse(MinValueTextBox.Text, out MinValue))
                return false;

            return true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            NITextBox.Enabled = true;
            HMCRTextBox.Enabled = true;
            PARTextBox.Enabled = true;
            BwTextBox.Enabled = true;
            ECRTextBox.Enabled = true;
            HMSTextBox.Enabled = true;
            TotalNotesTextBox.Enabled = true;
            MaxValueTextBox.Enabled = true;
            MinValueTextBox.Enabled = true;
            MaxRadioBtn.Enabled = true;
            MinRadioBtn.Enabled = true;
            EditButton.Enabled = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            NITextBox.Text = "250";
            HMCRTextBox.Text = "0.85";
            PARTextBox.Text = "0.15";
            BwTextBox.Text = "";
            ECRTextBox.Text = "";
            HMSTextBox.Text = "30";
            TotalNotesTextBox.Text = "2";
            MaxValueTextBox.Text = "2.048";
            MinValueTextBox.Text = "-2.048";
            BwTextBox.Text = "2.048";
            EditButton.Enabled = true;
            ResetButton.Enabled = false;
            NITextBox.Enabled = false;
            HMCRTextBox.Enabled = false;
            PARTextBox.Enabled = false;
            BwTextBox.Enabled = false;
            ECRTextBox.Enabled = false;
            HMSTextBox.Enabled = false;
            TotalNotesTextBox.Enabled = false;
            MaxValueTextBox.Enabled = false;
            MinValueTextBox.Enabled = false;
            MaxRadioBtn.Enabled = false;
            MinRadioBtn.Enabled = false;
        }

        private void TextBox_TextChanged(Object sender, EventArgs e)
        {
            ResetButton.Enabled = true;
        }
    }
}
