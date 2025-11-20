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
            pnlForms_Login_Regis = new Panel();
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
            panel3 = new Panel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            cuiFileDropper1 = new CuoreUI.Controls.cuiFileDropper();
            pnlForms_Login_Regis.SuspendLayout();
            cuiGroupBox2.SuspendLayout();
            cuiGroupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlForms_Login_Regis
            // 
            pnlForms_Login_Regis.Controls.Add(cuiButton3);
            pnlForms_Login_Regis.Controls.Add(cuiLabel2);
            pnlForms_Login_Regis.Controls.Add(cuiGroupBox2);
            pnlForms_Login_Regis.Controls.Add(cuiGroupBox1);
            pnlForms_Login_Regis.Controls.Add(cuiPictureBox2);
            pnlForms_Login_Regis.Controls.Add(cuiLabel1);
            pnlForms_Login_Regis.Controls.Add(btnRegistrar);
            pnlForms_Login_Regis.Controls.Add(btnLogin);
            pnlForms_Login_Regis.Dock = DockStyle.Left;
            pnlForms_Login_Regis.Location = new Point(0, 0);
            pnlForms_Login_Regis.Name = "pnlForms_Login_Regis";
            pnlForms_Login_Regis.Size = new Size(444, 580);
            pnlForms_Login_Regis.TabIndex = 1;
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
            cuiButton3.Location = new Point(235, 535);
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
            cuiButton3.Size = new Size(191, 33);
            cuiButton3.TabIndex = 7;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextOffset = new Point(0, 0);
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Contactanos\\ aqui:";
            cuiLabel2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(20, 541);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(208, 25);
            cuiLabel2.TabIndex = 6;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiGroupBox2
            // 
            cuiGroupBox2.BorderColor = Color.DarkGoldenrod;
            cuiGroupBox2.Content = "Contraseña";
            cuiGroupBox2.Controls.Add(txtContraseña);
            cuiGroupBox2.Font = new Font("Garamond", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiGroupBox2.ForeColor = Color.DarkOliveGreen;
            cuiGroupBox2.Location = new Point(29, 208);
            cuiGroupBox2.Name = "cuiGroupBox2";
            cuiGroupBox2.Padding = new Padding(10, 33, 10, 15);
            cuiGroupBox2.Rounding = new Padding(10, 10, 10, 15);
            cuiGroupBox2.Size = new Size(356, 72);
            cuiGroupBox2.TabIndex = 4;
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
            txtContraseña.Location = new Point(11, 26);
            txtContraseña.Margin = new Padding(4, 4, 4, 4);
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.NormalImageTint = Color.White;
            txtContraseña.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtContraseña.Padding = new Padding(18, 8, 18, 0);
            txtContraseña.PasswordChar = false;
            txtContraseña.PlaceholderColor = SystemColors.WindowText;
            txtContraseña.PlaceholderText = "";
            txtContraseña.Rounding = new Padding(8);
            txtContraseña.Size = new Size(332, 35);
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
            cuiGroupBox1.Location = new Point(29, 120);
            cuiGroupBox1.Name = "cuiGroupBox1";
            cuiGroupBox1.Padding = new Padding(10, 34, 10, 15);
            cuiGroupBox1.Rounding = new Padding(10, 10, 10, 15);
            cuiGroupBox1.Size = new Size(356, 69);
            cuiGroupBox1.TabIndex = 3;
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
            txtCorreo.Location = new Point(10, 25);
            txtCorreo.Margin = new Padding(4, 4, 4, 4);
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.NormalImageTint = Color.White;
            txtCorreo.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtCorreo.Padding = new Padding(18, 8, 18, 0);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderColor = SystemColors.WindowText;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Rounding = new Padding(8);
            txtCorreo.Size = new Size(332, 35);
            txtCorreo.TabIndex = 0;
            txtCorreo.TextOffset = new Size(0, 0);
            txtCorreo.UnderlinedStyle = true;
            // 
            // cuiPictureBox2
            // 
            cuiPictureBox2.Content = Properties.Resources.LRR_removebg_preview;
            cuiPictureBox2.ImageTint = Color.White;
            cuiPictureBox2.Location = new Point(13, -40);
            cuiPictureBox2.Margin = new Padding(4, 5, 4, 5);
            cuiPictureBox2.Name = "cuiPictureBox2";
            cuiPictureBox2.OutlineThickness = 1F;
            cuiPictureBox2.PanelOutlineColor = Color.Empty;
            cuiPictureBox2.Rotation = 0;
            cuiPictureBox2.Rounding = new Padding(8);
            cuiPictureBox2.Size = new Size(227, 214);
            cuiPictureBox2.TabIndex = 5;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Todavia\\ no\\ tienes\\ una\\ cuenta\\?";
            cuiLabel1.Font = new Font("Garamond", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(35, 428);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(350, 21);
            cuiLabel1.TabIndex = 2;
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
            btnRegistrar.Location = new Point(59, 457);
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
            btnRegistrar.Size = new Size(314, 32);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.TextAlignment = StringAlignment.Center;
            btnRegistrar.TextOffset = new Point(0, 0);
            btnRegistrar.Click += btnRegistrar_Click;
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
            btnLogin.Location = new Point(102, 380);
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
            btnLogin.Size = new Size(223, 40);
            btnLogin.TabIndex = 0;
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.TextOffset = new Point(0, 0);
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Chocolate;
            panel3.Controls.Add(cuiPictureBox1);
            panel3.Controls.Add(cuiFileDropper1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(450, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 580);
            panel3.TabIndex = 2;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.Content = Properties.Resources.browser_735828;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(210, 208);
            cuiPictureBox1.Margin = new Padding(4, 5, 4, 5);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(116, 116);
            cuiPictureBox1.TabIndex = 2;
            // 
            // cuiFileDropper1
            // 
            cuiFileDropper1.AllowDrop = true;
            cuiFileDropper1.BackColor = Color.SaddleBrown;
            cuiFileDropper1.DashedOutline = true;
            cuiFileDropper1.DashedOutlineColor = Color.White;
            cuiFileDropper1.DashLength = 8;
            cuiFileDropper1.Filter = "";
            cuiFileDropper1.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiFileDropper1.ForeColor = Color.White;
            cuiFileDropper1.HoverContent = "Release to drop";
            cuiFileDropper1.HoverForeColor = Color.Black;
            cuiFileDropper1.HoverUploadForeColor = Color.FromArgb(64, 64, 0);
            cuiFileDropper1.Image = (Image)resources.GetObject("cuiFileDropper1.Image");
            cuiFileDropper1.ImagePadding = 2;
            cuiFileDropper1.ImageSize = new Size(24, 24);
            cuiFileDropper1.ImageTint = Color.White;
            cuiFileDropper1.Location = new Point(63, 402);
            cuiFileDropper1.Multiselect = false;
            cuiFileDropper1.Name = "cuiFileDropper1";
            cuiFileDropper1.NormalContent = "Arrastra la foto de tu preferencia";
            cuiFileDropper1.NormalForeColor = Color.White;
            cuiFileDropper1.NormalUploadForeColor = Color.Yellow;
            cuiFileDropper1.OutlineThickness = 1F;
            cuiFileDropper1.PanelColor = Color.FromArgb(16, 255, 255, 255);
            cuiFileDropper1.Rounding = new Padding(8);
            cuiFileDropper1.Size = new Size(399, 112);
            cuiFileDropper1.TabIndex = 1;
            cuiFileDropper1.Text = "cuiFileDropper1";
            cuiFileDropper1.UploadContent = "Click to upload";
            cuiFileDropper1.UploadWithClick = true;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 580);
            Controls.Add(panel3);
            Controls.Add(pnlForms_Login_Regis);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInicio";
            Text = "Incio de sesión";
            this.Load += FormInicio_Load;
            pnlForms_Login_Regis.ResumeLayout(false);
            cuiGroupBox2.ResumeLayout(false);
            cuiGroupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxConfig;
        private ToolTip toolTip1;
        private Panel pnlForms_Login_Regis;
        private Panel panel3;
        private CuoreUI.Controls.cuiButton btnRegistrar;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox2;
        private CuoreUI.Controls.cuiFileDropper cuiFileDropper1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiTextBox txtContraseña;
        private CuoreUI.Controls.cuiTextBox txtCorreo;
    }
}
