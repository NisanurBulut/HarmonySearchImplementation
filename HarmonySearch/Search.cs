using org.mariuszgromada.math.mxparser;
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
        public Expression Objective { get; set; }
        public Argument[] arguments {get; set;}
        public double MinimumValue { get; set; }
        public double MaximumValue { get; set; }
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }

        public double[] bestHarmonies { get; set; }
        public double[,] bestHarmoniesNotes { get; set; }
        public string output { get; set; }

        protected List<Harmony> memory;

        protected virtual Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.notes = new List<double>();
            for (int i = 0; i < TotalNotes; i++)
                hrm.notes.Add(Statics.getRandomDouble(MinimumValue, MaximumValue));

            return hrm;
        }

        protected double getHarmonyAesthetics(Harmony harmony)
        {
            double aesthetics = Math.Sin(harmony.notes[0]) * Math.Sin(harmony.notes[1]);
            //Argument[] args = new Argument[TotalNotes];
            //for (int i = 1; i <= TotalNotes; i++)
            //{
            //    args[i - 1] = new Argument("x" + i, harmony.notes[i-1]);
            //}
            //Objective.addArguments(args);
            //double aesthetics = Objective.calculate();

            return aesthetics;
        }

        protected void sortMemory()
        {
            Harmony tempHar = new Harmony();
            for (int i = 0; i < memory.Count; i++)
            {
                for (int j = i + 1; j < memory.Count; j++)
                {
                    if (getHarmonyAesthetics(memory[i]) < getHarmonyAesthetics(memory[j]))
                    {
                        tempHar = memory[i];
                        memory[i] = memory[j];
                        memory[j] = tempHar;
                    }
                }
            }
        }

        protected void updateMemory(Harmony newHar, int currentIteration)
        {
            if (getHarmonyAesthetics(newHar) > getHarmonyAesthetics(memory[HMSize - 1]))
            {
                memory[HMSize - 1] = newHar;
                sortMemory();
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
    }
}
