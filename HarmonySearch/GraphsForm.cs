using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public partial class GraphsForm : Form
    {
        public bool ShowAll { get; set; }
        private int totalNotes;
        private int counter = 0;
        private bool isBackButtonPressed = false;

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
            numericsTab.Controls.RemoveByKey("aestheticsLabel");
            for (int k = 1; k <= totalNotes; k++)
            {
                numericsTab.Controls.RemoveByKey("x" + k + "Label");
                notesTab.Controls.RemoveByKey("x" + k + "Chart" );
            }
            plotChart();
            SearchProgress.Hide();
            this.Enabled = true;
        }

        private void plotChart()
        {
            BestHarmonyChart.Series.Clear();
            NewHarmonyChart.Series.Clear();
            WorstHarmonyChart.Series.Clear();
            //X1Chart.Series.Clear();
            //X2Chart.Series.Clear();

            if (classicHS != null)
            {
                totalNotes = classicHS.TotalNotes;
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                NewHarmonyChart.Series.Add("Aesthetics");
                NewHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                NewHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                WorstHarmonyChart.Series.Add("Aesthetics");
                WorstHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                WorstHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                List<Chart> allDecisionVariables = new List<Chart>();
                for (int i = 1; i <= classicHS.TotalNotes; i++)
                {
                    Chart noteChart = new Chart();
                    ControlStyle.ChartStyle(noteChart, i);
                    allDecisionVariables.Add(noteChart);
                    Label noteLabel = new Label();
                    ControlStyle.GraphsLabelStyle(noteLabel, i);
                    notesTab.Controls.Add(noteLabel);
                }
                for (int j = 0; j < classicHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, classicHS.bestHarmoniesAesthetics[j]);
                    NewHarmonyChart.Series[0].Points.AddXY(j, classicHS.newHarmoniesAesthetics[j]);
                    WorstHarmonyChart.Series[0].Points.AddXY(j, classicHS.worstHarmoniesAesthetics[j]);
                    for (int i = 1; i <= classicHS.TotalNotes; i++)
                    {
                        allDecisionVariables[i-1].Series[0].Points.AddXY(j, classicHS.bestHarmoniesNotes[j, i-1]);
                    }
                }
                for(int i = 0; i < classicHS.TotalNotes; i++)
                {
                    notesTab.Controls.Add(allDecisionVariables[i]);
                }
                Label aesthetics = new Label();
                ControlStyle.LabelStyle(aesthetics, classicHS.bestHarmoniesAesthetics[classicHS.NI - 1]);
                numericsTab.Controls.Add(aesthetics);
                for (int k = 1; k <= classicHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, classicHS.bestHarmoniesNotes[classicHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                
                saveResults(classicHS.bestHarmoniesAesthetics[classicHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            if (improvedHS != null)
            {
                totalNotes = improvedHS.TotalNotes;
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                NewHarmonyChart.Series.Add("Aesthetics");
                NewHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                NewHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                WorstHarmonyChart.Series.Add("Aesthetics");
                WorstHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                WorstHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                List<Chart> allDecisionVariables = new List<Chart>();
                for (int i = 1; i <= improvedHS.TotalNotes; i++)
                {
                    Chart noteChart = new Chart();
                    ControlStyle.ChartStyle(noteChart, i);
                    allDecisionVariables.Add(noteChart);
                    Label noteLabel = new Label();
                    ControlStyle.GraphsLabelStyle(noteLabel, i);
                    notesTab.Controls.Add(noteLabel);
                }
                for (int j = 0; j < improvedHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, improvedHS.bestHarmoniesAesthetics[j]);
                    NewHarmonyChart.Series[0].Points.AddXY(j, improvedHS.newHarmoniesAesthetics[j]);
                    WorstHarmonyChart.Series[0].Points.AddXY(j, improvedHS.worstHarmoniesAesthetics[j]);
                    for (int i = 1; i <= improvedHS.TotalNotes; i++)
                    {
                        allDecisionVariables[i - 1].Series[0].Points.AddXY(j, improvedHS.bestHarmoniesNotes[j, i - 1]);
                    }
                }
                for (int i = 0; i < improvedHS.TotalNotes; i++)
                {
                    notesTab.Controls.Add(allDecisionVariables[i]);
                }
                Label aesthetics = new Label();
                ControlStyle.LabelStyle(aesthetics, improvedHS.bestHarmoniesAesthetics[improvedHS.NI - 1]);
                numericsTab.Controls.Add(aesthetics);
                for (int k = 1; k <= improvedHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, improvedHS.bestHarmoniesNotes[improvedHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                saveResults(improvedHS.bestHarmoniesAesthetics[improvedHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            if (globalHS != null)
            {
                totalNotes = globalHS.TotalNotes;
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                NewHarmonyChart.Series.Add("Aesthetics");
                NewHarmonyChart.Series[0].ChartType = SeriesChartType.Pie;
                NewHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                WorstHarmonyChart.Series.Add("Aesthetics");
                WorstHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                WorstHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                List<Chart> allDecisionVariables = new List<Chart>();
                for (int i = 1; i <= globalHS.TotalNotes; i++)
                {
                    Chart noteChart = new Chart();
                    ControlStyle.ChartStyle(noteChart, i);
                    allDecisionVariables.Add(noteChart);
                    Label noteLabel = new Label();
                    ControlStyle.GraphsLabelStyle(noteLabel, i);
                    notesTab.Controls.Add(noteLabel);
                }
                for (int j = 0; j < globalHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, globalHS.bestHarmoniesAesthetics[j]);
                    NewHarmonyChart.Series[0].Points.AddXY(j, globalHS.newHarmoniesAesthetics[j]);
                    WorstHarmonyChart.Series[0].Points.AddXY(j, globalHS.worstHarmoniesAesthetics[j]);
                    for (int i = 1; i <= globalHS.TotalNotes; i++)
                    {
                        allDecisionVariables[i - 1].Series[0].Points.AddXY(j, globalHS.bestHarmoniesNotes[j, i - 1]);
                    }
                }
                for (int i = 0; i < globalHS.TotalNotes; i++)
                {
                    notesTab.Controls.Add(allDecisionVariables[i]);
                }
                Label aesthetics = new Label();
                ControlStyle.LabelStyle(aesthetics, globalHS.bestHarmoniesAesthetics[globalHS.NI - 1]);
                numericsTab.Controls.Add(aesthetics);
                for (int k = 1; k <= globalHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, globalHS.bestHarmoniesNotes[globalHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                saveResults(globalHS.bestHarmoniesAesthetics[globalHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            if (adaptiveHS != null)
            {
                totalNotes = adaptiveHS.TotalNotes;
                BestHarmonyChart.Series.Add("Aesthetics");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                NewHarmonyChart.Series.Add("Aesthetics");
                NewHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                NewHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                WorstHarmonyChart.Series.Add("Aesthetics");
                WorstHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                WorstHarmonyChart.Series[0].Color = System.Drawing.Color.Blue;
                List<Chart> allDecisionVariables = new List<Chart>();
                for (int i = 1; i <= adaptiveHS.TotalNotes; i++)
                {
                    Chart noteChart = new Chart();
                    ControlStyle.ChartStyle(noteChart, i);
                    allDecisionVariables.Add(noteChart);
                    Label noteLabel = new Label();
                    ControlStyle.GraphsLabelStyle(noteLabel, i);
                    notesTab.Controls.Add(noteLabel);
                }
                for (int j = 0; j < adaptiveHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, adaptiveHS.bestHarmoniesAesthetics[j]);
                    NewHarmonyChart.Series[0].Points.AddXY(j, adaptiveHS.newHarmoniesAesthetics[j]);
                    WorstHarmonyChart.Series[0].Points.AddXY(j, adaptiveHS.worstHarmoniesAesthetics[j]);
                    for (int i = 1; i <= adaptiveHS.TotalNotes; i++)
                    {
                        allDecisionVariables[i - 1].Series[0].Points.AddXY(j, adaptiveHS.bestHarmoniesNotes[j, i - 1]);
                    }
                }
                for (int i = 0; i < adaptiveHS.TotalNotes; i++)
                {
                    notesTab.Controls.Add(allDecisionVariables[i]);
                }
                Label aesthetics = new Label();
                ControlStyle.LabelStyle(aesthetics, adaptiveHS.bestHarmoniesAesthetics[adaptiveHS.NI - 1]);
                numericsTab.Controls.Add(aesthetics);
                for (int k = 1; k <= adaptiveHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, adaptiveHS.bestHarmoniesNotes[adaptiveHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                saveResults(adaptiveHS.bestHarmoniesAesthetics[adaptiveHS.NI - 1]);
                if (ShowAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            BestHarmonyChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            BestHarmonyChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            BestHarmonyChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            BestHarmonyChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
        }

        private void saveResults(double bestHarmonyAesthetics)
        {
            richTextBox1.Text += counter;
            richTextBox1.Text += "\t";
            richTextBox1.Text += bestHarmonyAesthetics;
            richTextBox1.Text += "\n";
            results.Add(bestHarmonyAesthetics);
            counter++;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm configurationForm = new ConfigurationForm();
            configurationForm.Show();
            isBackButtonPressed = true;
            this.Close();
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void GraphsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!isBackButtonPressed)
                Application.Exit();
        }
    }
}
