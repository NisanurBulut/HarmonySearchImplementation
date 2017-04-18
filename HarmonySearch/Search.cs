using NCalc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonySearch
{
    public enum HarmonySearchVariant
    {
        Classic, Improved, GlobalBest, SelfAdaptive 
    }

    public enum OptimizationGoal
    {
        Max, Min, MinAbs
    }

    public abstract class Search
    {
        public int NI { get; set; } //Number of Improvisations
        public double[] MinimumValues { get; set; }
        public double[] MaximumValues { get; set; }
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }

        public double[] bestHarmoniesAesthetics { get; set; }
        public double[] newHarmoniesAesthetics { get; set; }
        public double[] worstHarmoniesAesthetics { get; set; }
        public double[,] bestHarmoniesNotes { get; set; }
        public StringBuilder Results { get; set; }
        public bool ShowAll { get; set; }

        protected Harmony[] Memory;

        public Expression Objective { get; set; }
        public OptimizationGoal Optimum { get; set; }

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
            for (int i = 0; i < Memory.Length; i++)
            {
                for (int j = i + 1; j < HMSize; j++)
                {
                    if (Optimum.Equals(OptimizationGoal.Max))
                    {
                        if (getHarmonyAesthetics(Memory[i]) < getHarmonyAesthetics(Memory[j]))
                        {
                            tempHar = Memory[i];
                            Memory[i] = Memory[j];
                            Memory[j] = tempHar;
                        }
                    }
                    if (Optimum.Equals(OptimizationGoal.Min))
                    {
                        if (getHarmonyAesthetics(Memory[i]) > getHarmonyAesthetics(Memory[j]))
                        {
                            tempHar = Memory[i];
                            Memory[i] = Memory[j];
                            Memory[j] = tempHar;
                        }
                    }
                    if (Optimum.Equals(OptimizationGoal.MinAbs))
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
            if (Optimum.Equals(OptimizationGoal.Max))
            {
                if (getHarmonyAesthetics(newHar) > getHarmonyAesthetics(Memory[HMSize - 1]))
                {
                    Memory[HMSize - 1] = newHar;
                    sortMemory();
                }
            }
            if (Optimum.Equals(OptimizationGoal.Min))
            {
                if (getHarmonyAesthetics(newHar) < getHarmonyAesthetics(Memory[HMSize - 1]))
                {
                    Memory[HMSize - 1] = newHar;
                    sortMemory();
                }
            }
            if (Optimum.Equals(OptimizationGoal.MinAbs))
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
            Results.Append("--------------------------------------------------------------------------------------------");
            Results.Append(Environment.NewLine + "Improvisation Number: " + currentImprovisation + Environment.NewLine);
            Results.Append("--------------------------------------------------------------------------------------------");
            for (int i = 0; i < HMSize; i++)
            {
                Results.Append(Environment.NewLine);
                Results.Append(i + " Harmony: ");
                //Results += Environment.NewLine;
                for (int j = 0; j < TotalNotes; j++)
                {
                    Results.Append("\t");
                    Results.Append("Note " + j + ": " + Math.Round(Memory[i].notes[j], 6));
                }
                //Results += Environment.NewLine;
                Results.Append("\t Aesthetics: " + Math.Round(getHarmonyAesthetics(Memory[i]), 9));
                //Results += Environment.NewLine;
            }
            Results.Append(Environment.NewLine);
            if (currentImprovisation == (NI - 1))
            {
                saveResultsToFile();
            }
        }

        private void saveResultsToFile()
        {
            string path = @"Results.txt";
            File.WriteAllText(path, Results.ToString());
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
