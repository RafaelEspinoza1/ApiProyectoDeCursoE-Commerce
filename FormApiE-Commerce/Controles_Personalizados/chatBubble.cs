using System;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.Controles_Personalizados
{
    public class ChatBubble : Panel
    {
        public ChatBubble(string mensaje, bool enviado)
        {
            this.AutoSize = true;
            this.MaximumSize = new Size(300, 0);
            this.Padding = new Padding(10);
            this.Margin = new Padding(5);

            Label texto = new Label();
            texto.Text = mensaje;
            texto.MaximumSize = new Size(280, 0);
            texto.AutoSize = true;
            texto.Font = new Font("Segoe UI", 10);

            if (enviado)
            {
                this.BackColor = Color.FromArgb(189, 236, 182); // verde WhatsApp
                this.Anchor = AnchorStyles.Right;
            }
            else
            {
                this.BackColor = Color.FromArgb(230, 230, 230); // gris claro
                this.Anchor = AnchorStyles.Left;
            }

            this.Controls.Add(texto);
            this.Paint += Bubble_Paint;
        }

        private void Bubble_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            int radius = 20;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                    e.Graphics.FillPath(brush, path);
            }
        }
    }
}
