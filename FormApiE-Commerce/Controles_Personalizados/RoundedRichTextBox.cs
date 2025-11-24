using System;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.Controles_Personalizados
{
    public class RoundedRichTextBox : RichTextBox
    {
        public int BorderRadius { get; set; } = 18;
        public Color BorderColor { get; set; } = Color.Gray;
        public int BorderSize { get; set; } = 1;

        public RoundedRichTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.White;
            this.Padding = new Padding(8);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = GetRoundedPath())
            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedPath()
        {
            Rectangle r = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            int radius = BorderRadius;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(r.X, r.Y, radius, radius, 180, 90);
            path.AddArc(r.Right - radius, r.Y, radius, radius, 270, 90);
            path.AddArc(r.Right - radius, r.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(r.X, r.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
