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
    public class ClassicSearch
    {
        public double MinimumNote { get; set; }
        public double MaximumNote { get; set; }
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }
        public int NI { get; set; } //Number of Improvisations
        public double HMCR { get; set; }
        public double PAR { get; set; }

        public double BW { get; set; }

        public string output { get; set; }
        public List<double> bestHarmonies = new List<double>();

        public ClassicSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;
        private List<Harmony> memory = new List<Harmony>();

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        //public static int getRandomInteger(int min, int max)
        //{
        //    lock (syncLock)
        //    {
        //        return random.Next(min, max);
        //    }
        //}
        public static double getRandomDouble(double min, double max)
        {
            lock (syncLock)
            {
                return random.NextDouble() * (max - min) + min;
            }
        }

        public static float getRandomFloat(float min, float max)
        {
            lock (syncLock)
            {
                return (float) random.NextDouble() * (max - min) + min;
            }
        }

        private Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.note = new List<double>();
            for (int i = 0; i < TotalNotes; i++)
                hrm.note.Add(getRandomDouble(MinimumNote, MaximumNote));

            return hrm;
        }

        public void initializeMemory()
        {
            for (int i = 0; i < HMSize; i++)
                memory.Add(getRandomHarmony());

            sortMemory();
        }

        private double getHarmonyAesthetics(Harmony harmony)
        {
            //double aesthetics = Math.Sin(harmony.note[0]) + Math.Cos(harmony.note[1]) + Math.Sin(harmony.note[2]) + Math.Cos(harmony.note[3]) + Math.Sin(harmony.note[4]);
            double aesthetics = 100 * (harmony.note[1] - Math.Pow(harmony.note[0], 2)) + Math.Pow(1 - harmony.note[0], 2); //Rosenbrock Function

            //double aesthetics = Math.Pow(harmony.note[0], 2) + Math.Pow(harmony.note[1], 2);// + Math.Pow(harmony.note[2], 2) + Math.Pow(harmony.note[3], 2) + Math.Pow(harmony.note[4], 2); //Sphere Function

            return aesthetics;
        }

        public void Run()
        {
            for (int currentImprovisation = 0; currentImprovisation < NI; currentImprovisation++)
            {
                Harmony newHarmony = new Harmony();
                newHarmony.note = new List<double>();
                for (int currentNote = 0; currentNote < TotalNotes; currentNote++)
                {
                    float randomFloat = getRandomFloat(0.0f, 1.0f);
                    if (randomFloat <= HMCR)
                    {
                        Debug.WriteLine("HMCR");
                        int randomHarmony = Convert.ToInt32(getRandomDouble(0, HMSize - 1));
                        newHarmony.note.Add(memory[randomHarmony].note[currentNote]);
                        adjustPitch(newHarmony, currentNote);
                    }
                    else
                    {
                        newHarmony.note.Add(getRandomDouble(MinimumNote, MaximumNote));
                    }
                }
                updateMemory(newHarmony, currentImprovisation);
                bestHarmonies.Add(getHarmonyAesthetics(memory[0]));
                //writeResults(currentImprovisation);
            }
        }

        private void adjustPitch(Harmony newHarmony, int index)
        {
            float randomFloat = getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= PAR)
            {
                Debug.WriteLine("PAR");
                if (getRandomDouble(-10.0, 10.0) < 0)
                {
                    newHarmony.note[index] += getRandomDouble(0, BW);
                    restrictNote(newHarmony.note[index]);
                }
                else if (getRandomDouble(-10.0, 10.0) >= 0)
                {
                    newHarmony.note[index] -= getRandomDouble(0, BW);
                    restrictNote(newHarmony.note[index]);
                }
            }
        }

        private double restrictNote(double note)
        {
            if (note > MaximumNote)
                return MaximumNote;
            else if (note < MinimumNote)
                return MinimumNote;
            else
                return note;
        }

        private void sortMemory()
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

        private void updateMemory(Harmony newHar, int currentIteration)
        {
            if (Math.Abs(getHarmonyAesthetics(newHar)) < Math.Abs(getHarmonyAesthetics(memory[HMSize - 1])))
            {
                memory[HMSize - 1] = newHar;
                sortMemory();
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
                    output += "Note " + j + ": " + memory.ElementAt(i).note[j];
                }
                output += "\n\t Aesthetics: " + getHarmonyAesthetics(memory[i]);
                output += "\n";
            }
        }
    }
}
