using org.mariuszgromada.math.mxparser;
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

        public ClassicSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        public void initializeMemory()
        {
            Argument[] arguments = new Argument[TotalNotes];
            for (int i = 1; i <= TotalNotes; i++)
            {
                arguments[i - 1] = new Argument("x" + i, 0.0);
            }
            base.bestHarmonies = new double[NI];
            base.bestHarmoniesNotes = new double[NI, TotalNotes];
            base.memory = new List<Harmony>();
            for (int i = 0; i < HMSize; i++)
            {
                memory.Add(getRandomHarmony());
            }
            sortMemory();
        }

        public void Run(bool showAll)
        {
            for (int currentImprovisation = 0; currentImprovisation < NI; currentImprovisation++)
            {
                Harmony newHarmony = new Harmony();
                newHarmony.notes = new List<double>();
                for (int currentNote = 0; currentNote < TotalNotes; currentNote++)
                {
                    float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
                    if (randomFloat <= HMCR)
                    {
                        //Debug.WriteLine("HMCR");
                        int randomHarmony = Convert.ToInt32(Statics.getRandomDouble(0, HMSize - 1));
                        newHarmony.notes.Add(base.memory[randomHarmony].notes[currentNote]);
                        adjustPitch(newHarmony, currentNote);
                    }
                    else
                    {
                        newHarmony.notes.Add(Statics.getRandomDouble(MinimumValue, MaximumValue));
                    }
                }
                base.updateMemory(newHarmony, currentImprovisation);
                base.bestHarmonies[currentImprovisation] = getHarmonyAesthetics(memory[0]);
                base.bestHarmoniesNotes[currentImprovisation, 0] = memory[0].notes.ElementAt(0);
                base.bestHarmoniesNotes[currentImprovisation, 1] = memory[0].notes.ElementAt(1);
                if (showAll == true)
                    writeResults(currentImprovisation);
            }
        }

        private void adjustPitch(Harmony newHarmony, int index)
        {
            float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= PAR)
            {
                //Debug.WriteLine("PAR");
                randomFloat = Statics.getRandomFloat(-10.0f, 10.0f);
                if (randomFloat < 0)
                    newHarmony.notes[index] += Statics.getRandomDouble(0, BW);
                else if (randomFloat >= 0)
                    newHarmony.notes[index] -= Statics.getRandomDouble(0, BW);

                restrictNote(newHarmony.notes[index]);
            }
        }

        public void writeResults(int currentImprovisation)
        {
            output += "\n\n";
            output +=  "Improvisation Number: " + currentImprovisation + "\n";
            for (int i = 0; i < HMSize; i++)
            {
                output += i + " Harmony: ";
                for (int j = 0; j < TotalNotes; j++)
                {
                    output += "\n\t";
                    output += "Note " + j + ": " + memory.ElementAt(i).notes[j];
                }
                output += "\n\t Aesthetics: " + getHarmonyAesthetics(memory[i]);
                output += "\n";
            }
        }
    }
}
