using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject.Helpers
{
    public static class Prompt
    {
        /// <summary>
        /// Shows a small dialog with a NumericUpDown and returns the entered decimal, or null if cancelled.
        /// </summary>
        public static decimal? ShowDecimal(string text, string caption)
        {
            using var prompt = new Form()
            {
                Width = 360,
                Height = 170,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false,
                ShowIcon = false
            };

            var lbl = new Label() { Left = 12, Top = 12, Text = text, AutoSize = true };
            var num = new NumericUpDown()
            {
                Left = 12,
                Top = 40,
                Width = 320,
                DecimalPlaces = 2,
                Maximum = 1000000000m,
                Minimum = 0m,
                Value = 0m,
                ThousandsSeparator = true
            };

            var ok = new Button() { Text = "OK", Left = 170, Width = 75, Top = 80, DialogResult = DialogResult.OK };
            var cancel = new Button() { Text = "Cancel", Left = 255, Width = 75, Top = 80, DialogResult = DialogResult.Cancel };

            prompt.Controls.Add(lbl);
            prompt.Controls.Add(num);
            prompt.Controls.Add(ok);
            prompt.Controls.Add(cancel);

            prompt.AcceptButton = ok;
            prompt.CancelButton = cancel;

            var result = prompt.ShowDialog();
            return result == DialogResult.OK ? num.Value : (decimal?)null;
        }
    }
}