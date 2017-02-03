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

        public ImprovedSearch()
        {
            initializeMemory();
        }

        //List<double> harmony = new List<double>(TotalVars);
        //int randomIntNumber = 0;

        public void initializeMemory()
        {
            base.bestHarmonies = new double[NI];
            base.bestHarmoniesNotes = new double[NI, TotalNotes];
            memory = new List<Harmony>();
            for (int i = 0; i < HMSize; i++)
                memory.Add(getRandomHarmony());

            sortMemory();
        }

        public void Run(bool showAll)
        {
            for (int currentImprovisation = 0; currentImprovisation < NI; currentImprovisation++)
            {
                Harmony newHarmony = new Harmony();
                newHarmony.notes = new double[TotalNotes];
                for (int currentNote = 0; currentNote < TotalNotes; currentNote++)
                {
                    float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
                    if (randomFloat <= HMCR)
                    {
                        int randomHarmony = Convert.ToInt32(Statics.getRandomDouble(0, HMSize - 1));
                        newHarmony.notes[currentNote] = memory[randomHarmony].notes[currentNote];
                        adjustPitch(newHarmony, currentNote, currentImprovisation);
                    }
                    else
                    {
                        newHarmony.notes[currentNote] = Statics.getRandomDouble(MinimumValue, MaximumValue);
                    }
                }
                updateMemory(newHarmony, currentImprovisation);
                //if (currentImprovisation == 249)
                //{
                //    countDuplicates();
                //}
                base.bestHarmonies[currentImprovisation] = getHarmonyAesthetics(memory[0]);
                for (int i = 0; i < TotalNotes; i++)
                {
                    base.bestHarmoniesNotes[currentImprovisation, i] = memory[0].notes.ElementAt(i);
                }
                if (showAll == true)
                    base.writeResults(currentImprovisation);
            }
        }

        private void adjustPitch(Harmony newHarmony, int index, int currentImprovisation)
        {
            float randomFloat = Statics.getRandomFloat(0.0f, 1.0f);
            if (randomFloat <= getPAR(currentImprovisation))
            {
                randomFloat = Statics.getRandomFloat(-10.0f, 10.0f);
                if (randomFloat < 0)
                {
                    newHarmony.notes[index] += Statics.getRandomDouble(0, getBandwidth(currentImprovisation));
                    newHarmony.notes[index] = restrictNote(newHarmony.notes[index]);
                }
                else if (randomFloat >= 0)
                {
                    newHarmony.notes[index] -= Statics.getRandomDouble(0, getBandwidth(currentImprovisation));
                    newHarmony.notes[index] = restrictNote(newHarmony.notes[index]);
                }
            }
        }

        private float getPAR(int currentImprovisation)
        {
            float newPAR = PARmin + ((PARmax - PARmin) / NI) * currentImprovisation;
            return newPAR;
        }

        private double getBandwidth(int currentImprovisation)
        {
            double c = Math.Log(BWmin / BWmax) * (1/NI);
            double newBW = BWmax * Math.Exp(c * currentImprovisation);
            //double newBW = BWmin + ((BWmax - BWmin) / NI) * currentImprovisation;
            return newBW;
        }
    }
}
