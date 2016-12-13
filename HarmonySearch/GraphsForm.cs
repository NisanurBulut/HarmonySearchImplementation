﻿using System;
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
            if (classicHS != null)
            {
                classicHS.initializeMemory();
                classicHS.Run();
            }
            if (improvedHS != null)
            {
                improvedHS.initializeMemory();
                improvedHS.Run();
            }
            if(globalHS != null)
            {
                globalHS.initializeMemory();
                globalHS.Run();
            }
            if(adaptiveHS != null)
            {
                adaptiveHS.initializeMemory();
                adaptiveHS.Run();
            }
            plotChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (classicHS != null)
            {
                classicHS.initializeMemory();
                classicHS.Run();
            }
            if (improvedHS != null)
            {
                improvedHS.initializeMemory();
                improvedHS.Run();
            }
            if (globalHS != null)
            {
                globalHS.initializeMemory();
                globalHS.Run();
            }
            if (adaptiveHS != null)
            {
                adaptiveHS.initializeMemory();
                adaptiveHS.Run();
            }
            plotChart();
        }

        private void plotChart()
        {
            chart.Series.Clear();

            if (classicHS != null)
            {
                chart.Series.Add("Classic Harmony Search");
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Series[0].Color = System.Drawing.Color.DarkRed;
                for (int i = 0; i < classicHS.NI; i++)
                {
                    chart.Series[0].Points.AddXY(i, classicHS.bestHarmonies[i]);
                }
            }
            if (improvedHS != null)
            {
                chart.Series.Add("Improved Harmony Search");
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Series[0].Color = System.Drawing.Color.DarkBlue;
                for (int i = 0; i < improvedHS.NI; i++)
                {
                    chart.Series[0].Points.AddXY(i, improvedHS.bestHarmonies[i]);
                }
            }
            if (globalHS != null)
            {
                chart.Series.Add("Global Best Harmony Search");
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Series[0].Color = System.Drawing.Color.SkyBlue;
                for (int i = 0; i < globalHS.NI; i++)
                {
                    chart.Series[0].Points.AddXY(i, globalHS.bestHarmonies[i]);
                }
            }
            if (adaptiveHS != null)
            {
                chart.Series.Add("Self Adaptive Harmony Search");
                chart.Series[0].ChartType = SeriesChartType.Line;
                chart.Series[0].Color = System.Drawing.Color.Orange;
                for (int i = 0; i < adaptiveHS.NI; i++)
                {
                    chart.Series[0].Points.AddXY(i, adaptiveHS.bestHarmonies[i]);
                }
            }
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
        }

    }
}