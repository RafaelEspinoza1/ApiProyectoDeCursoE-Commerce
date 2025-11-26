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
            gboxContraseña = new CuoreUI.Controls.cuiGroupBox();
            txtContraseña = new CuoreUI.Controls.cuiTextBox();
            gboxEmail = new CuoreUI.Controls.cuiGroupBox();
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
            gboxContraseña.SuspendLayout();
            gboxEmail.SuspendLayout();
            SuspendLayout();
            // 
            // splCon_Separador
            // 
            splCon_Separador.Dock = DockStyle.Fill;
            splCon_Separador.Location = new Point(0, 0);
            splCon_Separador.Margin = new Padding(3, 4, 3, 4);
            splCon_Separador.Name = "splCon_Separador";
            // 
            // splCon_Separador.Panel1
            // 
            splCon_Separador.Panel1.Controls.Add(cuiButton3);
            splCon_Separador.Panel1.Controls.Add(cuiLabel2);
            splCon_Separador.Panel1.Controls.Add(gboxContraseña);
            splCon_Separador.Panel1.Controls.Add(gboxEmail);
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
            splCon_Separador.Size = new Size(1011, 741);
            splCon_Separador.SplitterDistance = 461;
            splCon_Separador.SplitterWidth = 5;
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
            cuiButton3.Location = new Point(200, 587);
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
            cuiButton3.Size = new Size(135, 33);
            cuiButton3.TabIndex = 15;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextOffset = new Point(0, 0);
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Contactanos\\ aqui:";
            cuiLabel2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(29, 589);
            cuiLabel2.Margin = new Padding(5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(163, 25);
            cuiLabel2.TabIndex = 14;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // gboxContraseña
            // 
            gboxContraseña.BorderColor = Color.DarkGoldenrod;
            gboxContraseña.Content = "Contraseña";
            gboxContraseña.Controls.Add(txtContraseña);
            gboxContraseña.Font = new Font("Garamond", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gboxContraseña.ForeColor = Color.DarkOliveGreen;
            gboxContraseña.Location = new Point(45, 256);
            gboxContraseña.Name = "gboxContraseña";
            gboxContraseña.Padding = new Padding(10, 33, 10, 15);
            gboxContraseña.Rounding = new Padding(10, 10, 10, 15);
            gboxContraseña.Size = new Size(327, 72);
            gboxContraseña.TabIndex = 12;
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
            txtContraseña.Location = new Point(11, 27);
            txtContraseña.Margin = new Padding(5, 4, 5, 4);
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.NormalImageTint = Color.White;
            txtContraseña.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtContraseña.Padding = new Padding(18, 8, 18, 0);
            txtContraseña.PasswordChar = false;
            txtContraseña.PlaceholderColor = SystemColors.WindowText;
            txtContraseña.PlaceholderText = "";
            txtContraseña.Rounding = new Padding(8);
            txtContraseña.Size = new Size(299, 35);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextOffset = new Size(0, 0);
            txtContraseña.UnderlinedStyle = true;
            // 
            // gboxEmail
            // 
            gboxEmail.BorderColor = Color.DarkGoldenrod;
            gboxEmail.Content = "Email";
            gboxEmail.Controls.Add(txtCorreo);
            gboxEmail.Font = new Font("Garamond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gboxEmail.ForeColor = Color.DarkOliveGreen;
            gboxEmail.Location = new Point(45, 168);
            gboxEmail.Name = "gboxEmail";
            gboxEmail.Padding = new Padding(10, 34, 10, 15);
            gboxEmail.Rounding = new Padding(10, 10, 10, 15);
            gboxEmail.Size = new Size(327, 69);
            gboxEmail.TabIndex = 11;
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
            txtCorreo.Margin = new Padding(5, 4, 5, 4);
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.NormalImageTint = Color.White;
            txtCorreo.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtCorreo.Padding = new Padding(18, 8, 18, 0);
            txtCorreo.PasswordChar = false;
            txtCorreo.PlaceholderColor = SystemColors.WindowText;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Rounding = new Padding(8);
            txtCorreo.Size = new Size(301, 35);
            txtCorreo.TabIndex = 0;
            txtCorreo.TextOffset = new Size(0, 0);
            txtCorreo.UnderlinedStyle = true;
            // 
            // cuiPictureBox2
            // 
            cuiPictureBox2.Content = Properties.Resources.LRR_removebg_preview;
            cuiPictureBox2.ImageTint = Color.White;
            cuiPictureBox2.Location = new Point(29, 8);
            cuiPictureBox2.Margin = new Padding(5);
            cuiPictureBox2.Name = "cuiPictureBox2";
            cuiPictureBox2.OutlineThickness = 1F;
            cuiPictureBox2.PanelOutlineColor = Color.Empty;
            cuiPictureBox2.Rotation = 0;
            cuiPictureBox2.Rounding = new Padding(8);
            cuiPictureBox2.Size = new Size(227, 213);
            cuiPictureBox2.TabIndex = 13;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Todavia\\ no\\ tienes\\ una\\ cuenta\\?";
            cuiLabel1.Font = new Font("Garamond", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(22, 476);
            cuiLabel1.Margin = new Padding(5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(350, 21);
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
            btnRegistrar.Location = new Point(56, 505);
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
            btnRegistrar.Size = new Size(279, 32);
            btnRegistrar.TabIndex = 9;
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
            btnLogin.Location = new Point(86, 428);
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
            btnLogin.TabIndex = 8;
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.TextOffset = new Point(0, 0);
            // 
            // cuiPictureBox3
            // 
            cuiPictureBox3.Content = Properties.Resources.browser_735828;
            cuiPictureBox3.ImageTint = Color.White;
            cuiPictureBox3.Location = new Point(203, 256);
            cuiPictureBox3.Margin = new Padding(5);
            cuiPictureBox3.Name = "cuiPictureBox3";
            cuiPictureBox3.OutlineThickness = 1F;
            cuiPictureBox3.PanelOutlineColor = Color.Empty;
            cuiPictureBox3.Rotation = 0;
            cuiPictureBox3.Rounding = new Padding(8);
            cuiPictureBox3.Size = new Size(117, 131);
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
            cuiFileDropper2.Location = new Point(58, 476);
            cuiFileDropper2.Multiselect = false;
            cuiFileDropper2.Name = "cuiFileDropper2";
            cuiFileDropper2.NormalContent = "Arrastra la foto de tu preferencia";
            cuiFileDropper2.NormalForeColor = Color.White;
            cuiFileDropper2.NormalUploadForeColor = Color.Yellow;
            cuiFileDropper2.OutlineThickness = 1F;
            cuiFileDropper2.PanelColor = Color.FromArgb(16, 255, 255, 255);
            cuiFileDropper2.Rounding = new Padding(8);
            cuiFileDropper2.Size = new Size(399, 112);
            cuiFileDropper2.TabIndex = 3;
            cuiFileDropper2.Text = "cuiFileDropper2";
            cuiFileDropper2.UploadContent = "Click to upload";
            cuiFileDropper2.UploadWithClick = true;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 741);
            Controls.Add(splCon_Separador);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInicio";
            Text = "Incio de sesión";
            Load += FormInicio_Load;
            splCon_Separador.Panel1.ResumeLayout(false);
            splCon_Separador.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splCon_Separador).EndInit();
            splCon_Separador.ResumeLayout(false);
            gboxContraseña.ResumeLayout(false);
            gboxEmail.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxConfig;
        private ToolTip toolTip1;
        private SplitContainer splCon_Separador;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiGroupBox gboxContraseña;
        private CuoreUI.Controls.cuiTextBox txtContraseña;
        private CuoreUI.Controls.cuiGroupBox gboxEmail;
        private CuoreUI.Controls.cuiTextBox txtCorreo;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton btnRegistrar;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiFileDropper cuiFileDropper2;
    }
}
