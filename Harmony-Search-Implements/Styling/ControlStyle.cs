using System;
using System.Drawing;
using System.Windows.Forms;

namespace Harmony_Search_Implements.Styling
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

        public static void MessageBoxStyle(String message)
        {
            MessageBox.Show(message, "Harmony Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageBoxSuccessStyle(String message)
        {
            MessageBox.Show(message, "Harmony Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void TextBoxStyle(TextBox textBox, int number)
        {
            textBox.Size = new Size(400, 22);
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Font = new Font("Courier New", 10, FontStyle.Regular);
            if (textBox.Name.Contains("Min"))
            {
                textBox.Location = new Point(222, 100 + (50 * (number - 1)));
                textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            }
            if (textBox.Name.Contains("Max"))
            {
                textBox.Location = new Point(888, 100 + (50 * (number - 1)));
                textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            }
        }

        public static void ConfigurationLabelStyle(Label label, int number)
        {
            label.Text = "X" + number;
            label.Size = new Size(40, 20);
            label.ForeColor = Color.Black;
            label.Font = new Font("Courier New", 12, FontStyle.Bold);
            label.Visible = true;
            label.Location = new Point(150, 102 + (50 * (number - 1)));
        }

        public static void GraphsLabelStyle(Label label, int number)
        {
            label.Name = "x" + number + "Label";
            label.Text = "X" + number;
            label.Size = new Size(40, 20);
            label.ForeColor = Color.Black;
            label.Font = new Font("Courier New", 12, FontStyle.Bold);
            label.Visible = true;
            label.Location = new Point(275 + (400 * (number - 1)), 100);
        }

        public static void LabelStyle(Label label, double value)
        {
            label.Name = "aestheticsLabel";
            label.Text = "Aesthetics: " + value;
            label.Size = new Size(450, 18);
            label.ForeColor = Color.Black;
            label.Font = new Font("Courier New", 12, FontStyle.Regular);
            label.Visible = true;
            label.Location = new Point(15, 75);
        }

        public static void LabelStyle(Label label, int number, double value)
        {
            label.Name = "x" + number + "Label";
            label.Text = "X" + number + ": " + value;
            label.Size = new Size(308, 18);
            label.ForeColor = Color.Black;
            label.Font = new Font("Courier New", 12, FontStyle.Regular);
            label.Visible = true;
            label.Location = new Point(15, 105 + (30 * (number - 1)));
        }

      
    }
}
