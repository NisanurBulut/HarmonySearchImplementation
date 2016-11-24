using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public class Search
    {
        //public double MinimumNote { get; set; };
        private static readonly double MinimumNote = -2.048;
        //public double MaximumNote { get; set; };
        private static readonly double MaximumNote = 2.048;
        //private static readonly double MinimumNote = 0.0;
        //private static readonly double MaximumNote = 2 * Math.PI;
        //private static readonly double MinimumNote = -5.12;
        //private static readonly double MaximumNote = 5.12;
        //private static readonly double MinimumNote = -100.00;
        //private static readonly double MaximumNote = 100.00;
        private static readonly int TotalNotes = 2;
        //public int TotalNotes { get; set; }
        private static readonly int HMSize = 30;
        //public int HMSize { get; set; }
        private static readonly int NI = 2500; //Number of Improvisations
        //public int NI { get; set; }
        private static readonly double HMCR = 0.90;
        //public double HMCR { get; set; }
        private static readonly double PAR = 0.09;
        //public double PAR { get; set; }

        public double BW { get; set; }
        
        private string output = "";
        public List<double> bestHarmonies = new List<double>();
        public RichTextBox richTextBox { get; set; }
        public Chart chart { get; set; }

        public Search()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;
        List<Harmony> memory = new List<Harmony>();

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        //public static int getRandomInteger(int min, int max)
        //{
        //    lock (syncLock)
        //    {
        //        return random.Next(min, max);
        //    }
        //}
        public static double getRandomDouble(double min, double max)
        {
            lock (syncLock)
            {
                return random.NextDouble() * (max - min) + min;
            }
        }

        private Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.note = new List<double>();
            for (int i = 0; i < TotalNotes; i++)
                hrm.note.Add(getRandomDouble(MinimumNote, MaximumNote));

            return hrm;
        }

        private void initializeMemory()
        {
            for (int i = 0; i < HMSize; i++)
                memory.Add(getRandomHarmony());

            sortMemory();
        }

        private double getHarmonyAesthetics(Harmony harmony)
        {
            //double aesthetics = Math.Sin(harmony.note[0]) + Math.Cos(harmony.note[1]) + Math.Sin(harmony.note[2]) + Math.Cos(harmony.note[3]) + Math.Sin(harmony.note[4]);
            double aesthetics = 100*(harmony.note[1] - Math.Pow(harmony.note[0], 2)) + Math.Pow(1 - harmony.note[0], 2); //Rosenbrock Function

            //double aesthetics = Math.Pow(harmony.note[0], 2) + Math.Pow(harmony.note[1], 2);// + Math.Pow(harmony.note[2], 2) + Math.Pow(harmony.note[3], 2) + Math.Pow(harmony.note[4], 2); //Sphere Function

            return aesthetics;
        }

        public void Run()
        {
            for (int currentIteration = 0; currentIteration < NI; currentIteration++)
            {
                Harmony newHarmony = new Harmony();
                newHarmony.note = new List<double>();
                for (int currentNote = 0; currentNote < TotalNotes; currentNote++)
                {
                    double randomDouble = getRandomDouble(0.0, 1.0);
                    if (randomDouble <= HMCR)
                    {
                        Debug.WriteLine("HMCR");
                        int randomHarmony = Convert.ToInt32(getRandomDouble(0, HMSize - 1));
                        newHarmony.note.Add(memory[randomHarmony].note[currentNote]);
                        adjustPitch(newHarmony, currentNote);
                    }
                    else
                    {
                        newHarmony.note.Add(getRandomDouble(MinimumNote, MaximumNote));
                    }
                }
                updateMemory(newHarmony, currentIteration);
                bestHarmonies.Add(getHarmonyAesthetics(memory[0]));
                //writeResults(currentIteration);
            }
        }

        private void adjustPitch(Harmony newHarmony, int index)
        {
            double randomDouble = getRandomDouble(0.0, 1.0);
            if (randomDouble <= PAR)
            {
                Debug.WriteLine("PAR");
                if (getRandomDouble(-10.0, 10.0) < 0)
                {
                    newHarmony.note[index] += getRandomDouble(MinimumNote, MaximumNote);
                    restrictNote(newHarmony.note[index]);
                }
                else if (getRandomDouble(-10.0, 10.0) >= 0)
                {
                    newHarmony.note[index] -= getRandomDouble(MinimumNote, MaximumNote);
                    restrictNote(newHarmony.note[index]);
                }
            }
            //return 0;
        }

        private double restrictNote(double note)
        {
            if (note > MaximumNote)
                return MaximumNote;
            else if (note < MinimumNote)
                return MinimumNote;
            else
                return note;
        }

        private void sortMemory()
        {
            Harmony tempHar = new Harmony();
            for (int i = 0; i < memory.Count; i++)
            {
                for (int j = i + 1; j < memory.Count; j++)
                {
                    if (getHarmonyAesthetics(memory[i]) > getHarmonyAesthetics(memory[j]))
                    {
                        tempHar = memory[i];
                        memory[i] = memory[j];
                        memory[j] = tempHar;
                    }
                }
            }
        }

        private void updateMemory(Harmony newHar, int currentIteration)
        {
            //int duplicatesCount = 0;
            if (getHarmonyAesthetics(newHar) < getHarmonyAesthetics(memory[HMSize - 1]))
            {
                memory[HMSize - 1] = newHar;
                sortMemory();
            }
        }

        public void writeResults(int currentIteration)
        {
            //string output = "";
            output += "\n\n";
            output += currentIteration + " Iteration: \n";
            for (int i = 0; i < HMSize; i++)
            {
                output += i + " Harmony: ";
                for (int j = 0; j < TotalNotes; j++)
                {
                    output += "\n\t";
                    output += "Note " + j + ": " + memory.ElementAt(i).note[j];
                }
                output += "\n\t Aesthetics: " + getHarmonyAesthetics(memory[i]);
                output += "\n";
            }
            if(richTextBox != null)
            {
                richTextBox.Text = "";
                richTextBox.Text += output;
            }
            //if(chart != null)
                //plotChart(currentIteration);
            //return output;
            //Console.Write(output);
            //Debug.WriteLine(output);
        }

        public void plotChart()
        {
            chart.Series.Clear();
            chart.Series.Add("Harmony Improvisation");
            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].Color = System.Drawing.Color.Red;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.Legends.Clear();
            for(int i=0; i<bestHarmonies.Count; i++)
            {
                chart.Series[0].Points.AddXY(i, bestHarmonies[i]);
            }
            chart.ChartAreas[0].AxisX.Interval = 150;
        }
    }
}
