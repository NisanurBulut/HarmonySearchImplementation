using NCalc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySearch
{
    public abstract class Search
    {
        public int NI { get; set; } //Number of Improvisations aka generations
        //public double MinimumValue { get; set; }
        public double[] MinimumValues { get; set; }
        //public double MaximumValue { get; set; }
        public double[] MaximumValues { get; set; }
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }

        public double[] bestHarmonies { get; set; }
        public double[,] bestHarmoniesNotes { get; set; }
        public string results { get; set; }
        public bool ShowAll;

        protected List<Harmony> Memory;

        public Expression Objective { get; set; }
        public bool Maximize { get; set; }

        protected virtual Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.notes = new double[TotalNotes];
            for (int i = 0; i < TotalNotes; i++)
                hrm.notes[i] = Randomizer.getRandomDouble(MinimumValues[i], MaximumValues[i]);

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
            for (int i = 0; i < Memory.Count; i++)
            {
                for (int j = i + 1; j < Memory.Count; j++)
                {
                    if (Maximize == true)
                    {
                        if (getHarmonyAesthetics(Memory[i]) < getHarmonyAesthetics(Memory[j]))
                        {
                            tempHar = Memory[i];
                            Memory[i] = Memory[j];
                            Memory[j] = tempHar;
                        }
                    }
                    else
                    {
                        if (Math.Abs(getHarmonyAesthetics(Memory[i])) > Math.Abs(getHarmonyAesthetics(Memory[j])))
                        {
                            tempHar = Memory[i];
                            Memory[i] = Memory[j];
                            Memory[j] = tempHar;
                        }
                    }
                }
            }
        }

        protected void updateMemory(Harmony newHar, int currentIteration)
        {
            if(Maximize == true)
            {
                if (getHarmonyAesthetics(newHar) > getHarmonyAesthetics(Memory[HMSize - 1]))
                {
                    Memory[HMSize - 1] = newHar;
                    sortMemory();
                }
            }
            else
            {
                if (Math.Abs(getHarmonyAesthetics(newHar)) < Math.Abs(getHarmonyAesthetics(Memory[HMSize - 1])))
                {
                    Memory[HMSize - 1] = newHar;
                    sortMemory();
                }
            }
        }

        protected double restrictNote(double note, int index)
        {
            if (note > MaximumValues[index])
                return MaximumValues[index];
            else if (note < MinimumValues[index])
                return MinimumValues[index];
            else
                return note;
        }

        public void writeResults(int currentImprovisation)
        {
            results += "--------------------------------------------------------------------------------------------";
            results += Environment.NewLine + "Improvisation Number: " + currentImprovisation + Environment.NewLine;
            results += "--------------------------------------------------------------------------------------------";
            for (int i = 0; i < HMSize; i++)
            {
                results += Environment.NewLine;
                results += i + " Harmony: ";
                results += Environment.NewLine;
                for (int j = 0; j < TotalNotes; j++)
                {
                    results += "\t";
                    results += "Note " + j + ": " + Memory[i].notes[j];
                }
                results += Environment.NewLine;
                results += "\t Aesthetics: " + getHarmonyAesthetics(Memory[i]);
                results += Environment.NewLine;
            }
            if (currentImprovisation == (NI - 1))
            {
                saveResultsToFile(results);
            }
        }

        private void saveResultsToFile(string results)
        {
            string path = @"Results.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                File.WriteAllText(path, results);
            }
            else
            {
                File.WriteAllText(path, results);
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
                    if(getHarmonyAesthetics(Memory[i]) == getHarmonyAesthetics(selectedHarmonies[k]))
                    {
                        harmonyExists = true;
                        break;
                    }
                }
                if (harmonyExists == true)
                    continue;
                selectedHarmonies.Add(Memory[i]);
                for (int j = i+1; j < HMSize; j++)
                {
                    if(getHarmonyAesthetics(Memory[i]) == getHarmonyAesthetics(Memory[j]))
                    {
                        duplicatesCounter++;
                    }
                }
            }
            return duplicatesCounter;
        }

    }
}
