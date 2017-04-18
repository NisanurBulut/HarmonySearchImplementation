using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySearch
{
    public class Parameters
    {
        public string Objective { get; set; }
        public bool ShowAll { get; set; }
        public OptimizationGoal Optimum { get; set; }
        public double[] MaxValues { get; set; }
        public double[] MinValues { get; set; }
        public HarmonySearchVariant Variant { get; set; }
        public int NI { get; set; }
        public int HMS { get; set; }
        public double HMCR { get; set; }
        public double PAR { get; set; }
        public double BW { get; set; }
        public double PARmin { get; set; }
        public double PARmax { get; set; }
        public double BWmin { get; set; }
        public double BWmax { get; set; }
    }
}
