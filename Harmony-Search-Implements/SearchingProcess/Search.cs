using Harmony_Search_Implements.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc;

namespace Harmony_Search_Implements.SearchingProcess
{
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

    }
}
