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
    public class ImprovedSearch
    {
        public double MinimumNote { get; set; }
        public double MaximumNote { get; set; }
        public int TotalNotes { get; set; }
        public int HMSize { get; set; }
        public int NI { get; set; } //Number of Improvisations
        public float HMCR { get; set; }

        public float PARmin { get; set; }
        public float PARmax { get; set; }
        public double BWmin { get; set; }
        public double BWmax { get; set; }
        
        private string output = "";
        public List<double> bestHarmonies = new List<double>();

        public ImprovedSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;
        List<Harmony> memory = new List<Harmony>();

        private Harmony getRandomHarmony()
        {
            Harmony hrm = new Harmony();
            hrm.note = new List<double>();
            for (int i = 0; i < TotalNotes; i++)
                hrm.note.Add(Statics.getRandomDouble(MinimumNote, MaximumNote));

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
            double aesthetics = 100*(harmony.note[1] - Math.Pow(harmony.note[0], 2)) + Math.Pow(1 - harmony.note[0], 2); //Rosenbrock Function

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
                        adjustPitch(newHarmony, currentNote, currentImprovisation);
                    }
                    else
                    {
                        newHarmony.note.Add(Statics.getRandomDouble(MinimumNote, MaximumNote));
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
                    newHarmony.note[index] += Statics.getRandomDouble(0, getBandwidth(currentImprovisation));
                    restrictNote(newHarmony.note[index]);
                }
                else if (randomFloat >= 0)
                {
                    newHarmony.note[index] -= Statics.getRandomDouble(0, getBandwidth(currentImprovisation));
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
            //int duplicatesCount = 0;
            if (Math.Abs(getHarmonyAesthetics(newHar)) < Math.Abs(getHarmonyAesthetics(memory[HMSize - 1])))
            {
                memory[HMSize - 1] = newHar;
                sortMemory();
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
                    output += "Note " + j + ": " + memory.ElementAt(i).note[j];
                }
                output += "\n\t Aesthetics: " + getHarmonyAesthetics(memory[i]);
                output += "\n";
            }
        }
    }
}
