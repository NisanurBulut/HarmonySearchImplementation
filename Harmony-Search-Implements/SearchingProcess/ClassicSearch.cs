using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony_Search_Implements.Enums;

namespace Harmony_Search_Implements.SearchingProcess
{
  public  class ClassicSearch:Search
    {
        public float HMCR { get; set; }//Harmoni dikate alma oranı
        public float PAR { get; set; }//ton ayarlama oranı
        public double BW { get; set; }//Bant genişliği

        private static ClassicSearch instance = null;
        private ClassicSearch()
        {
            initializeMemory();
        }

        public static ClassicSearch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClassicSearch();
                }
                return instance;
            }
        }
        public void initializeMemory()
        {
            Results = new StringBuilder();
            //defaultPAR = PAR;
            //diversityIteration = 50;
            //diversityAdjustments = 0;
            base.bestHarmoniesAesthetics = new double[NI];//en estetik besteyi tutar
            base.newHarmoniesAesthetics = new double[NI];//yeni beste
            base.worstHarmoniesAesthetics = new double[NI];//kötü beste
            base.bestHarmoniesNotes = new double[NI, TotalNotes];//en iyi bestenin notaları
            base.Memory = new Harmony[HMSize];//hafızayı tazele
            for (int i = 0; i < HMSize; i++)
            {
                Memory[i] = getRandomHarmony();
            }
            sortMemory();
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
        protected double getHarmonyAesthetics(Harmony harmony)
        {
            int j = 0;
            for (int i = 0; i < TotalNotes; i++)
            {
                j = i + 1;
                Objective.Parameters["x" + j] = harmony.notes[i];
            }
            var returnValue= (double)Objective.Evaluate();
            return returnValue;
        }
    }
}
