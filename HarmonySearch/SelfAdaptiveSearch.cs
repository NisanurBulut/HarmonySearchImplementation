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
    public class SelfAdaptiveSearch
    {
        public double MinimumValue { get; set; }
        public double MaximumValue { get; set; }
        private List<double> MinVariables;
        private List<double> MaxVariables;
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }
        public int NI { get; set; } //Number of Improvisations
        public double HMCR { get; set; }
        public double PAR { get; set; }

        public double BW { get; set; }

        public string output { get; set; }
        public List<double> bestHarmonies = new List<double>();

        public SelfAdaptiveSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;
        private List<Harmony> memory = new List<Harmony>();

        private Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.note = new List<double>();
            for (int i = 0; i < TotalNotes; i++)
                hrm.note.Add(Statics.getRandomDouble(MinimumValue, MaximumValue));

            checkMaxVariables(hrm);
            checkMinVariables(hrm);
            return hrm;
        }

        public void initializeMemory()
        {
            //TODO:
            initializeExtremeVariables();
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
            //TODO: Must adjust based on the best and worst decision-variables
            float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= PAR)
            {
                randomFloat = Statics.getRandomFloat(-10.0f, 10.0f);
                if (randomFloat < 0)
                    newHarmony.note[index] += (MaxVariables[index] - newHarmony.note[index]) * Statics.getRandomDouble(0.0, 1.0);
                else if (randomFloat >= 0)
                    newHarmony.note[index] -= (newHarmony.note[index] - MinVariables[index] ) * Statics.getRandomDouble(0.0, 1.0);

                restrictNote(newHarmony.note[index]);
            }
        }

        private double restrictNote(double note)
        {
            if (note > MaximumValue)
                return MaximumValue;
            else if (note < MinimumValue)
                return MinimumValue;
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
                checkMaxVariables(newHar);
                checkMinVariables(newHar);
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

        private void checkMaxVariables(Harmony newHarmony)
        {
            for(int i = 0; i < TotalNotes; i++)
            {
                if (newHarmony.note[i] > MaxVariables[i])
                    MaxVariables[i] = newHarmony.note[i];
            }
        }

        private void checkMinVariables(Harmony newHarmony)
        {
            for (int i = 0; i < TotalNotes; i++)
            {
                if (newHarmony.note[i] < MinVariables[i])
                    MinVariables[i] = newHarmony.note[i];
            }
        }

        private void initializeExtremeVariables()
        {
            MinVariables = new List<double>();
            MaxVariables = new List<double>();
            for(int i=0; i<TotalNotes; i++)
            {
                MinVariables.Add(MaximumValue);
                MaxVariables.Add(MinimumValue);
            }
        }
    }
}
