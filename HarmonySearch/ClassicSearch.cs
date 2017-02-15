using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HarmonySearch
{
    public class ClassicSearch : Search
    {
        public float HMCR { get; set; }
        public float PAR { get; set; }
        public double BW { get; set; }
        private int diversityAdjustments = 0;
        private int diversityIteration = 20;
        private float defaultPAR;

        private static ClassicSearch instance = null;

        private ClassicSearch()
        {
            initializeMemory();
        }

        public static ClassicSearch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClassicSearch();
                }
                return instance;
            }
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        public void initializeMemory()
        {
            Results = "";
            defaultPAR = PAR;
            diversityIteration = 50;
            diversityAdjustments = 0;
            base.bestHarmoniesAesthetics = new double[NI];
            base.newHarmoniesAesthetics = new double[NI];
            base.worstHarmoniesAesthetics = new double[NI];
            base.bestHarmoniesNotes = new double[NI, TotalNotes];
            base.Memory = new List<Harmony>();
            for (int i = 0; i < HMSize; i++)
            {
                Memory.Add(getRandomHarmony());
            }
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
                        //Debug.WriteLine("HMCR");
                        int randomHarmony = Convert.ToInt32(Randomizer.getRandomDouble(0, HMSize - 1));
                        newHarmony.notes[currentNote] = base.Memory[randomHarmony].notes[currentNote];
                        adjustPitch(newHarmony, currentNote);
                    }
                    else
                    {
                        newHarmony.notes[currentNote] = Randomizer.getRandomDouble(MinimumValues[currentNote], MaximumValues[currentNote]);
                    }
                }
                base.updateMemory(newHarmony, currentImprovisation);
                //if (currentImprovisation == diversityIteration)
                //{
                //    diversifyPopulation();
                //    diversityIteration += 20;
                //}
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

                //Progress Bar Text
                progressBar.Value = currentImprovisation;
                int percent = (int)(((double)(progressBar.Value - progressBar.Minimum) / (double)(progressBar.Maximum - progressBar.Minimum)) * 100);
                string progressMessage = "Please wait... Harmony Search in progress. " + percent.ToString() + "%" + " completed.";
                ControlStyle.SetProgressBarText(progressBar, progressMessage, ControlStyle.ProgressBarTextLocation.Centered, Color.Black, new Font("Arial", 16));
            }
        }

        private void adjustPitch(Harmony newHarmony, int index)
        {
            float randomFloat = Randomizer.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= PAR)
            {
                //Debug.WriteLine("PAR");
                randomFloat = Randomizer.getRandomFloat(-10.0f, 10.0f);
                if (randomFloat < 0)
                    newHarmony.notes[index] += Randomizer.getRandomDouble(0, BW);
                else if (randomFloat >= 0)
                    newHarmony.notes[index] -= Randomizer.getRandomDouble(0, BW);

                newHarmony.notes[index] = restrictNote(newHarmony.notes[index], index);
            }
        }

        private void diversifyPopulation()
        {
            int populationThreshold = (int) (HMSize * 10 / 100);
            if (countDuplicates() >= populationThreshold)
            {
                PAR += defaultPAR;
                if (PAR >= 1)
                    PAR = 1;
                diversityAdjustments++;
                return;
            }
            if(diversityAdjustments > 0)
            {
                PAR = defaultPAR;
                diversityAdjustments = 0;
            }
        }


    }
}
