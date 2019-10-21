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
        public bool activationFlag;
        private bool isBackButtonPressed = false;

        public ClassicSearch classicHS { get; set; }
        public ImprovedSearch improvedHS { get; set; }
        public GlobalBestSearch globalHS { get; set; }
        public SelfAdaptiveSearch adaptiveHS { get; set; }

        public ConfigurationForm Configuration { get; set; }

        private List<double> results = new List<double>();

        public GraphsForm()
        {
            InitializeComponent();
        }

        private void GraphsForm_Activated(object sender, EventArgs e)
        {
            if (activationFlag == false)
                return;
            SearchProgress.Show();
            this.Enabled = false;
            performHarmonySearch();
            plotChart();
            SearchProgress.Hide();
            this.Enabled = true;
            activationFlag = false;
        }

        private void RerunButton_Click(object sender, EventArgs e)
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
                if (classicHS.ShowAll == true)
                    resultsRichTextBox.Text = classicHS.Results.ToString();
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
                Label aestheticsLabel = new Label();
                ControlStyle.LabelStyle(aestheticsLabel, classicHS.bestHarmoniesAesthetics[classicHS.NI - 1]);
                numericsTab.Controls.Add(aestheticsLabel);
                for (int k = 1; k <= classicHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, classicHS.bestHarmoniesNotes[classicHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                
                saveResults(classicHS.bestHarmoniesAesthetics[classicHS.NI - 1]);
                //if (ShowAll == true)
                //    System.Diagnostics.Process.Start("Results.txt");
            }
            if (improvedHS != null)
            {
                if (improvedHS.ShowAll == true)
                    resultsRichTextBox.Text = improvedHS.Results.ToString();
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
                Label aestheticsLabel = new Label();
                ControlStyle.LabelStyle(aestheticsLabel, improvedHS.bestHarmoniesAesthetics[improvedHS.NI - 1]);
                numericsTab.Controls.Add(aestheticsLabel);
                for (int k = 1; k <= improvedHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, improvedHS.bestHarmoniesNotes[improvedHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                saveResults(improvedHS.bestHarmoniesAesthetics[improvedHS.NI - 1]);
                //if (ShowAll == true)
                //    System.Diagnostics.Process.Start("Results.txt");
            }
            if (globalHS != null)
            {
                if (globalHS.ShowAll == true)
                    resultsRichTextBox.Text = globalHS.Results.ToString();
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
                Label aestheticsLabel = new Label();
                ControlStyle.LabelStyle(aestheticsLabel, globalHS.bestHarmoniesAesthetics[globalHS.NI - 1]);
                numericsTab.Controls.Add(aestheticsLabel);
                for (int k = 1; k <= globalHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, globalHS.bestHarmoniesNotes[globalHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                saveResults(globalHS.bestHarmoniesAesthetics[globalHS.NI - 1]);
                //if (ShowAll == true)
                //    System.Diagnostics.Process.Start("Results.txt");
            }
            if (adaptiveHS != null)
            {
                if (adaptiveHS.ShowAll == true)
                    resultsRichTextBox.Text = adaptiveHS.Results.ToString();
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
                Label aestheticsLabel = new Label();
                ControlStyle.LabelStyle(aestheticsLabel, adaptiveHS.bestHarmoniesAesthetics[adaptiveHS.NI - 1]);
                numericsTab.Controls.Add(aestheticsLabel);
                for (int k = 1; k <= adaptiveHS.TotalNotes; k++)
                {
                    Label note = new Label();
                    ControlStyle.LabelStyle(note, k, adaptiveHS.bestHarmoniesNotes[adaptiveHS.NI - 1, k - 1]);
                    numericsTab.Controls.Add(note);
                }
                saveResults(adaptiveHS.bestHarmoniesAesthetics[adaptiveHS.NI - 1]);
                //if (ShowAll == true)
                //    System.Diagnostics.Process.Start("Results.txt");
            }
            BestHarmonyChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            BestHarmonyChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            BestHarmonyChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            BestHarmonyChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
        }

        private void saveResults(double bestHarmonyAesthetics)
        {
            //resultsRichTextBox.Text += counter;
            //resultsRichTextBox.Text += "\t";
            //resultsRichTextBox.Text += bestHarmonyAesthetics;
            //resultsRichTextBox.Text += "\n";
            //results.Add(bestHarmonyAesthetics);
            //counter++;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            isBackButtonPressed = true;
            this.Close();
            Configuration.initializeComponents();
            Configuration.Show();
        }

        private void performHarmonySearch()
        {
            if (classicHS != null)
            {
                classicHS.ShowAll = ShowAll;
                //Adım 1
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

        private void GraphsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isBackButtonPressed)
                Dispose();
            else
                Application.Exit();
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            //resultsRichTextBox.Text += "\n\n\n AVERAGE: ";
            //double sum = 0;
            //double variance = 0;
            //for (int i = 0; i < results.Count; i++)
            //{
            //    sum += results[i];
            //}
            //double avg = sum / results.Count;
            //for (int j = 0; j < results.Count; j++)
            //{
            //    variance += Math.Pow((results[j] - avg), 2);
            //}
            //double standardDeviation = Math.Sqrt(variance / results.Count);

            //resultsRichTextBox.Text += Math.Round(avg, 6);
            //resultsRichTextBox.Text += "\tStandard Deviation: " + Math.Round(standardDeviation, 6) + "\n\n";
        }
    }
}
