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

        public string output { get; set; }
        public List<double> bestHarmonies;

        public GlobalBestSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        public void initializeMemory()
        {
            bestHarmonies = new List<double>();
            memory = new List<Harmony>();
            for (int i = 0; i < HMSize; i++)
                memory.Add(getRandomHarmony());

            sortMemory();
        }

        public void Run()
        {
            for (int currentImprovisation = 0; currentImprovisation < NI; currentImprovisation++)
            {
                Harmony newHarmony = new Harmony();
                newHarmony.note = new List<double>();
                for (int currentNote = 0; currentNote < TotalNotes; currentNote++)
                {
                    float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
                    if (randomFloat <= HMCR)
                    {
                        Debug.WriteLine("HMCR");
                        int randomHarmony = Convert.ToInt32(Statics.getRandomDouble(0, HMSize - 1));
                        newHarmony.note.Add(memory[randomHarmony].note[currentNote]);
                        adjustPitch(newHarmony, currentNote);
                    }
                    else
                    {
                        newHarmony.note.Add(Statics.getRandomDouble(MinimumValue, MaximumValue));
                    }
                }
                updateMemory(newHarmony, currentImprovisation);
                bestHarmonies.Add(getHarmonyAesthetics(memory[0]));
                //writeResults(currentImprovisation);
            }
        }

        private void adjustPitch(Harmony newHarmony, int index)
        {
            float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= PAR)
            {
                Debug.WriteLine("PAR");
                newHarmony.note[index] = memory[0].note[index];
            }
        }

        public void writeResults(int currentImprovisation)
        {
            output += "\n\n";
            output += "Improvisation Number: " + currentImprovisation + "\n";
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
        }
    }
}
