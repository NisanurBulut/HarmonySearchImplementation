using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonySearch
{
    public static class ControlStyle
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

        public static void TextBoxStyle(TextBox textBox, int line)
        {
            textBox.Size = new Size(250, 22);
            textBox.TextAlign = HorizontalAlignment.Center;
            if(textBox.Name.Contains("Min"))
            {
                textBox.Location = new Point(222, 100 + (50 * (line - 1)));
                textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            }
            if(textBox.Name.Contains("Max"))
            {
                textBox.Location = new Point(567, 100 + (50 * (line - 1)));
                textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            }
        }

        public static void LabelStyle(Label label, int line)
        {
            label.Text = "X" + line;
            label.Size = new Size(35, 20);
            label.ForeColor = Color.Black;
            label.Font = new Font("Courier New", 12, FontStyle.Bold);
            label.Visible = true;
            label.Location = new Point(150, 102 + (50 * (line - 1)));
        }
    }
}
