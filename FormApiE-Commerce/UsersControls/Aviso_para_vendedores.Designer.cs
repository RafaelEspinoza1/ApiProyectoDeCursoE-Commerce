namespace FormApiE_Commerce.UsersControls
{
    partial class Aviso_para_vendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aviso_para_vendedores));
            GrbxAviso = new CuoreUI.Controls.cuiGroupBox();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            btnVendedor_rechazar = new CuoreUI.Controls.cuiButton();
            btnVendedor_aceptar = new CuoreUI.Controls.cuiButton();
            GrbxAviso.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // GrbxAviso
            // 
            GrbxAviso.BackColor = SystemColors.Control;
            GrbxAviso.BorderColor = Color.DarkOliveGreen;
            GrbxAviso.Content = "Atencion";
            GrbxAviso.Controls.Add(cuiPanel2);
            GrbxAviso.Font = new Font("Garamond", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrbxAviso.ForeColor = Color.Red;
            GrbxAviso.Location = new Point(29, 28);
            GrbxAviso.Name = "GrbxAviso";
            GrbxAviso.Padding = new Padding(10, 33, 15, 15);
            GrbxAviso.Rounding = new Padding(10, 10, 15, 15);
            GrbxAviso.Size = new Size(559, 444);
            GrbxAviso.TabIndex = 10;
            GrbxAviso.Visible = false;
            // 
            // cuiPanel2
            // 
            cuiPanel2.AutoScroll = true;
            cuiPanel2.Controls.Add(cuiLabel3);
            cuiPanel2.Controls.Add(cuiLabel1);
            cuiPanel2.Location = new Point(14, 36);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = SystemColors.Control;
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(535, 381);
            cuiPanel2.TabIndex = 1;
            cuiPanel2.Visible = false;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = resources.GetString("cuiLabel3.Content");
            cuiLabel3.Font = new Font("Garamond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.Black;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(9, 181);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(516, 195);
            cuiLabel3.TabIndex = 1;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = resources.GetString("cuiLabel1.Content");
            cuiLabel1.ForeColor = Color.Black;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(11, 5);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(516, 185);
            cuiLabel1.TabIndex = 0;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Realmente\\ quieres\\ ser\\ vendedor\\?";
            cuiLabel4.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(30, 511);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(436, 44);
            cuiLabel4.TabIndex = 11;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            cuiLabel4.Visible = false;
            // 
            // btnVendedor_rechazar
            // 
            btnVendedor_rechazar.CheckButton = false;
            btnVendedor_rechazar.Checked = false;
            btnVendedor_rechazar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnVendedor_rechazar.CheckedForeColor = Color.White;
            btnVendedor_rechazar.CheckedImageTint = Color.White;
            btnVendedor_rechazar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnVendedor_rechazar.Content = "No";
            btnVendedor_rechazar.DialogResult = DialogResult.None;
            btnVendedor_rechazar.Font = new Font("Garamond", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVendedor_rechazar.ForeColor = SystemColors.Control;
            btnVendedor_rechazar.HoverBackground = Color.White;
            btnVendedor_rechazar.HoverForeColor = Color.Black;
            btnVendedor_rechazar.HoverImageTint = Color.White;
            btnVendedor_rechazar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnVendedor_rechazar.Image = null;
            btnVendedor_rechazar.ImageAutoCenter = true;
            btnVendedor_rechazar.ImageExpand = new Point(0, 0);
            btnVendedor_rechazar.ImageOffset = new Point(0, 0);
            btnVendedor_rechazar.Location = new Point(379, 583);
            btnVendedor_rechazar.Name = "btnVendedor_rechazar";
            btnVendedor_rechazar.NormalBackground = Color.OliveDrab;
            btnVendedor_rechazar.NormalForeColor = SystemColors.Control;
            btnVendedor_rechazar.NormalImageTint = Color.White;
            btnVendedor_rechazar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnVendedor_rechazar.OutlineThickness = 1F;
            btnVendedor_rechazar.PressedBackground = Color.WhiteSmoke;
            btnVendedor_rechazar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnVendedor_rechazar.PressedImageTint = Color.White;
            btnVendedor_rechazar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnVendedor_rechazar.Rounding = new Padding(8);
            btnVendedor_rechazar.Size = new Size(191, 56);
            btnVendedor_rechazar.TabIndex = 13;
            btnVendedor_rechazar.TextAlignment = StringAlignment.Center;
            btnVendedor_rechazar.TextOffset = new Point(0, 0);
            btnVendedor_rechazar.Visible = false;
            // 
            // btnVendedor_aceptar
            // 
            btnVendedor_aceptar.CheckButton = false;
            btnVendedor_aceptar.Checked = false;
            btnVendedor_aceptar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnVendedor_aceptar.CheckedForeColor = Color.White;
            btnVendedor_aceptar.CheckedImageTint = Color.White;
            btnVendedor_aceptar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnVendedor_aceptar.Content = "Si";
            btnVendedor_aceptar.DialogResult = DialogResult.None;
            btnVendedor_aceptar.Font = new Font("Garamond", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVendedor_aceptar.ForeColor = SystemColors.Control;
            btnVendedor_aceptar.HoverBackground = Color.White;
            btnVendedor_aceptar.HoverForeColor = Color.Black;
            btnVendedor_aceptar.HoverImageTint = Color.White;
            btnVendedor_aceptar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnVendedor_aceptar.Image = null;
            btnVendedor_aceptar.ImageAutoCenter = true;
            btnVendedor_aceptar.ImageExpand = new Point(0, 0);
            btnVendedor_aceptar.ImageOffset = new Point(0, 0);
            btnVendedor_aceptar.Location = new Point(182, 583);
            btnVendedor_aceptar.Name = "btnVendedor_aceptar";
            btnVendedor_aceptar.NormalBackground = Color.FromArgb(128, 64, 0);
            btnVendedor_aceptar.NormalForeColor = SystemColors.Control;
            btnVendedor_aceptar.NormalImageTint = Color.White;
            btnVendedor_aceptar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnVendedor_aceptar.OutlineThickness = 1F;
            btnVendedor_aceptar.PressedBackground = Color.WhiteSmoke;
            btnVendedor_aceptar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnVendedor_aceptar.PressedImageTint = Color.White;
            btnVendedor_aceptar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnVendedor_aceptar.Rounding = new Padding(8);
            btnVendedor_aceptar.Size = new Size(191, 56);
            btnVendedor_aceptar.TabIndex = 12;
            btnVendedor_aceptar.TextAlignment = StringAlignment.Center;
            btnVendedor_aceptar.TextOffset = new Point(0, 0);
            btnVendedor_aceptar.Visible = false;
            // 
            // Aviso_para_vendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GrbxAviso);
            Controls.Add(cuiLabel4);
            Controls.Add(btnVendedor_rechazar);
            Controls.Add(btnVendedor_aceptar);
            Name = "Aviso_para_vendedores";
            Size = new Size(617, 667);
            GrbxAviso.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiGroupBox GrbxAviso;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiButton btnVendedor_rechazar;
        private CuoreUI.Controls.cuiButton btnVendedor_aceptar;
    }
}
