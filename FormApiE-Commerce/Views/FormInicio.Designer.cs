namespace FormApiE_Commerce
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            toolTip1 = new ToolTip(components);
            splCon_Separador = new SplitContainer();
            cuiButton3 = new CuoreUI.Controls.cuiButton();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiGroupBox2 = new CuoreUI.Controls.cuiGroupBox();
            txtContraseña = new CuoreUI.Controls.cuiTextBox();
            cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            txtCorreo = new CuoreUI.Controls.cuiTextBox();
            cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            btnRegistrar = new CuoreUI.Controls.cuiButton();
            btnLogin = new CuoreUI.Controls.cuiButton();
            cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            cuiFileDropper2 = new CuoreUI.Controls.cuiFileDropper();
            ((System.ComponentModel.ISupportInitialize)splCon_Separador).BeginInit();
            splCon_Separador.Panel1.SuspendLayout();
            splCon_Separador.Panel2.SuspendLayout();
            splCon_Separador.SuspendLayout();
            cuiGroupBox2.SuspendLayout();
            cuiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splCon_Separador
            // 
            splCon_Separador.Dock = DockStyle.Fill;
            splCon_Separador.Location = new Point(0, 0);
            splCon_Separador.Name = "splCon_Separador";
            // 
            // splCon_Separador.Panel1
            // 
            splCon_Separador.Panel1.Controls.Add(cuiButton3);
            splCon_Separador.Panel1.Controls.Add(cuiLabel2);
            splCon_Separador.Panel1.Controls.Add(cuiGroupBox2);
            splCon_Separador.Panel1.Controls.Add(cuiGroupBox1);
            splCon_Separador.Panel1.Controls.Add(cuiPictureBox2);
            splCon_Separador.Panel1.Controls.Add(cuiLabel1);
            splCon_Separador.Panel1.Controls.Add(btnRegistrar);
            splCon_Separador.Panel1.Controls.Add(btnLogin);
            splCon_Separador.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splCon_Separador.Panel2
            // 
            splCon_Separador.Panel2.BackColor = Color.Chocolate;
            splCon_Separador.Panel2.Controls.Add(cuiPictureBox3);
            splCon_Separador.Panel2.Controls.Add(cuiFileDropper2);
            splCon_Separador.Size = new Size(816, 556);
            splCon_Separador.SplitterDistance = 354;
            splCon_Separador.TabIndex = 3;
            // 
            // cuiButton3
            // 
            cuiButton3.BackColor = SystemColors.Control;
            cuiButton3.CheckButton = false;
            cuiButton3.Checked = false;
            cuiButton3.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton3.CheckedForeColor = Color.White;
            cuiButton3.CheckedImageTint = Color.White;
            cuiButton3.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton3.Content = "Developers";
            cuiButton3.DialogResult = DialogResult.None;
            cuiButton3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiButton3.ForeColor = Color.Black;
            cuiButton3.HoverBackground = Color.DarkGray;
            cuiButton3.HoverForeColor = Color.Black;
            cuiButton3.HoverImageTint = Color.White;
            cuiButton3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton3.Image = null;
            cuiButton3.ImageAutoCenter = true;
            cuiButton3.ImageExpand = new Point(0, 0);
            cuiButton3.ImageOffset = new Point(0, 0);
            cuiButton3.Location = new Point(175, 440);
            cuiButton3.Margin = new Padding(3, 2, 3, 2);
            cuiButton3.Name = "cuiButton3";
            cuiButton3.NormalBackground = Color.DarkGray;
            cuiButton3.NormalForeColor = Color.Black;
            cuiButton3.NormalImageTint = Color.White;
            cuiButton3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.OutlineThickness = 1F;
            cuiButton3.PressedBackground = Color.WhiteSmoke;
            cuiButton3.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedImageTint = Color.White;
            cuiButton3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.Rounding = new Padding(8);
            cuiButton3.Size = new Size(118, 25);
            cuiButton3.TabIndex = 15;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextOffset = new Point(0, 0);
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Contactanos\\ aqui:";
            cuiLabel2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(25, 442);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(143, 19);
            cuiLabel2.TabIndex = 14;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiGroupBox2
            // 
            cuiGroupBox2.BorderColor = Color.DarkGoldenrod;
            cuiGroupBox2.Content = "Contraseña";
            cuiGroupBox2.Controls.Add(txtContraseña);
            cuiGroupBox2.Font = new Font("Garamond", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiGroupBox2.ForeColor = Color.DarkOliveGreen;
            cuiGroupBox2.Location = new Point(39, 192);
            cuiGroupBox2.Margin = new Padding(3, 2, 3, 2);
            cuiGroupBox2.Name = "cuiGroupBox2";
            cuiGroupBox2.Padding = new Padding(10, 28, 10, 15);
            cuiGroupBox2.Rounding = new Padding(10, 10, 10, 15);
            cuiGroupBox2.Size = new Size(286, 54);
            cuiGroupBox2.TabIndex = 12;
            // 
            // txtContraseña
            // 
            txtContraseña.BackgroundColor = Color.WhiteSmoke;
            txtContraseña.Content = "";
            txtContraseña.FocusBackgroundColor = Color.White;
            txtContraseña.FocusImageTint = Color.White;
            txtContraseña.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtContraseña.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Image = null;
            txtContraseña.ImageExpand = new Point(0, 0);
            txtContraseña.ImageOffset = new Point(0, 0);
            txtContraseña.Location = new Point(10, 20);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.NormalImageTint = Color.White;
            txtContraseña.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtContraseña.Padding = new Padding(15, 6, 15, 0);
            txtContraseña.PasswordChar = false;
            txtContraseña.PlaceholderColor = SystemColors.WindowText;
            txtContraseña.PlaceholderText = "";
            txtContraseña.Rounding = new Padding(8);
            txtContraseña.Size = new Size(262, 26);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextOffset = new Size(0, 0);
            txtContraseña.UnderlinedStyle = true;
            // 
            // cuiGroupBox1
            // 
            cuiGroupBox1.BorderColor = Color.DarkGoldenrod;
            cuiGroupBox1.Content = "Email";
            cuiGroupBox1.Controls.Add(txtCorreo);
            cuiGroupBox1.Font = new Font("Garamond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiGroupBox1.ForeColor = Color.DarkOliveGreen;
            cuiGroupBox1.Location = new Point(39, 126);
            cuiGroupBox1.Margin = new Padding(3, 2, 3, 2);
            cuiGroupBox1.Name = "cuiGroupBox1";
            cuiGroupBox1.Padding = new Padding(10, 29, 10, 15);
            cuiGroupBox1.Rounding = new Padding(10, 10, 10, 15);
            cuiGroupBox1.Size = new Size(286, 52);
            cuiGroupBox1.TabIndex = 11;
            // 
            // txtCorreo
            // 
            txtCorreo.BackgroundColor = Color.WhiteSmoke;
            txtCorreo.Content = "";
            txtCorreo.FocusBackgroundColor = Color.White;
            txtCorreo.FocusImageTint = Color.White;
            txtCorreo.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtCorreo.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.Gray;
            txtCorreo.Image = null;
            txtCorreo.ImageExpand = new Point(0, 0);
            txtCorreo.ImageOffset = new Point(0, 0);
            txtCorreo.Location = new Point(9, 19);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.NormalImageTint = Color.White;
            txtCorreo.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtCorreo.Padding = new Padding(15, 6, 15, 0);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderColor = SystemColors.WindowText;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Rounding = new Padding(8);
            txtCorreo.Size = new Size(263, 26);
            txtCorreo.TabIndex = 0;
            txtCorreo.TextOffset = new Size(0, 0);
            txtCorreo.UnderlinedStyle = true;
            // 
            // cuiPictureBox2
            // 
            cuiPictureBox2.Content = Properties.Resources.LRR_removebg_preview;
            cuiPictureBox2.ImageTint = Color.White;
            cuiPictureBox2.Location = new Point(25, 6);
            cuiPictureBox2.Margin = new Padding(4);
            cuiPictureBox2.Name = "cuiPictureBox2";
            cuiPictureBox2.OutlineThickness = 1F;
            cuiPictureBox2.PanelOutlineColor = Color.Empty;
            cuiPictureBox2.Rotation = 0;
            cuiPictureBox2.Rounding = new Padding(8);
            cuiPictureBox2.Size = new Size(199, 160);
            cuiPictureBox2.TabIndex = 13;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Todavia\\ no\\ tienes\\ una\\ cuenta\\?";
            cuiLabel1.Font = new Font("Garamond", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(19, 357);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(306, 16);
            cuiLabel1.TabIndex = 10;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // btnRegistrar
            // 
            btnRegistrar.CheckButton = false;
            btnRegistrar.Checked = false;
            btnRegistrar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnRegistrar.CheckedForeColor = Color.White;
            btnRegistrar.CheckedImageTint = Color.White;
            btnRegistrar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnRegistrar.Content = "Registrarse";
            btnRegistrar.DialogResult = DialogResult.None;
            btnRegistrar.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.HoverBackground = Color.White;
            btnRegistrar.HoverForeColor = Color.Black;
            btnRegistrar.HoverImageTint = Color.White;
            btnRegistrar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRegistrar.Image = null;
            btnRegistrar.ImageAutoCenter = true;
            btnRegistrar.ImageExpand = new Point(0, 0);
            btnRegistrar.ImageOffset = new Point(0, 0);
            btnRegistrar.Location = new Point(49, 379);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.NormalBackground = Color.Olive;
            btnRegistrar.NormalForeColor = Color.Black;
            btnRegistrar.NormalImageTint = Color.White;
            btnRegistrar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegistrar.OutlineThickness = 1F;
            btnRegistrar.PressedBackground = Color.WhiteSmoke;
            btnRegistrar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRegistrar.PressedImageTint = Color.White;
            btnRegistrar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegistrar.Rounding = new Padding(8);
            btnRegistrar.Size = new Size(244, 24);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.TextAlignment = StringAlignment.Center;
            btnRegistrar.TextOffset = new Point(0, 0);
            // 
            // btnLogin
            // 
            btnLogin.CheckButton = false;
            btnLogin.Checked = false;
            btnLogin.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLogin.CheckedForeColor = Color.White;
            btnLogin.CheckedImageTint = Color.Wheat;
            btnLogin.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLogin.Content = "Iniciar sesion";
            btnLogin.DialogResult = DialogResult.None;
            btnLogin.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.HoverBackground = Color.White;
            btnLogin.HoverForeColor = Color.Black;
            btnLogin.HoverImageTint = Color.White;
            btnLogin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLogin.Image = null;
            btnLogin.ImageAutoCenter = true;
            btnLogin.ImageExpand = new Point(0, 0);
            btnLogin.ImageOffset = new Point(0, 0);
            btnLogin.Location = new Point(75, 321);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBackground = Color.Orange;
            btnLogin.NormalForeColor = Color.Black;
            btnLogin.NormalImageTint = Color.White;
            btnLogin.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.OutlineThickness = 1F;
            btnLogin.PressedBackground = Color.WhiteSmoke;
            btnLogin.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLogin.PressedImageTint = Color.White;
            btnLogin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.Rounding = new Padding(8);
            btnLogin.Size = new Size(195, 30);
            btnLogin.TabIndex = 8;
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.TextOffset = new Point(0, 0);
            // 
            // cuiPictureBox3
            // 
            cuiPictureBox3.Content = Properties.Resources.browser_735828;
            cuiPictureBox3.ImageTint = Color.White;
            cuiPictureBox3.Location = new Point(178, 192);
            cuiPictureBox3.Margin = new Padding(4);
            cuiPictureBox3.Name = "cuiPictureBox3";
            cuiPictureBox3.OutlineThickness = 1F;
            cuiPictureBox3.PanelOutlineColor = Color.Empty;
            cuiPictureBox3.Rotation = 0;
            cuiPictureBox3.Rounding = new Padding(8);
            cuiPictureBox3.Size = new Size(102, 98);
            cuiPictureBox3.TabIndex = 4;
            // 
            // cuiFileDropper2
            // 
            cuiFileDropper2.AllowDrop = true;
            cuiFileDropper2.BackColor = Color.SaddleBrown;
            cuiFileDropper2.DashedOutline = true;
            cuiFileDropper2.DashedOutlineColor = Color.White;
            cuiFileDropper2.DashLength = 8;
            cuiFileDropper2.Filter = "";
            cuiFileDropper2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiFileDropper2.ForeColor = Color.White;
            cuiFileDropper2.HoverContent = "Release to drop";
            cuiFileDropper2.HoverForeColor = Color.Black;
            cuiFileDropper2.HoverUploadForeColor = Color.FromArgb(64, 64, 0);
            cuiFileDropper2.Image = (Image)resources.GetObject("cuiFileDropper2.Image");
            cuiFileDropper2.ImagePadding = 2;
            cuiFileDropper2.ImageSize = new Size(24, 24);
            cuiFileDropper2.ImageTint = Color.White;
            cuiFileDropper2.Location = new Point(51, 357);
            cuiFileDropper2.Margin = new Padding(3, 2, 3, 2);
            cuiFileDropper2.Multiselect = false;
            cuiFileDropper2.Name = "cuiFileDropper2";
            cuiFileDropper2.NormalContent = "Arrastra la foto de tu preferencia";
            cuiFileDropper2.NormalForeColor = Color.White;
            cuiFileDropper2.NormalUploadForeColor = Color.Yellow;
            cuiFileDropper2.OutlineThickness = 1F;
            cuiFileDropper2.PanelColor = Color.FromArgb(16, 255, 255, 255);
            cuiFileDropper2.Rounding = new Padding(8);
            cuiFileDropper2.Size = new Size(349, 84);
            cuiFileDropper2.TabIndex = 3;
            cuiFileDropper2.Text = "cuiFileDropper2";
            cuiFileDropper2.UploadContent = "Click to upload";
            cuiFileDropper2.UploadWithClick = true;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 556);
            Controls.Add(splCon_Separador);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormInicio";
            Text = "Incio de sesión";
            Load += FormInicio_Load;
            splCon_Separador.Panel1.ResumeLayout(false);
            splCon_Separador.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splCon_Separador).EndInit();
            splCon_Separador.ResumeLayout(false);
            cuiGroupBox2.ResumeLayout(false);
            cuiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxConfig;
        private ToolTip toolTip1;
        private SplitContainer splCon_Separador;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox2;
        private CuoreUI.Controls.cuiTextBox txtContraseña;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private CuoreUI.Controls.cuiTextBox txtCorreo;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton btnRegistrar;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiFileDropper cuiFileDropper2;
    }
}
