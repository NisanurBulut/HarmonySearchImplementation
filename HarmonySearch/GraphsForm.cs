using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public partial class GraphsForm : Form
    {
        public bool ShowAll { get; set; }
        private int counter = 0;

        public ClassicSearch classicHS { get; set; }
        public ImprovedSearch improvedHS { get; set; }
        public GlobalBestSearch globalHS { get; set; }
        public SelfAdaptiveSearch adaptiveHS { get; set; }

        private List<double> results = new List<double>();

        public GraphsForm()
        {
            InitializeComponent();
        }

        private void GraphsForm_Activated(object sender, EventArgs e)
        {
            if (counter != 0)
                return;
            SearchProgress.Show();
            this.Enabled = false;
            performHarmonySearch();
            plotChart();
            SearchProgress.Hide();
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchProgress.Show();
            this.Enabled = false;
            performHarmonySearch();
            plotChart();
            SearchProgress.Hide();
            this.Enabled = true;
        }

        private void plotChart()
        {
            BestHarmonyChart.Series.Clear();
            X1Chart.Series.Clear();
            X2Chart.Series.Clear();

            if (classicHS != null)
            {
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                X1Chart.Series.Add("X1 Decision Variable");
                X1Chart.Series[0].ChartType = SeriesChartType.Line;
                X1Chart.Series[0].Color = System.Drawing.Color.Blue;
                X2Chart.Series.Add("X2 Decision Variable");
                X2Chart.Series[0].ChartType = SeriesChartType.Line;
                X2Chart.Series[0].Color = System.Drawing.Color.Blue;
                for (int j = 0; j < classicHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, classicHS.bestHarmonies[j]);
                    X1Chart.Series[0].Points.AddXY(j, classicHS.bestHarmoniesNotes[j, 0]);
                    X2Chart.Series[0].Points.AddXY(j, classicHS.bestHarmoniesNotes[j, 1]);
                }
                saveResults(classicHS.bestHarmonies[classicHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            if (improvedHS != null)
            {
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                X1Chart.Series.Add("X1 Decision Variable");
                X1Chart.Series[0].ChartType = SeriesChartType.Line;
                X1Chart.Series[0].Color = System.Drawing.Color.Blue;
                X2Chart.Series.Add("X2 Decision Variable");
                X2Chart.Series[0].ChartType = SeriesChartType.Line;
                X2Chart.Series[0].Color = System.Drawing.Color.Blue;
                for (int j = 0; j < improvedHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, improvedHS.bestHarmonies[j]);
                    X1Chart.Series[0].Points.AddXY(j, improvedHS.bestHarmoniesNotes[j, 0]);
                    X2Chart.Series[0].Points.AddXY(j, improvedHS.bestHarmoniesNotes[j, 1]);
                }
                saveResults(improvedHS.bestHarmonies[improvedHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            if (globalHS != null)
            {
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                X1Chart.Series.Add("X1 Decision Variable");
                X1Chart.Series[0].ChartType = SeriesChartType.Line;
                X1Chart.Series[0].Color = System.Drawing.Color.Blue;
                X2Chart.Series.Add("X2 Decision Variable");
                X2Chart.Series[0].ChartType = SeriesChartType.Line;
                X2Chart.Series[0].Color = System.Drawing.Color.Blue;
                for (int j = 0; j < globalHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, globalHS.bestHarmonies[j]);
                    X1Chart.Series[0].Points.AddXY(j, globalHS.bestHarmoniesNotes[j, 0]);
                    X2Chart.Series[0].Points.AddXY(j, globalHS.bestHarmoniesNotes[j, 1]);
                }
                saveResults(globalHS.bestHarmonies[globalHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            if (adaptiveHS != null)
            {
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                X1Chart.Series.Add("X1 Decision Variable");
                X1Chart.Series[0].ChartType = SeriesChartType.Line;
                X1Chart.Series[0].Color = System.Drawing.Color.Blue;
                X2Chart.Series.Add("X2 Decision Variable");
                X2Chart.Series[0].ChartType = SeriesChartType.Line;
                X2Chart.Series[0].Color = System.Drawing.Color.Blue;
                for (int j = 0; j < adaptiveHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, adaptiveHS.bestHarmonies[j]);
                    X1Chart.Series[0].Points.AddXY(j, adaptiveHS.bestHarmoniesNotes[j, 0]);
                    X2Chart.Series[0].Points.AddXY(j, adaptiveHS.bestHarmoniesNotes[j, 1]);
                }
                saveResults(adaptiveHS.bestHarmonies[adaptiveHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            BestHarmonyChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            BestHarmonyChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            BestHarmonyChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            BestHarmonyChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
        }

        private void saveResults(double bestHarmony)
        {
            richTextBox1.Text += counter;
            richTextBox1.Text += "\t";
            richTextBox1.Text += bestHarmony;
            richTextBox1.Text += "\n";
            results.Add(bestHarmony);
            counter++;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            configurationForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n\n\n AVERAGE: ";
            double sum = 0;
            for (int i = 0; i < results.Count; i++)
            {
                sum += results[i];
            }
            double avg = sum / results.Count;
            richTextBox1.Text += avg;
        }

        private void performHarmonySearch()
        {
            if (classicHS != null)
            {
                classicHS.ShowAll = ShowAll;
                classicHS.initializeMemory();
                SearchProgress.Minimum = 0;
                SearchProgress.Maximum = classicHS.NI;
                classicHS.Run(SearchProgress);
            }
            if (improvedHS != null)
            {
                improvedHS.ShowAll = ShowAll;
                improvedHS.initializeMemory();
                SearchProgress.Minimum = 0;
                SearchProgress.Maximum = improvedHS.NI;
                improvedHS.Run(SearchProgress);
            }
            if (globalHS != null)
            {
                globalHS.ShowAll = ShowAll;
                globalHS.initializeMemory();
                SearchProgress.Minimum = 0;
                SearchProgress.Maximum = globalHS.NI;
                globalHS.Run(SearchProgress);
            }
            if (adaptiveHS != null)
            {
                adaptiveHS.ShowAll = ShowAll;
                adaptiveHS.initializeMemory();
                SearchProgress.Minimum = 0;
                SearchProgress.Maximum = adaptiveHS.NI;
                adaptiveHS.Run(SearchProgress);
            }
        }

        private void performSearch(Search sender, string tag)
        {

        }

    }
}
