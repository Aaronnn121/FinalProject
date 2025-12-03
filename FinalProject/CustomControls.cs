using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FinalProject
{
    namespace FinalProject
    {
        // Custom rounded textbox control
        public class RoundedTextBox : TextBox
        {
            private Color _borderColor = Color.White;
            private int _borderSize = 1;
            private int _cornerRadius = 15;
            private string _placeholderText = "";

            public Color BorderColor
            {
                get { return _borderColor; }
                set { _borderColor = value; Invalidate(); }
            }

            public int BorderSize
            {
                get { return _borderSize; }
                set { _borderSize = value; Invalidate(); }
            }

            public int CornerRadius
            {
                get { return _cornerRadius; }
                set { _cornerRadius = value; Invalidate(); }
            }

            public string PlaceholderText
            {
                get { return _placeholderText; }
                set { _placeholderText = value; Invalidate(); }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw border
                using (Pen pen = new Pen(_borderColor, _borderSize))
                {
                    g.DrawPath(pen, GetRoundedRectPath(ClientRectangle, _cornerRadius));
                }

                // Draw placeholder text if needed
                if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(_placeholderText))
                {
                    TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
                    TextRenderer.DrawText(g, _placeholderText, new Font(Font.FontFamily, Font.Size, FontStyle.Italic),
                        new Rectangle(5, 0, Width - 10, Height), Color.Gray, flags);
                }
            }

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                Region = new Region(GetRoundedRectPath(ClientRectangle, _cornerRadius));
            }

            private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
            {
                GraphicsPath path = new GraphicsPath();

                int diameter = radius * 2;
                Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

                // Top left corner
                path.AddArc(arc, 180, 90);

                // Top right corner
                arc.X = rect.Right - diameter;
                path.AddArc(arc, 270, 90);

                // Bottom right corner
                arc.Y = rect.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // Bottom left corner
                arc.X = rect.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();
                return path;
            }
        }

        // Custom rounded button control
        public class RoundedButton : Button
        {
            private int _cornerRadius = 20;

            public int CornerRadius
            {
                get { return _cornerRadius; }
                set { _cornerRadius = value; Invalidate(); }
            }

            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);

                Graphics g = pevent.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, Width, Height);
                GraphicsPath path = GetRoundedRectPath(rect, _cornerRadius);

                this.Region = new Region(path);

                using (Pen pen = new Pen(BackColor, 0))
                {
                    g.DrawPath(pen, path);
                }
            }

            private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
            {
                GraphicsPath path = new GraphicsPath();

                int diameter = radius * 2;
                Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

                // Top left corner
                path.AddArc(arc, 180, 90);

                // Top right corner
                arc.X = rect.Right - diameter;
                path.AddArc(arc, 270, 90);

                // Bottom right corner
                arc.Y = rect.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // Bottom left corner
                arc.X = rect.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();
                return path;
            }
        }
    }
}