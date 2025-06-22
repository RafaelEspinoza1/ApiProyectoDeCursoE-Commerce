namespace TiendaEcommerce
{
    partial class Vender
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
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtLatitud = new TextBox();
            label2 = new Label();
            txtLongitud = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lblNumCuenta = new Label();
            txtNumeroDeCuenta = new MaskedTextBox();
            txtDireccion = new TextBox();
            btnRegistrarse = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btnUbicacion = new Button();
            label7 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(373, 252);
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
            gMapControl1.Size = new Size(508, 267);
            gMapControl1.TabIndex = 32;
            gMapControl1.Zoom = 0D;
            gMapControl1.MouseDoubleClick += Mostrarubicacion;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 334);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(326, 100);
            label6.TabIndex = 31;
            label6.Text = "Esta es nesesaria para los compradores puedan \r\nconocerte de manera nacional e internacional ,\r\nesto nos da a nosotros\r\nmejor control y retroalimentacion \r\nde nuestros queridos usuarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 296);
            label5.Name = "label5";
            label5.Size = new Size(301, 20);
            label5.TabIndex = 30;
            label5.Text = "¿POR QUE AGREGAREMOS TU UBICACION? ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 128);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 28;
            label4.Text = "Latitud";
            // 
            // txtLatitud
            // 
            txtLatitud.Location = new Point(347, 116);
            txtLatitud.Margin = new Padding(3, 4, 3, 4);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(122, 27);
            txtLatitud.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 167);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 26;
            label2.Text = "Longitud";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(347, 155);
            txtLongitud.Margin = new Padding(3, 4, 3, 4);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(122, 27);
            txtLongitud.TabIndex = 25;
            // 
            // pictureBox1
            // 
           
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 85);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 23;
            label3.Text = "Dirección";
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Location = new Point(193, 45);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(132, 20);
            lblNumCuenta.TabIndex = 22;
            lblNumCuenta.Text = "Numero de cuenta";
            // 
            // txtNumeroDeCuenta
            // 
            txtNumeroDeCuenta.Location = new Point(347, 35);
            txtNumeroDeCuenta.Margin = new Padding(3, 4, 3, 4);
            txtNumeroDeCuenta.Mask = "0000-0000-0000-0000";
            txtNumeroDeCuenta.Name = "txtNumeroDeCuenta";
            txtNumeroDeCuenta.Size = new Size(122, 27);
            txtNumeroDeCuenta.TabIndex = 21;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(347, 73);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(122, 27);
            txtDireccion.TabIndex = 20;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(193, 235);
            btnRegistrarse.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(126, 30);
            btnRegistrarse.TabIndex = 19;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(518, 27);
            textBox1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 204);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 34;
            label1.Text = "Nombre de Ubicacion";
            // 
            // btnUbicacion
            // 
            btnUbicacion.Location = new Point(24, 460);
            btnUbicacion.Name = "btnUbicacion";
            btnUbicacion.Size = new Size(194, 29);
            btnUbicacion.TabIndex = 29;
            btnUbicacion.Text = "Agrega tu ubicacion aqui";
            btnUbicacion.UseVisualStyleBackColor = true;
            btnUbicacion.Click += btnUbicacion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 35);
            label7.Name = "label7";
            label7.Size = new Size(224, 20);
            label7.TabIndex = 35;
            label7.Text = "¿No conoces muy bien el mapa?";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(565, 155);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(161, 29);
            btnBuscar.TabIndex = 36;
            btnBuscar.Text = "Buscar direccion";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(565, 116);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(259, 27);
            txtBuscar.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(565, 65);
            label8.Name = "label8";
            label8.Size = new Size(185, 40);
            label8.TabIndex = 38;
            label8.Text = "Coloca aqui el nombre de \r\ntu barrio o lugar conocido";
            // 
            // Vender
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(label8);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(gMapControl1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnUbicacion);
            Controls.Add(label4);
            Controls.Add(txtLatitud);
            Controls.Add(label2);
            Controls.Add(txtLongitud);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(lblNumCuenta);
            Controls.Add(txtNumeroDeCuenta);
            Controls.Add(txtDireccion);
            Controls.Add(btnRegistrarse);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Vender";
            Size = new Size(914, 546);
            Load += Vender_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtLatitud;
        private Label label2;
        private TextBox txtLongitud;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblNumCuenta;
        private MaskedTextBox txtNumeroDeCuenta;
        private TextBox txtDireccion;
        private Button btnRegistrarse;
        private TextBox textBox1;
        private Label label1;
        private Button btnUbicacion;
        private Label label7;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label8;
    }
}