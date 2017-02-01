using NCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySearch
{
    public class Search
    {
        public int NI { get; set; } //Number of Improvisations aka generations
        public double MinimumValue { get; set; }
        public double MaximumValue { get; set; }
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }

        public double[] bestHarmonies { get; set; }
        public double[,] bestHarmoniesNotes { get; set; }
        public string output { get; set; }

        protected List<Harmony> memory;

        public Expression Objective { get; set; }
        public bool Maximize { get; set; }

        protected virtual Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.notes = new double[TotalNotes];
            for (int i = 0; i < TotalNotes; i++)
                hrm.notes[i] = Statics.getRandomDouble(MinimumValue, MaximumValue);

            return hrm;
        }

        protected double getHarmonyAesthetics(Harmony harmony)
        {
            int j = 0;
            for(int i = 0; i < TotalNotes; i++)
            {
                j = i + 1;
                Objective.Parameters["x" + j] = harmony.notes[i];
            }
            return (double)Objective.Evaluate();
        }

        protected void sortMemory()
        {
            Harmony tempHar = new Harmony();
            for (int i = 0; i < memory.Count; i++)
            {
                for (int j = i + 1; j < memory.Count; j++)
                {
                    if (Maximize == true)
                    {
                        if (getHarmonyAesthetics(memory[i]) < getHarmonyAesthetics(memory[j]))
                        {
                            tempHar = memory[i];
                            memory[i] = memory[j];
                            memory[j] = tempHar;
                        }
                    }
                    else
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
        }

        protected void updateMemory(Harmony newHar, int currentIteration)
        {
            if(Maximize == true)
            {
                if (getHarmonyAesthetics(newHar) > getHarmonyAesthetics(memory[HMSize - 1]))
                {
                    memory[HMSize - 1] = newHar;
                    sortMemory();
                }
            }
            else
            {
                if (getHarmonyAesthetics(newHar) < getHarmonyAesthetics(memory[HMSize - 1]))
                {
                    memory[HMSize - 1] = newHar;
                    sortMemory();
                }
            }

        }

        protected double restrictNote(double note)
        {
            if (note > MaximumValue)
                return MaximumValue;
            else if (note < MinimumValue)
                return MinimumValue;
            else
                return note;
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
                    output += "Note " + j + ": " + memory.ElementAt(i).notes[j];
                }
                output += "\n\t Aesthetics: " + getHarmonyAesthetics(memory[i]);
                output += "\n";
            }
        }

        protected int countDuplicates()
        {
            int duplicatesCounter = 0;
            List<Harmony> selectedHarmonies = new List<Harmony>();
            bool harmonyExists;

            for (int i = 0; i < HMSize - 1; i++)
            {
                harmonyExists = false;
                for(int k = 0; k < selectedHarmonies.Count; k++)
                {
                    if(getHarmonyAesthetics(memory[i]) == getHarmonyAesthetics(selectedHarmonies[k]))
                    {
                        harmonyExists = true;
                        break;
                    }
                }
                if (harmonyExists == true)
                    continue;
                selectedHarmonies.Add(memory[i]);
                for (int j = i+1; j < HMSize; j++)
                {
                    if(getHarmonyAesthetics(memory[i]) == getHarmonyAesthetics(memory[j]))
                    {
                        duplicatesCounter++;
                    }
                }
            }
            return duplicatesCounter;
        }
    }
}
