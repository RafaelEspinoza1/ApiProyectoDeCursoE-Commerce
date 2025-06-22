namespace TiendaEcommerce
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
            pictureBox2 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageVender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(166, 29);
            label1.TabIndex = 1;
            label1.Text = "E-Commerce";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnCerrarSesion);
            flowLayoutPanel1.Location = new Point(776, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(138, 95);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCerrar);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(131, 47);
            panel2.TabIndex = 5;
            // 
            // btnCerrar
            // 
           
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(96, 1);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 41);
            btnCerrar.TabIndex = 14;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Firebrick;
            btnCerrarSesion.Location = new Point(3, 59);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(141, 44);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnMenu
            // 
            
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.Location = new Point(857, 4);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(54, 44);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageComprar);
            tabControl1.Controls.Add(tabPageVender);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 57);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 544);
            tabControl1.TabIndex = 4;
            // 
            // tabPageComprar
            // 
            tabPageComprar.Location = new Point(4, 29);
            tabPageComprar.Margin = new Padding(3, 4, 3, 4);
            tabPageComprar.Name = "tabPageComprar";
            tabPageComprar.Padding = new Padding(3, 4, 3, 4);
            tabPageComprar.Size = new Size(922, 511);
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
            tabPageVender.Location = new Point(4, 29);
            tabPageVender.Margin = new Padding(3, 4, 3, 4);
            tabPageVender.Name = "tabPageVender";
            tabPageVender.Padding = new Padding(3, 4, 3, 4);
            tabPageVender.Size = new Size(922, 511);
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
            gMapControl1.Location = new Point(501, 228);
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
            gMapControl1.Size = new Size(405, 255);
            gMapControl1.TabIndex = 18;
            gMapControl1.Zoom = 0D;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 69);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(326, 100);
            label6.TabIndex = 17;
            label6.Text = "Esta es nesesaria para los compradores puedan \r\nconocerte de manera nacional e internacional ,\r\nesto nos da a nosotros\r\nmejor control y retroalimentacion \r\nde nuestros queridos usuarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 38);
            label5.Name = "label5";
            label5.Size = new Size(301, 20);
            label5.TabIndex = 16;
            label5.Text = "¿POR QUE AGREGAREMOS TU UBICACION? ";
            // 
            // btnUbicacion
            // 
            btnUbicacion.Location = new Point(501, 193);
            btnUbicacion.Name = "btnUbicacion";
            btnUbicacion.Size = new Size(194, 29);
            btnUbicacion.TabIndex = 15;
            btnUbicacion.Text = "Agrega tu ubicacion aqui";
            btnUbicacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 124);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 14;
            label4.Text = "Latitud";
            // 
            // txtLatitud
            // 
            txtLatitud.Location = new Point(354, 112);
            txtLatitud.Margin = new Padding(3, 4, 3, 4);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(122, 27);
            txtLatitud.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 163);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 12;
            label2.Text = "Longitud";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(354, 151);
            txtLongitud.Margin = new Padding(3, 4, 3, 4);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(122, 27);
            txtLongitud.TabIndex = 11;
            // 
            // pictureBox1
            // 
           
            pictureBox1.Location = new Point(9, 41);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 81);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Dirección";
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Location = new Point(200, 41);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(132, 20);
            lblNumCuenta.TabIndex = 6;
            lblNumCuenta.Text = "Numero de cuenta";
            // 
            // mTxtNumeroDeCuenta
            // 
            mTxtNumeroDeCuenta.Location = new Point(354, 31);
            mTxtNumeroDeCuenta.Margin = new Padding(3, 4, 3, 4);
            mTxtNumeroDeCuenta.Mask = "0000-0000-0000-0000";
            mTxtNumeroDeCuenta.Name = "mTxtNumeroDeCuenta";
            mTxtNumeroDeCuenta.Size = new Size(122, 27);
            mTxtNumeroDeCuenta.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(354, 69);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(122, 27);
            txtDireccion.TabIndex = 1;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(284, 301);
            btnRegistrarse.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(126, 31);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnRefrescar
            // 
           
            btnRefrescar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefrescar.Location = new Point(166, 9);
            btnRefrescar.Margin = new Padding(3, 4, 3, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(35, 41);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 601);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
           
            pictureBox2.Location = new Point(688, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.DoubleClick += pictureBox2_DoubleClick;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 601);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
    }
}