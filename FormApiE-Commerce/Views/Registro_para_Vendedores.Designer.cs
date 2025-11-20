namespace FormApiE_Commerce.Views
{
    partial class Registro_para_Vendedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_para_Vendedores));
            cuiGroupBox2 = new CuoreUI.Controls.cuiGroupBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            btnVendedor_aceptar = new CuoreUI.Controls.cuiButton();
            btnVendedor_rechazar = new CuoreUI.Controls.cuiButton();
            cuiGroupBox2.SuspendLayout();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cuiGroupBox2
            // 
            cuiGroupBox2.BorderColor = Color.DarkOliveGreen;
            cuiGroupBox2.Content = "Atencion";
            cuiGroupBox2.Controls.Add(cuiPanel2);
            cuiGroupBox2.Font = new Font("Garamond", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiGroupBox2.ForeColor = Color.Red;
            cuiGroupBox2.Location = new Point(12, 119);
            cuiGroupBox2.Name = "cuiGroupBox2";
            cuiGroupBox2.Padding = new Padding(10, 33, 15, 15);
            cuiGroupBox2.Rounding = new Padding(10, 10, 15, 15);
            cuiGroupBox2.Size = new Size(559, 444);
            cuiGroupBox2.TabIndex = 5;
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
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(cuiLabel2);
            cuiPanel1.Dock = DockStyle.Top;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(255, 128, 0);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(583, 79);
            cuiPanel1.TabIndex = 6;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Registro\\ para\\ Vendedores";
            cuiLabel2.Font = new Font("Garamond", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(26, 14);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(350, 60);
            cuiLabel2.TabIndex = 0;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = resources.GetString("cuiLabel3.Content");
            cuiLabel3.Font = new Font("Garamond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = SystemColors.Desktop;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(11, 181);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(516, 172);
            cuiLabel3.TabIndex = 1;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            cuiLabel3.Load += cuiLabel3_Load;
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
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Realmente\\ quieres\\ ser\\ vendedor\\?";
            cuiLabel4.Font = new Font("Garamond", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(13, 571);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(436, 44);
            cuiLabel4.TabIndex = 7;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
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
            btnVendedor_aceptar.Location = new Point(165, 643);
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
            btnVendedor_aceptar.TabIndex = 8;
            btnVendedor_aceptar.TextAlignment = StringAlignment.Center;
            btnVendedor_aceptar.TextOffset = new Point(0, 0);
            btnVendedor_aceptar.Click += btnVendedor_aceptar_Click;
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
            btnVendedor_rechazar.Location = new Point(362, 643);
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
            btnVendedor_rechazar.TabIndex = 9;
            btnVendedor_rechazar.TextAlignment = StringAlignment.Center;
            btnVendedor_rechazar.TextOffset = new Point(0, 0);
            btnVendedor_rechazar.Click += btnVendedor_rechazar_Click;
            // 
            // Registro_para_Vendedores
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 739);
            Controls.Add(btnVendedor_rechazar);
            Controls.Add(btnVendedor_aceptar);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiPanel1);
            Controls.Add(cuiGroupBox2);
            Font = new Font("Garamond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registro_para_Vendedores";
            cuiGroupBox2.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiGroupBox cuiGroupBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiButton btnVendedor_aceptar;
        private CuoreUI.Controls.cuiButton btnVendedor_rechazar;
    }
}