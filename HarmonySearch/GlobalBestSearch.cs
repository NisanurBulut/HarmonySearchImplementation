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
    public class GlobalBestSearch : Search
    {
        public float HMCR { get; set; }
        public float PAR { get; set; }
        public double BW { get; set; }

        public GlobalBestSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        public void initializeMemory()
        {
            base.bestHarmonies = new double[NI];
            base.bestHarmoniesNotes = new double[NI, TotalNotes];
            memory = new List<Harmony>();
            for (int i = 0; i < HMSize; i++)
                memory.Add(getRandomHarmony());

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
                    float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
                    if (randomFloat <= HMCR)
                    {
                        Debug.WriteLine("HMCR");
                        int randomHarmony = Convert.ToInt32(Statics.getRandomDouble(0, HMSize - 1));
                        newHarmony.notes[currentNote] = memory[randomHarmony].notes[currentNote];
                        adjustPitch(newHarmony, currentNote);
                    }
                    else
                    {
                        newHarmony.notes[currentNote] = Statics.getRandomDouble(MinimumValue, MaximumValue);
                    }
                }
                updateMemory(newHarmony, currentImprovisation);
                if (currentImprovisation == 249)
                {
                    countDuplicates();
                }
                base.bestHarmonies[currentImprovisation] = getHarmonyAesthetics(memory[0]);
                for (int i = 0; i < TotalNotes; i++)
                {
                    base.bestHarmoniesNotes[currentImprovisation, i] = memory[0].notes.ElementAt(i);
                }
                if (showAll == true)
                    base.writeResults(currentImprovisation);
            }
        }

        private void adjustPitch(Harmony newHarmony, int index)
        {
            float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= PAR)
            {
                Debug.WriteLine("PAR");
                newHarmony.notes[index] = memory[0].notes[index];
            }
            newHarmony.notes[index] = restrictNote(newHarmony.notes[index]);
        }
    }
}
