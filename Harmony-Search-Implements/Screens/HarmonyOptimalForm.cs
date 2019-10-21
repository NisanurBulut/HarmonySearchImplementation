using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harmony_Search_Implements.SearchingProcess;

namespace Harmony_Search_Implements.Screens
{
    public partial class HarmonyOptimalForm : Form
    {
        public bool ShowAll { get; set; }
        private int totalNotes;
        public bool activationFlag;
        private bool isBackButtonPressed = false;

        public ClassicSearch classicHS { get; set; }
      

        public ConfigForm Configuration { get; set; }

        private List<double> results = new List<double>();

        public HarmonyOptimalForm()
        {
            InitializeComponent();
        }

       
    }
}
