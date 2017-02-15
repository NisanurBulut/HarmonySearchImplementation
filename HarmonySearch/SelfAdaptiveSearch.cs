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
    public class SelfAdaptiveSearch : Search
    {
        private List<double> minVariables;
        private List<double> maxVariables;
        public float HMCR { get; set; }
        public float PAR { get; set; }
        public double BW { get; set; }

        private static SelfAdaptiveSearch instance = null;

        private SelfAdaptiveSearch()
        {
            initializeMemory();
        }

        public static SelfAdaptiveSearch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SelfAdaptiveSearch();
                }
                return instance;
            }
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        protected override Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.notes = new double[TotalNotes];
            for (int i = 0; i < TotalNotes; i++)
                hrm.notes[i] = Randomizer.getRandomDouble(MinimumValues[i], MaximumValues[i]);

            checkMaxVariables(hrm);
            checkMinVariables(hrm);

            return hrm;
        }

        public void initializeMemory()
        {
            Results = "";
            base.bestHarmoniesAesthetics = new double[NI];
            base.newHarmoniesAesthetics = new double[NI];
            base.worstHarmoniesAesthetics = new double[NI];
            base.bestHarmoniesNotes = new double[NI, TotalNotes];
            Memory = new List<Harmony>();
            //TODO:
            initializeExtremeVariables();
            for (int i = 0; i < HMSize; i++)
                Memory.Add(getRandomHarmony());

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
                        adjustPitch(newHarmony, currentNote);
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

        private void adjustPitch(Harmony newHarmony, int index)
        {
            //TODO: Must adjust based on the best and worst decision-variables
            float randomFloat = Randomizer.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= PAR)
            {
                randomFloat = Randomizer.getRandomFloat(-10.0f, 10.0f);
                if (randomFloat < 0)
                    newHarmony.notes[index] += (maxVariables[index] - newHarmony.notes[index]) * Randomizer.getRandomDouble(0.0, 1.0);
                else if (randomFloat >= 0)
                    newHarmony.notes[index] -= (newHarmony.notes[index] - minVariables[index] ) * Randomizer.getRandomDouble(0.0, 1.0);

                newHarmony.notes[index] = restrictNote(newHarmony.notes[index], index);
            }
        }

        private void checkMaxVariables(Harmony newHarmony)
        {
            for(int i = 0; i < TotalNotes; i++)
            {
                if (newHarmony.notes[i] > maxVariables[i])
                    maxVariables[i] = newHarmony.notes[i];
            }
        }

        private void checkMinVariables(Harmony newHarmony)
        {
            for (int i = 0; i < TotalNotes; i++)
            {
                if (newHarmony.notes[i] < minVariables[i])
                    minVariables[i] = newHarmony.notes[i];
            }
        }

        private void initializeExtremeVariables()
        {
            minVariables = new List<double>();
            maxVariables = new List<double>();
            for(int i=0; i<TotalNotes; i++)
            {
                minVariables.Add(MaximumValues[i]);
                maxVariables.Add(MinimumValues[i]);
            }
        }
    }
}
