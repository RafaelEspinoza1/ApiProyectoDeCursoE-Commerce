namespace FormApiE_Commerce
{
    partial class DetallesProducto
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
            pictureBoxImagenesProducto = new PictureBox();
            btnAnteriorImagen = new Button();
            btnSiguienteImagen = new Button();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblTipo = new Label();
            lblEstado = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnComprar = new Button();
            btnConsultarAlVendedor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenesProducto).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxImagenesProducto
            // 
            
            pictureBoxImagenesProducto.Location = new Point(98, 24);
            pictureBoxImagenesProducto.Name = "pictureBoxImagenesProducto";
            pictureBoxImagenesProducto.Size = new Size(150, 150);
            pictureBoxImagenesProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenesProducto.TabIndex = 0;
            pictureBoxImagenesProducto.TabStop = false;
            // 
            // btnAnteriorImagen
            // 
            btnAnteriorImagen.BackColor = Color.Transparent;
            btnAnteriorImagen.Location = new Point(98, 73);
            btnAnteriorImagen.Name = "btnAnteriorImagen";
            btnAnteriorImagen.Size = new Size(28, 45);
            btnAnteriorImagen.TabIndex = 1;
            btnAnteriorImagen.Text = "<";
            btnAnteriorImagen.UseVisualStyleBackColor = false;
            btnAnteriorImagen.Click += btnAnterior_Click;
            // 
            // btnSiguienteImagen
            // 
            btnSiguienteImagen.BackColor = Color.Transparent;
            btnSiguienteImagen.Location = new Point(220, 73);
            btnSiguienteImagen.Name = "btnSiguienteImagen";
            btnSiguienteImagen.Size = new Size(28, 45);
            btnSiguienteImagen.TabIndex = 2;
            btnSiguienteImagen.Text = ">";
            btnSiguienteImagen.UseVisualStyleBackColor = false;
            btnSiguienteImagen.Click += btnSiguiente_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(3, 15);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(3, 30);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(3, 45);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(3, 60);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblNombre);
            flowLayoutPanel1.Controls.Add(lblPrecio);
            flowLayoutPanel1.Controls.Add(lblDescripcion);
            flowLayoutPanel1.Controls.Add(lblTipo);
            flowLayoutPanel1.Controls.Add(lblEstado);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 229);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(270, 125);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(141, 383);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(75, 23);
            btnComprar.TabIndex = 9;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnConsultarAlVendedor
            // 
            btnConsultarAlVendedor.Location = new Point(15, 190);
            btnConsultarAlVendedor.Name = "btnConsultarAlVendedor";
            btnConsultarAlVendedor.Size = new Size(143, 23);
            btnConsultarAlVendedor.TabIndex = 10;
            btnConsultarAlVendedor.Text = "Consultar al verndedor ";
            btnConsultarAlVendedor.UseVisualStyleBackColor = true;
            // 
            // DetallesProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 440);
            Controls.Add(btnConsultarAlVendedor);
            Controls.Add(btnComprar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAnteriorImagen);
            Controls.Add(btnSiguienteImagen);
            Controls.Add(pictureBoxImagenesProducto);
            Name = "DetallesProducto";
            Text = "DetallesProducto";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenesProducto).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImagenesProducto;
        private Button btnAnteriorImagen;
        private Button btnSiguienteImagen;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblTipo;
        private Label lblEstado;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnComprar;
        private Button btnConsultarAlVendedor;
    }
}