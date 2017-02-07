using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public partial class GraphsForm : Form
    {
        public bool showAll { get; set; }
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

        private void Form2_Load(object sender, EventArgs e)
        {
            if (classicHS != null)
            {
                classicHS.initializeMemory();
                classicHS.Run(showAll);
            }
            if (improvedHS != null)
            {
                improvedHS.initializeMemory();
                improvedHS.Run(showAll);
            }
            if (globalHS != null)
            {
                globalHS.initializeMemory();
                globalHS.Run(showAll);
            }
            if (adaptiveHS != null)
            {
                adaptiveHS.initializeMemory();
                adaptiveHS.Run(showAll);
            }
            plotChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (classicHS != null)
            {
                classicHS.initializeMemory();
                classicHS.Run(showAll);
            }
            if (improvedHS != null)
            {
                improvedHS.initializeMemory();
                improvedHS.Run(showAll);
            }
            if (globalHS != null)
            {
                globalHS.initializeMemory();
                globalHS.Run(showAll);
            }
            if (adaptiveHS != null)
            {
                adaptiveHS.initializeMemory();
                adaptiveHS.Run(showAll);
            }
            plotChart();
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
                //for (int i = 0; i < classicHS.TotalNotes; i++)
                //{
                //    BestHarmonyChart.Series.Add("Note " + i);
                //    BestHarmonyChart.Series[i + 1].ChartType = SeriesChartType.StepLine;
                //    BestHarmonyChart.Series[i + 1].Color = Color.FromArgb(i*100, i*100, i*100);
                //}
                for (int j = 0; j < classicHS.NI; j++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(j, classicHS.bestHarmonies[j]);
                    X1Chart.Series[0].Points.AddXY(j, classicHS.bestHarmoniesNotes[j, 0]);
                    X2Chart.Series[0].Points.AddXY(j, classicHS.bestHarmoniesNotes[j, 1]);
                    //for (int k = 0; k < classicHS.TotalNotes; k++)
                    //{
                    //    BestHarmonyChart.Series[k+1].Points.AddXY(j, classicHS.bestHarmoniesNotes[j, k]);
                    //}
                }
                saveResults(classicHS.bestHarmonies[classicHS.NI - 1]);
                if(showAll == true)
                    System.Diagnostics.Process.Start("Results.txt");
            }
            if (improvedHS != null)
            {
                BestHarmonyChart.Series.Add("Improved Harmony Search");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.DarkBlue;
                for (int i = 0; i < improvedHS.NI; i++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(i, improvedHS.bestHarmonies[i]);
                }
                saveResults(improvedHS.bestHarmonies[improvedHS.NI - 1]);
            }
            if (globalHS != null)
            {
                BestHarmonyChart.Series.Add("Global Best Harmony Search");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.SkyBlue;
                for (int i = 0; i < globalHS.NI; i++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(i, globalHS.bestHarmonies[i]);
                }
                saveResults(globalHS.bestHarmonies[globalHS.NI - 1]);
            }
            if (adaptiveHS != null)
            {
                BestHarmonyChart.Series.Add("Self Adaptive Harmony Search");
                BestHarmonyChart.Series[0].ChartType = SeriesChartType.Line;
                BestHarmonyChart.Series[0].Color = System.Drawing.Color.Orange;
                for (int i = 0; i < adaptiveHS.NI; i++)
                {
                    BestHarmonyChart.Series[0].Points.AddXY(i, adaptiveHS.bestHarmonies[i]);
                }
                saveResults(adaptiveHS.bestHarmonies[adaptiveHS.NI - 1]);
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
    }
}
