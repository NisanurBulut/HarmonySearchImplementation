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
    public class GlobalBestSearch : Search
    {
        public float HMCR { get; set; }
        public float PAR { get; set; }
        public double BW { get; set; }

        private static GlobalBestSearch instance = null;

        private GlobalBestSearch()
        {
            initializeMemory();
        }

        public static GlobalBestSearch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalBestSearch();
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
                        adjustPitch(newHarmony);
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
                base.worstHarmoniesAesthetics[currentImprovisation] = getHarmonyAesthetics(Memory[HMSize-1]);
                for (int i = 0; i < TotalNotes; i++)
                {
                    base.bestHarmoniesNotes[currentImprovisation, i] = Memory[0].notes.ElementAt(i);
                }
                if (ShowAll == true)
                {
                    base.writeResults(currentImprovisation);

                    //Console.WriteLine(Results);
                    //Console.WriteLine("Press any key to continue...");
                    //Console.ReadKey();
                }

                progressBar.Value = currentImprovisation;
                int percent = (int)(((double)(progressBar.Value - progressBar.Minimum) / (double)(progressBar.Maximum - progressBar.Minimum)) * 100);
                string progressMessage = "Please wait... Harmony Search in progress. " + percent.ToString() + "%" + " completed.";
                ControlStyle.SetProgressBarText(progressBar, progressMessage, ControlStyle.ProgressBarTextLocation.Centered, Color.Black, new Font("Arial", 16));
            }
        }

        private void adjustPitch(Harmony newHarmony)
        {
            float randomFloat = Randomizer.getRandomFloat(0.0f, 1.0f);
            int index = Randomizer.getRandomInteger(0, TotalNotes - 1);
            if (randomFloat <= PAR)
            {
                newHarmony.notes[index] = Memory[0].notes[index];
            }
            newHarmony.notes[index] = restrictNote(newHarmony.notes[index], index);
        }
    }
}
