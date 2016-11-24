using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public partial class HarmonyForm : Form
    {
        ClassicSearch chs;

        public HarmonyForm()
        {
            InitializeComponent();
            chs = new ClassicSearch();

        }

        private void playButton_Click(object sender, System.EventArgs e)
        {
            chs = new ClassicSearch();
            chs.chart = chart;
            chs.Run();
            richTextBox1.Text = chs.output;
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            chs = new ClassicSearch();
            chs.chart = chart;
            chs.Run();
            plotChart(chs.bestHarmonies);
        }

        private void plotChart(List<double> bestHarmonies)
        {
            chart.Series.Clear();
            chart.Series.Add("Classic Harmony Search");
            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].Color = System.Drawing.Color.Red;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            //chart.Legends.Clear();
            for (int i = 0; i < bestHarmonies.Count; i++)
            {
                chart.Series[0].Points.AddXY(i, bestHarmonies[i]);
            }
            chart.ChartAreas[0].AxisX.Interval = bestHarmonies.Count / 10;
        }

        private void setHarmonySearch()
        {
            /*
            chs.NI = Convert.ToInt32(textBox1.Text);
            chs.HMCR = Convert.ToDouble(textBox2.Text);
            chs.PAR = Convert.ToDouble(textBox3.Text);
            chs.BW = Convert.ToDouble(textBox4.Text);
            chs.ECR = Convert.ToDouble(textBox5.Text);
            chs.HMS = Convert.ToInt32(textBox6.Text);
            chs.TotalNotes = Convert.ToInt32(textBox7.Text);
            chs.MaximumNote = Convert.ToDouble(textBox8.Text);
            chs.MinimumNote = Convert.ToDouble(textBox9.Text);
            */
        }

    }
}
