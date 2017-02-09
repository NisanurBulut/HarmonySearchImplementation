using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonySearch
{
    public static class ProgressBarStyle
    {
        public static void SetProgressBarText(ProgressBar Target, string Text, ProgressBarTextLocation Location, Color TextColor, Font TextFont)
        {
            if (Target == null)
            {
                throw new ArgumentException("Null Target");
            }
            if (string.IsNullOrEmpty(Text))
            {
                int percent = (int)(((double)(Target.Value - Target.Minimum) / (double)(Target.Maximum - Target.Minimum)) * 100);
                Text = percent.ToString() + "%";
            }
            using (Graphics gr = Target.CreateGraphics())
            {
                gr.DrawString(Text, TextFont, new SolidBrush(TextColor),
                    new PointF(Location == ProgressBarTextLocation.Left ? 5 : Target.Width / 2 - (gr.MeasureString(Text, TextFont).Width / 2.0F),
                        Target.Height / 2 - (gr.MeasureString(Text, TextFont).Height / 2.0F)));
            }
        }

        public enum ProgressBarTextLocation
        {
            Left, Centered
        }
    }
}
