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
    public class ImprovedSearch : Search
    {
        public float HMCR { get; set; }

        public float PARmin { get; set; }
        public float PARmax { get; set; }
        public double BWmin { get; set; }
        public double BWmax { get; set; }
        
        private string output = "";
        public List<double> bestHarmonies;

        public ImprovedSearch()
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
                newHarmony.notes = new List<double>();
                for (int currentNote = 0; currentNote < TotalNotes; currentNote++)
                {
                    float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
                    if (randomFloat <= HMCR)
                    {
                        Debug.WriteLine("HMCR");
                        int randomHarmony = Convert.ToInt32(Statics.getRandomDouble(0, HMSize - 1));
                        newHarmony.notes.Add(memory[randomHarmony].notes[currentNote]);
                        adjustPitch(newHarmony, currentNote, currentImprovisation);
                    }
                    else
                    {
                        newHarmony.notes.Add(Statics.getRandomDouble(MinimumValue, MaximumValue));
                    }
                }
                updateMemory(newHarmony, currentImprovisation);
                bestHarmonies.Add(getHarmonyAesthetics(memory[0]));
                //writeResults(currentIteration);
            }
        }

        private void adjustPitch(Harmony newHarmony, int index, int currentImprovisation)
        {
            float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= getPAR(currentImprovisation))
            {
                Debug.WriteLine("PAR");
                randomFloat = Statics.getRandomFloat(-10.0f, 10.0f);
                if (randomFloat < 0)
                {
                    newHarmony.notes[index] += Statics.getRandomDouble(0, getBandwidth(currentImprovisation));
                    restrictNote(newHarmony.notes[index]);
                }
                else if (randomFloat >= 0)
                {
                    newHarmony.notes[index] -= Statics.getRandomDouble(0, getBandwidth(currentImprovisation));
                    restrictNote(newHarmony.notes[index]);
                }
            }
        }

        private float getPAR(int currentImprovisation)
        {
            return PARmin + ((PARmax - PARmin)/NI) * currentImprovisation;
        }

        private double getBandwidth(int currentImprovisation)
        {
            return BWmax + Math.Exp((Math.Log(BWmax / BWmin)/NI) * currentImprovisation);
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
                    output += "Note " + j + ": " + memory.ElementAt(i).notes[j];
                }
                output += "\n\t Aesthetics: " + getHarmonyAesthetics(memory[i]);
                output += "\n";
            }
        }
    }
}
