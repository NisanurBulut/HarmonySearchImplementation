using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public class ImprovedSearch : Search
    {
        public float HMCR { get; set; }

        public float PARmin { get; set; }
        public float PARmax { get; set; }
        public double BWmin { get; set; }
        public double BWmax { get; set; }

        private static ImprovedSearch instance = null;

        private ImprovedSearch()
        {
            initializeMemory();
        }

        public static ImprovedSearch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImprovedSearch();
                }
                return instance;
            }
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        public void initializeMemory()
        {
            Results = new StringBuilder();
            base.bestHarmoniesAesthetics = new double[NI];
            base.newHarmoniesAesthetics = new double[NI];
            base.worstHarmoniesAesthetics = new double[NI];
            base.bestHarmoniesNotes = new double[NI, TotalNotes];
            Memory = null;
            Memory = new Harmony[HMSize];
            for (int i = 0; i < HMSize; i++)
                Memory[i] = getRandomHarmony();

            sortMemory();
        }

        public void Run(ProgressBar progressBar)
        {
            for (int currentImprovisation = 0; currentImprovisation < NI; currentImprovisation++)
            {
                Harmony newHarmony = new Harmony();
                newHarmony.notes = new double[TotalNotes];
                for (int currentNote = 0; currentNote < TotalNotes; currentNote++)
                {
                    float randomFloat = Randomizer.getRandomFloat(0.0f, 1.0f);
                    if (randomFloat <= HMCR)
                    {
                        int randomHarmony = Convert.ToInt32(Randomizer.getRandomDouble(0, HMSize - 1));
                        newHarmony.notes[currentNote] = Memory[randomHarmony].notes[currentNote];
                        adjustPitch(newHarmony, currentNote, currentImprovisation);
                    }
                    else
                    {
                        newHarmony.notes[currentNote] = Randomizer.getRandomDouble(MinimumValues[currentNote], MaximumValues[currentNote]);
                    }
                }
                updateMemory(newHarmony, currentImprovisation);
                //if (currentImprovisation == 249)
                //{
                //    countDuplicates();
                //}
                base.bestHarmoniesAesthetics[currentImprovisation] = getHarmonyAesthetics(Memory[0]);
                base.newHarmoniesAesthetics[currentImprovisation] = getHarmonyAesthetics(newHarmony);
                base.worstHarmoniesAesthetics[currentImprovisation] = getHarmonyAesthetics(Memory[HMSize - 1]);
                for (int i = 0; i < TotalNotes; i++)
                {
                    base.bestHarmoniesNotes[currentImprovisation, i] = Memory[0].notes.ElementAt(i);
                }
                if (ShowAll == true)
                {
                    base.writeResults(currentImprovisation);

                    Console.WriteLine(Results);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                progressBar.Value = currentImprovisation;
                int percent = (int)(((double)(progressBar.Value - progressBar.Minimum) / (double)(progressBar.Maximum - progressBar.Minimum)) * 100);
                string progressMessage = "Please wait... Harmony Search in progress. " + percent.ToString() + "%" + " completed.";
                ControlStyle.SetProgressBarText(progressBar, progressMessage, ControlStyle.ProgressBarTextLocation.Centered, Color.Black, new Font("Arial", 16));
            }
        }

        private void adjustPitch(Harmony newHarmony, int index, int currentImprovisation)
        {
            float randomFloat = Randomizer.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= getPAR(currentImprovisation))
            {
                randomFloat = Randomizer.getRandomFloat(-10.0f, 10.0f);
                if (randomFloat < 0)
                {
                    newHarmony.notes[index] += Randomizer.getRandomDouble(0, getBandwidth(currentImprovisation));
                    newHarmony.notes[index] = restrictNote(newHarmony.notes[index], index);
                }
                else if (randomFloat >= 0)
                {
                    newHarmony.notes[index] -= Randomizer.getRandomDouble(0, getBandwidth(currentImprovisation));
                    newHarmony.notes[index] = restrictNote(newHarmony.notes[index], index);
                }
            }
        }

        private float getPAR(int currentImprovisation)
        {
            float newPAR = PARmin + ((PARmax - PARmin) / NI) * currentImprovisation;
            return newPAR;
        }

        private double getBandwidth(int currentImprovisation)
        {
            //double c = Math.Log(BWmin / BWmax) * (1 / NI);
            //double newBW = BWmax * Math.Exp(c * currentImprovisation);
            ////double newBW = BWmin + ((BWmax - BWmin) / NI) * currentImprovisation;
            //return newBW;

            double newBW = BWmax - ((BWmax - BWmin) / NI) * currentImprovisation;
            return newBW;
        }
    }
}
