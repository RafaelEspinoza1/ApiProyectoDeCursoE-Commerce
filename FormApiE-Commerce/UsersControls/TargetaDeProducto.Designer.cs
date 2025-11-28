namespace FormApiE_Commerce.UsersControls
{
    partial class TargetaDeProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            lblEstado = new CuoreUI.Controls.cuiLabel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            lblPrecio = new CuoreUI.Controls.cuiLabel();
            lblNombre = new CuoreUI.Controls.cuiLabel();
            picImagen = new CuoreUI.Controls.cuiPictureBox();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(lblEstado);
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(lblPrecio);
            cuiPanel1.Controls.Add(lblNombre);
            cuiPanel1.Dock = DockStyle.Bottom;
            cuiPanel1.Location = new Point(0, 210);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(273, 175);
            cuiPanel1.TabIndex = 0;
            // 
            // lblEstado
            // 
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Content = "\\(Estado\\)";
            lblEstado.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Black;
            lblEstado.HorizontalAlignment = StringAlignment.Near;
            lblEstado.Location = new Point(15, 83);
            lblEstado.Margin = new Padding(5);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 29);
            lblEstado.TabIndex = 3;
            lblEstado.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Ver mas...";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.Black;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(15, 120);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Gainsboro;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 2F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(243, 43);
            cuiButton1.TabIndex = 2;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // lblPrecio
            // 
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Content = "\\(Precio\\)";
            lblPrecio.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.HorizontalAlignment = StringAlignment.Near;
            lblPrecio.Location = new Point(178, 45);
            lblPrecio.Margin = new Padding(5);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(72, 29);
            lblPrecio.TabIndex = 1;
            lblPrecio.VerticalAlignment = StringAlignment.Near;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Content = "\\(nombre\\)";
            lblNombre.Font = new Font("Garamond", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.HorizontalAlignment = StringAlignment.Near;
            lblNombre.Location = new Point(15, 5);
            lblNombre.Margin = new Padding(5);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(173, 29);
            lblNombre.TabIndex = 0;
            lblNombre.VerticalAlignment = StringAlignment.Near;
            // 
            // picImagen
            // 
            picImagen.BackgroundImageLayout = ImageLayout.Stretch;
            picImagen.Content = null;
            picImagen.Dock = DockStyle.Fill;
            picImagen.ImageTint = Color.White;
            picImagen.ImeMode = ImeMode.NoControl;
            picImagen.Location = new Point(0, 0);
            picImagen.Margin = new Padding(5);
            picImagen.Name = "picImagen";
            picImagen.OutlineThickness = 1F;
            picImagen.PanelOutlineColor = Color.Empty;
            picImagen.Rotation = 0;
            picImagen.Rounding = new Padding(8);
            picImagen.Size = new Size(273, 210);
            picImagen.TabIndex = 1;
            // 
            // TargetaDeProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picImagen);
            Controls.Add(cuiPanel1);
            Name = "TargetaDeProducto";
            Size = new Size(273, 385);
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel lblNombre;
        private CuoreUI.Controls.cuiPictureBox picImagen;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiLabel lblPrecio;
        private CuoreUI.Controls.cuiLabel lblEstado;
    }
}
