using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
              //  Memory[i] = getRandomHarmony();
            }
           // sortMemory();
        }
    }
}
