namespace FormApiE_Commerce
{
    partial class FormComprar
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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnFiltros = new Button();
            flowLayoutPanelFiltros = new FlowLayoutPanel();
            panelCerrarFiltro = new Panel();
            btnCerrarFiltros = new Button();
            flowLayoutPanelBtnsFiltros = new FlowLayoutPanel();
            btnTipo = new Button();
            btnPrecio = new Button();
            btnEstado = new Button();
            btnRestablecer = new Button();
            flowLayoutPanelSeleccionFiltro = new FlowLayoutPanel();
            lblPrecioMin = new Label();
            txtPrecioMin = new TextBox();
            lblPrecioMax = new Label();
            txtPrecioMax = new TextBox();
            cboEstado = new ComboBox();
            cboTipos = new ComboBox();
            btnListo = new Button();
            flpProductos = new FlowLayoutPanel();
            flowLayoutPanelFiltros.SuspendLayout();
            panelCerrarFiltro.SuspendLayout();
            flowLayoutPanelBtnsFiltros.SuspendLayout();
            flowLayoutPanelSeleccionFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(106, 17);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(326, 27);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(14, 16);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnFiltros
            // 
            btnFiltros.Location = new Point(456, 17);
            btnFiltros.Margin = new Padding(3, 4, 3, 4);
            btnFiltros.Name = "btnFiltros";
            btnFiltros.Size = new Size(86, 31);
            btnFiltros.TabIndex = 2;
            btnFiltros.Text = "Filtros";
            btnFiltros.UseVisualStyleBackColor = true;
            btnFiltros.Click += btnFiltros_Click;
            // 
            // flowLayoutPanelFiltros
            // 
            flowLayoutPanelFiltros.Controls.Add(panelCerrarFiltro);
            flowLayoutPanelFiltros.Controls.Add(flowLayoutPanelBtnsFiltros);
            flowLayoutPanelFiltros.Controls.Add(btnRestablecer);
            flowLayoutPanelFiltros.Location = new Point(440, 16);
            flowLayoutPanelFiltros.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelFiltros.Name = "flowLayoutPanelFiltros";
            flowLayoutPanelFiltros.Size = new Size(250, 193);
            flowLayoutPanelFiltros.TabIndex = 3;
            flowLayoutPanelFiltros.Visible = false;
            // 
            // panelCerrarFiltro
            // 
            panelCerrarFiltro.Controls.Add(btnCerrarFiltros);
            panelCerrarFiltro.Location = new Point(3, 4);
            panelCerrarFiltro.Margin = new Padding(3, 4, 3, 4);
            panelCerrarFiltro.Name = "panelCerrarFiltro";
            panelCerrarFiltro.Size = new Size(242, 43);
            panelCerrarFiltro.TabIndex = 6;
            // 
            // btnCerrarFiltros
            // 
            
            btnCerrarFiltros.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarFiltros.Location = new Point(207, 0);
            btnCerrarFiltros.Margin = new Padding(3, 4, 3, 4);
            btnCerrarFiltros.Name = "btnCerrarFiltros";
            btnCerrarFiltros.Size = new Size(35, 41);
            btnCerrarFiltros.TabIndex = 8;
            btnCerrarFiltros.UseVisualStyleBackColor = true;
            btnCerrarFiltros.Click += btnCerrarFiltros_Click;
            // 
            // flowLayoutPanelBtnsFiltros
            // 
            flowLayoutPanelBtnsFiltros.Controls.Add(btnTipo);
            flowLayoutPanelBtnsFiltros.Controls.Add(btnPrecio);
            flowLayoutPanelBtnsFiltros.Controls.Add(btnEstado);
            flowLayoutPanelBtnsFiltros.Location = new Point(3, 55);
            flowLayoutPanelBtnsFiltros.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelBtnsFiltros.Name = "flowLayoutPanelBtnsFiltros";
            flowLayoutPanelBtnsFiltros.Size = new Size(98, 128);
            flowLayoutPanelBtnsFiltros.TabIndex = 6;
            // 
            // btnTipo
            // 
            btnTipo.Location = new Point(3, 4);
            btnTipo.Margin = new Padding(3, 4, 3, 4);
            btnTipo.Name = "btnTipo";
            btnTipo.Size = new Size(86, 31);
            btnTipo.TabIndex = 8;
            btnTipo.Text = "Tipo";
            btnTipo.UseVisualStyleBackColor = true;
            btnTipo.Click += btnTipo_Click;
            // 
            // btnPrecio
            // 
            btnPrecio.Location = new Point(3, 43);
            btnPrecio.Margin = new Padding(3, 4, 3, 4);
            btnPrecio.Name = "btnPrecio";
            btnPrecio.Size = new Size(86, 31);
            btnPrecio.TabIndex = 9;
            btnPrecio.Text = "Precio";
            btnPrecio.UseVisualStyleBackColor = true;
            btnPrecio.Click += btnPrecio_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(3, 82);
            btnEstado.Margin = new Padding(3, 4, 3, 4);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(86, 31);
            btnEstado.TabIndex = 10;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnRestablecer
            // 
            btnRestablecer.Location = new Point(107, 55);
            btnRestablecer.Margin = new Padding(3, 4, 3, 4);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(137, 31);
            btnRestablecer.TabIndex = 11;
            btnRestablecer.Text = "Restablecer todo";
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // flowLayoutPanelSeleccionFiltro
            // 
            flowLayoutPanelSeleccionFiltro.Controls.Add(lblPrecioMin);
            flowLayoutPanelSeleccionFiltro.Controls.Add(txtPrecioMin);
            flowLayoutPanelSeleccionFiltro.Controls.Add(lblPrecioMax);
            flowLayoutPanelSeleccionFiltro.Controls.Add(txtPrecioMax);
            flowLayoutPanelSeleccionFiltro.Controls.Add(cboEstado);
            flowLayoutPanelSeleccionFiltro.Controls.Add(cboTipos);
            flowLayoutPanelSeleccionFiltro.Controls.Add(btnListo);
            flowLayoutPanelSeleccionFiltro.Location = new Point(440, 16);
            flowLayoutPanelSeleccionFiltro.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelSeleccionFiltro.Name = "flowLayoutPanelSeleccionFiltro";
            flowLayoutPanelSeleccionFiltro.Size = new Size(357, 161);
            flowLayoutPanelSeleccionFiltro.TabIndex = 9;
            flowLayoutPanelSeleccionFiltro.Visible = false;
            // 
            // lblPrecioMin
            // 
            lblPrecioMin.AutoSize = true;
            lblPrecioMin.Location = new Point(3, 0);
            lblPrecioMin.Name = "lblPrecioMin";
            lblPrecioMin.Size = new Size(105, 20);
            lblPrecioMin.TabIndex = 0;
            lblPrecioMin.Text = "Precio minimo";
            lblPrecioMin.Visible = false;
            // 
            // txtPrecioMin
            // 
            txtPrecioMin.Location = new Point(114, 4);
            txtPrecioMin.Margin = new Padding(3, 4, 3, 4);
            txtPrecioMin.Name = "txtPrecioMin";
            txtPrecioMin.Size = new Size(58, 27);
            txtPrecioMin.TabIndex = 10;
            txtPrecioMin.Visible = false;
            txtPrecioMin.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecioMax
            // 
            lblPrecioMax.AutoSize = true;
            lblPrecioMax.Location = new Point(178, 0);
            lblPrecioMax.Name = "lblPrecioMax";
            lblPrecioMax.Size = new Size(108, 20);
            lblPrecioMax.TabIndex = 1;
            lblPrecioMax.Text = "Precio maximo";
            lblPrecioMax.Visible = false;
            // 
            // txtPrecioMax
            // 
            txtPrecioMax.Location = new Point(3, 39);
            txtPrecioMax.Margin = new Padding(3, 4, 3, 4);
            txtPrecioMax.Name = "txtPrecioMax";
            txtPrecioMax.Size = new Size(63, 27);
            txtPrecioMax.TabIndex = 11;
            txtPrecioMax.Visible = false;
            txtPrecioMax.KeyPress += txtPrecio_KeyPress;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Cualquiera", "Nuevo", "Como nuevo", "Buen estado", "Aceptable" });
            cboEstado.Location = new Point(72, 39);
            cboEstado.Margin = new Padding(3, 4, 3, 4);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(170, 28);
            cboEstado.TabIndex = 10;
            cboEstado.Visible = false;
            // 
            // cboTipos
            // 
            cboTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipos.FormattingEnabled = true;
            cboTipos.Items.AddRange(new object[] { "Cualquiera", "Herramientas", "Muebles", "Jardineria", "Electrodomesticos", "Hogar", "Libros, peliculas y musica", "Videojuegos", "Joyas y accesorios", "Bolsos y equipajes", "Ropa y calzado de hombre", "Ropa y calzado de mujer", "Juguetes y juegos", "Bebés y niños", "Productos para mascotas", "Salud y belleza", "Telefonos celulares", "Electromica e informatica", "Deportes y actividades al aire libre", "Instrumentos musicales", "Arte y manualidades", "Antigüedades y articulos de colección", "Autopartes", "Bicicletas", "Viviendas en venta", "Alquileres", "Autos y camionetas", "Motocicletas", "Todoterreno", "Casas rodantes y caravanas", "Embarcaciónes", "Remolques", "Otros" });
            cboTipos.Location = new Point(3, 75);
            cboTipos.Margin = new Padding(3, 4, 3, 4);
            cboTipos.Name = "cboTipos";
            cboTipos.Size = new Size(281, 28);
            cboTipos.TabIndex = 4;
            cboTipos.Visible = false;
            // 
            // btnListo
            // 
            btnListo.Location = new Point(3, 111);
            btnListo.Margin = new Padding(3, 4, 3, 4);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(86, 31);
            btnListo.TabIndex = 3;
            btnListo.Text = "Listo";
            btnListo.UseVisualStyleBackColor = true;
            btnListo.Click += btnListo_Click;
            // 
            // flpProductos
            // 
            flpProductos.Dock = DockStyle.Bottom;
            flpProductos.Location = new Point(0, 209);
            flpProductos.Margin = new Padding(3, 4, 3, 4);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(893, 429);
            flpProductos.TabIndex = 5;
            // 
            // FormComprar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flowLayoutPanelSeleccionFiltro);
            Controls.Add(flowLayoutPanelFiltros);
            Controls.Add(flpProductos);
            Controls.Add(btnFiltros);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormComprar";
            Size = new Size(893, 485);
            flowLayoutPanelFiltros.ResumeLayout(false);
            panelCerrarFiltro.ResumeLayout(false);
            flowLayoutPanelBtnsFiltros.ResumeLayout(false);
            flowLayoutPanelSeleccionFiltro.ResumeLayout(false);
            flowLayoutPanelSeleccionFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnFiltros;
        private FlowLayoutPanel flowLayoutPanelFiltros;
        private Button btnListo;
        private ComboBox cboTipos;
        private FlowLayoutPanel flpProductos;
        private Button btnPrecio;
        private Button btnTipo;
        private Button btnEstado;
        private Button btnRestablecer;
        private Panel panelCerrarFiltro;
        private Button btnCerrarFiltros;
        private FlowLayoutPanel flowLayoutPanelBtnsFiltros;
        private FlowLayoutPanel flowLayoutPanelSeleccionFiltro;
        private TextBox txtPrecioMin;
        private TextBox txtPrecioMax;
        private ComboBox cboEstado;
        private Label lblPrecioMin;
        private Label lblPrecioMax;
    }
}