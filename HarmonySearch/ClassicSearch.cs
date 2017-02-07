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
    public class ClassicSearch : Search
    {
        public float HMCR { get; set; }
        public float PAR { get; set; }
        public double BW { get; set; }
        private int diversityAdjustments = 0;
        private int diversityIteration = 20;
        private float defaultPAR;

        public ClassicSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        public void initializeMemory()
        {
            results = "";
            defaultPAR = PAR;
            diversityIteration = 20;
            diversityAdjustments = 0;
            base.bestHarmonies = new double[NI];
            base.bestHarmoniesNotes = new double[NI, TotalNotes];
            base.Memory = new List<Harmony>();
            for (int i = 0; i < HMSize; i++)
            {
                Memory.Add(getRandomHarmony());
            }
            sortMemory();
        }

        public void Run(bool showAll)
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
                        newHarmony.notes[currentNote] = Randomizer.getRandomDouble(MinimumValue, MaximumValue);
                    }
                }
                base.updateMemory(newHarmony, currentImprovisation);
                if (currentImprovisation == diversityIteration)
                {
                    diversifyPopulation();
                    diversityIteration += 20;
                }
                if (currentImprovisation == 249)
                {
                    countDuplicates();
                }
                base.bestHarmonies[currentImprovisation] = getHarmonyAesthetics(Memory[0]);
                for(int i = 0; i < TotalNotes; i++)
                {
                    base.bestHarmoniesNotes[currentImprovisation, i] = Memory[0].notes.ElementAt(i);
                }

                if (showAll == true)
                    base.writeResults(currentImprovisation);
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

                newHarmony.notes[index] = restrictNote(newHarmony.notes[index]);
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
