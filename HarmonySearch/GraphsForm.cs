using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ClassicSearch classicHS { get; set; }
        public ImprovedSearch improvedHS { get; set; }
        public GlobalBestSearch globalHS { get; set; }
        public SelfAdaptiveSearch adaptiveHS { get; set; }

        public GraphsForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            classicHS.initializeMemory();
            classicHS.Run();
            improvedHS.initializeMemory();
            improvedHS.Run();
            globalHS.initializeMemory();
            globalHS.Run();
            adaptiveHS.initializeMemory();
            adaptiveHS.Run();
            plotChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classicHS.initializeMemory();
            classicHS.Run();
            improvedHS.initializeMemory();
            improvedHS.Run();
            globalHS.initializeMemory();
            globalHS.Run();
            adaptiveHS.initializeMemory();
            adaptiveHS.Run();
            plotChart();
        }

        private void plotChart()
        {
            chart.Series.Clear();

            chart.Series.Add("Classic Harmony Search");
            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].Color = System.Drawing.Color.DarkRed;
            chart.Series.Add("Improved Harmony Search");
            chart.Series[1].ChartType = SeriesChartType.Line;
            chart.Series[1].Color = System.Drawing.Color.DarkBlue;
            chart.Series.Add("Global Best Harmony Search");
            chart.Series[2].ChartType = SeriesChartType.Line;
            chart.Series[2].Color = System.Drawing.Color.SkyBlue;
            chart.Series.Add("Self Adaptive Harmony Search");
            chart.Series[3].ChartType = SeriesChartType.Line;
            chart.Series[3].Color = System.Drawing.Color.Orange;

            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            for (int i = 0; i < classicHS.NI; i++)
            {
                chart.Series[0].Points.AddXY(i, classicHS.bestHarmonies[i]);
                chart.Series[1].Points.AddXY(i, improvedHS.bestHarmonies[i]);
                chart.Series[2].Points.AddXY(i, globalHS.bestHarmonies[i]);
                chart.Series[3].Points.AddXY(i, adaptiveHS.bestHarmonies[i]);
            }
        }

    }
}
