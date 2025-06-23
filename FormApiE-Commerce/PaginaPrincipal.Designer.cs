namespace FormApiE_Commerce
{
    partial class PaginaPrincipal
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnCerrar = new Button();
            btnCerrarSesion = new Button();
            btnMenu = new Button();
            tabControl1 = new TabControl();
            tabPageComprar = new TabPage();
            tabPageVender = new TabPage();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            label6 = new Label();
            label5 = new Label();
            btnUbicacion = new Button();
            label4 = new Label();
            txtLatitud = new TextBox();
            label2 = new Label();
            txtLongitud = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lblNumCuenta = new Label();
            mTxtNumeroDeCuenta = new MaskedTextBox();
            txtDireccion = new TextBox();
            btnRegistrarse = new Button();
            btnRefrescar = new Button();
            panel1 = new Panel();
            btnChatBot = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageVender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 24);
            label1.TabIndex = 1;
            label1.Text = "E-Commerce";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnCerrarSesion);
            flowLayoutPanel1.Location = new Point(679, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(121, 71);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCerrar);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(115, 35);
            panel2.TabIndex = 5;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(84, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 14;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Firebrick;
            btnCerrarSesion.Location = new Point(3, 44);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(123, 33);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = Properties.Resources.Menu;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.Location = new Point(750, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 33);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageComprar);
            tabControl1.Controls.Add(tabPageVender);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 43);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(814, 408);
            tabControl1.TabIndex = 4;
            // 
            // tabPageComprar
            // 
            tabPageComprar.Location = new Point(4, 24);
            tabPageComprar.Name = "tabPageComprar";
            tabPageComprar.Padding = new Padding(3);
            tabPageComprar.Size = new Size(806, 380);
            tabPageComprar.TabIndex = 0;
            tabPageComprar.Text = "Comprar";
            tabPageComprar.UseVisualStyleBackColor = true;
            // 
            // tabPageVender
            // 
            tabPageVender.Controls.Add(gMapControl1);
            tabPageVender.Controls.Add(label6);
            tabPageVender.Controls.Add(label5);
            tabPageVender.Controls.Add(btnUbicacion);
            tabPageVender.Controls.Add(label4);
            tabPageVender.Controls.Add(txtLatitud);
            tabPageVender.Controls.Add(label2);
            tabPageVender.Controls.Add(txtLongitud);
            tabPageVender.Controls.Add(pictureBox1);
            tabPageVender.Controls.Add(label3);
            tabPageVender.Controls.Add(lblNumCuenta);
            tabPageVender.Controls.Add(mTxtNumeroDeCuenta);
            tabPageVender.Controls.Add(txtDireccion);
            tabPageVender.Controls.Add(btnRegistrarse);
            tabPageVender.Location = new Point(4, 24);
            tabPageVender.Name = "tabPageVender";
            tabPageVender.Padding = new Padding(3);
            tabPageVender.Size = new Size(806, 380);
            tabPageVender.TabIndex = 1;
            tabPageVender.Text = "Vender";
            tabPageVender.UseVisualStyleBackColor = true;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(438, 171);
            gMapControl1.Margin = new Padding(3, 2, 3, 2);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(354, 191);
            gMapControl1.TabIndex = 18;
            gMapControl1.Zoom = 0D;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 52);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(256, 75);
            label6.TabIndex = 17;
            label6.Text = "Esta es nesesaria para los compradores puedan \r\nconocerte de manera nacional e internacional ,\r\nesto nos da a nosotros\r\nmejor control y retroalimentacion \r\nde nuestros queridos usuarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 28);
            label5.Name = "label5";
            label5.Size = new Size(240, 15);
            label5.TabIndex = 16;
            label5.Text = "¿POR QUE AGREGAREMOS TU UBICACION? ";
            // 
            // btnUbicacion
            // 
            btnUbicacion.Location = new Point(438, 145);
            btnUbicacion.Margin = new Padding(3, 2, 3, 2);
            btnUbicacion.Name = "btnUbicacion";
            btnUbicacion.Size = new Size(170, 22);
            btnUbicacion.TabIndex = 15;
            btnUbicacion.Text = "Agrega tu ubicacion aqui";
            btnUbicacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 93);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 14;
            label4.Text = "Latitud";
            // 
            // txtLatitud
            // 
            txtLatitud.Location = new Point(310, 84);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(107, 23);
            txtLatitud.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 122);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 12;
            label2.Text = "Longitud";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(310, 113);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(107, 23);
            txtLongitud.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MascotaE_CommerceRegistroVendedor;
            pictureBox1.Location = new Point(8, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 61);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Dirección";
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Location = new Point(175, 31);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(106, 15);
            lblNumCuenta.TabIndex = 6;
            lblNumCuenta.Text = "Numero de cuenta";
            // 
            // mTxtNumeroDeCuenta
            // 
            mTxtNumeroDeCuenta.Location = new Point(310, 23);
            mTxtNumeroDeCuenta.Mask = "0000-0000-0000-0000";
            mTxtNumeroDeCuenta.Name = "mTxtNumeroDeCuenta";
            mTxtNumeroDeCuenta.Size = new Size(107, 23);
            mTxtNumeroDeCuenta.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(310, 52);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(107, 23);
            txtDireccion.TabIndex = 1;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(248, 226);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(110, 23);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackgroundImage = Properties.Resources.reinciar;
            btnRefrescar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefrescar.Location = new Point(145, 7);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(31, 31);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChatBot);
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 451);
            panel1.TabIndex = 2;
            // 
            // btnChatBot
            // 
            btnChatBot.BackgroundImage = Properties.Resources.ImagenChatBot;
            btnChatBot.BackgroundImageLayout = ImageLayout.Stretch;
            btnChatBot.Location = new Point(602, 7);
            btnChatBot.Name = "btnChatBot";
            btnChatBot.Size = new Size(59, 52);
            btnChatBot.TabIndex = 7;
            btnChatBot.UseVisualStyleBackColor = true;
            btnChatBot.Click += btnChatBot_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 451);
            Controls.Add(panel1);
            Name = "PaginaPrincipal";
            Text = "PaginaPrincipal";
            Load += PaginaPrincipal_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageVender.ResumeLayout(false);
            tabPageVender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCerrarSesion;
        private Button btnMenu;
        private TabControl tabControl1;
        private TabPage tabPageComprar;
        private TabPage tabPageVender;
        private Panel panel1;
        private Button btnCerrar;
        private Panel panel2;
        private Button btnRefrescar;
        private Button btnRegistrarse;
        private TextBox txtDireccion;
        private MaskedTextBox mTxtNumeroDeCuenta;
        private Label label3;
        private Label lblNumCuenta;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtLatitud;
        private Label label2;
        private TextBox txtLongitud;
        private Button btnUbicacion;
        private Label label6;
        private Label label5;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Button btnChatBot;
    }
}