using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySearch
{
    public class Search
    {
        public double MinimumValue { get; set; }
        public double MaximumValue { get; set; }
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }
        public int NI { get; set; } //Number of Improvisations

        protected List<Harmony> memory;

        protected virtual Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.note = new List<double>();
            for (int i = 0; i < TotalNotes; i++)
                hrm.note.Add(Statics.getRandomDouble(MinimumValue, MaximumValue));

            return hrm;
        }

        protected double getHarmonyAesthetics(Harmony harmony)
        {
            //double aesthetics = Math.Sin(harmony.note[0]) + Math.Cos(harmony.note[1]) + Math.Sin(harmony.note[2]) + Math.Cos(harmony.note[3]) + Math.Sin(harmony.note[4]);
            double aesthetics = 100 * (harmony.note[1] - Math.Pow(harmony.note[0], 2)) + Math.Pow(1 - harmony.note[0], 2); //Rosenbrock Function

            //double aesthetics = Math.Pow(harmony.note[0], 2) + Math.Pow(harmony.note[1], 2);// + Math.Pow(harmony.note[2], 2) + Math.Pow(harmony.note[3], 2) + Math.Pow(harmony.note[4], 2); //Sphere Function

            return aesthetics;
        }

        protected void sortMemory()
        {
            Harmony tempHar = new Harmony();
            for (int i = 0; i < memory.Count; i++)
            {
                for (int j = i + 1; j < memory.Count; j++)
                {
                    if (Math.Abs(getHarmonyAesthetics(memory[i])) > Math.Abs(getHarmonyAesthetics(memory[j])))
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
            if (Math.Abs(getHarmonyAesthetics(newHar)) < Math.Abs(getHarmonyAesthetics(memory[HMSize - 1])))
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
