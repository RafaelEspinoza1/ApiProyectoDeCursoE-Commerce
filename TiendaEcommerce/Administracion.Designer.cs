namespace TiendaEcommerce
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            lblContraseña1 = new Label();
            txtContraseña1 = new TextBox();
            btnContraseña1 = new Button();
            groupBoxIngresar = new GroupBox();
            checkBoxContraseñaCorreoVisible = new CheckBox();
            btnIngresar = new Button();
            txtContraseñaAdmin = new TextBox();
            txtCorreoAdmin = new TextBox();
            lblContraseñaAdmin = new Label();
            lblCorreoAdmin = new Label();
            lblUsuarios = new Label();
            btnCerrar = new Button();
            checkBoxContraseña1Visible = new CheckBox();
            lblTitulo = new Label();
            btnCerrarSesion = new Button();
            dgvUsuarios = new DataGridView();
            dgvVendedores = new DataGridView();
            dgvCompras = new DataGridView();
            dgvProductos = new DataGridView();
            lblVendedores = new Label();
            lblCompras = new Label();
            lblProductos = new Label();
            dgvIngresosECommerce = new DataGridView();
            lblIngresos = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lblImagenesProducto = new Label();
            flpImagenes = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            lblIngresosECommece = new Label();
            progressBarCarga = new ProgressBar();
            btnRefrescar = new Button();
            groupBoxIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresosECommerce).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // lblContraseña1
            // 
            lblContraseña1.AutoSize = true;
            lblContraseña1.Location = new Point(105, 40);
            lblContraseña1.Name = "lblContraseña1";
            lblContraseña1.Size = new Size(67, 15);
            lblContraseña1.TabIndex = 0;
            lblContraseña1.Text = "Contraseña";
            // 
            // txtContraseña1
            // 
            txtContraseña1.Location = new Point(90, 58);
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size(100, 23);
            txtContraseña1.TabIndex = 1;
            // 
            // btnContraseña1
            // 
            btnContraseña1.Location = new Point(105, 87);
            btnContraseña1.Name = "btnContraseña1";
            btnContraseña1.Size = new Size(75, 23);
            btnContraseña1.TabIndex = 2;
            btnContraseña1.Text = "Ingresar";
            btnContraseña1.UseVisualStyleBackColor = true;
            btnContraseña1.Click += btnContraseña1_Click;
            // 
            // groupBoxIngresar
            // 
            groupBoxIngresar.Controls.Add(checkBoxContraseñaCorreoVisible);
            groupBoxIngresar.Controls.Add(btnIngresar);
            groupBoxIngresar.Controls.Add(txtContraseñaAdmin);
            groupBoxIngresar.Controls.Add(txtCorreoAdmin);
            groupBoxIngresar.Controls.Add(lblContraseñaAdmin);
            groupBoxIngresar.Controls.Add(lblCorreoAdmin);
            groupBoxIngresar.Location = new Point(12, 40);
            groupBoxIngresar.Name = "groupBoxIngresar";
            groupBoxIngresar.Size = new Size(244, 100);
            groupBoxIngresar.TabIndex = 3;
            groupBoxIngresar.TabStop = false;
            groupBoxIngresar.Text = "Admin";
            groupBoxIngresar.Visible = false;
            // 
            // checkBoxContraseñaCorreoVisible
            // 
            checkBoxContraseñaCorreoVisible.AutoSize = true;
            checkBoxContraseñaCorreoVisible.BackgroundImageLayout = ImageLayout.None;
            checkBoxContraseñaCorreoVisible.Location = new Point(222, 49);
            checkBoxContraseñaCorreoVisible.Name = "checkBoxContraseñaCorreoVisible";
            checkBoxContraseñaCorreoVisible.Size = new Size(15, 14);
            checkBoxContraseñaCorreoVisible.TabIndex = 19;
            checkBoxContraseñaCorreoVisible.UseVisualStyleBackColor = true;
            checkBoxContraseñaCorreoVisible.CheckedChanged += checkBoxContraseñaCorreoVisible_CheckedChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(78, 71);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContraseñaAdmin
            // 
            txtContraseñaAdmin.Location = new Point(116, 40);
            txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            txtContraseñaAdmin.Size = new Size(100, 23);
            txtContraseñaAdmin.TabIndex = 3;
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(116, 11);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(100, 23);
            txtCorreoAdmin.TabIndex = 2;
            // 
            // lblContraseñaAdmin
            // 
            lblContraseñaAdmin.AutoSize = true;
            lblContraseñaAdmin.Location = new Point(11, 48);
            lblContraseñaAdmin.Name = "lblContraseñaAdmin";
            lblContraseñaAdmin.Size = new Size(67, 15);
            lblContraseñaAdmin.TabIndex = 1;
            lblContraseñaAdmin.Text = "Contraseña";
            // 
            // lblCorreoAdmin
            // 
            lblCorreoAdmin.AutoSize = true;
            lblCorreoAdmin.Location = new Point(11, 19);
            lblCorreoAdmin.Name = "lblCorreoAdmin";
            lblCorreoAdmin.Size = new Size(99, 15);
            lblCorreoAdmin.TabIndex = 0;
            lblCorreoAdmin.Text = "Correo del admin";
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Location = new Point(19, 3);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(52, 15);
            lblUsuarios.TabIndex = 29;
            lblUsuarios.Text = "Usuarios";
            // 
            // btnCerrar
            // 
            
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(246, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 13;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // checkBoxContraseña1Visible
            // 
            checkBoxContraseña1Visible.AutoSize = true;
            checkBoxContraseña1Visible.BackgroundImageLayout = ImageLayout.None;
            checkBoxContraseña1Visible.Location = new Point(196, 67);
            checkBoxContraseña1Visible.Name = "checkBoxContraseña1Visible";
            checkBoxContraseña1Visible.Size = new Size(15, 14);
            checkBoxContraseña1Visible.TabIndex = 18;
            checkBoxContraseña1Visible.UseVisualStyleBackColor = true;
            checkBoxContraseña1Visible.CheckedChanged += checkBoxContraseña1Visible_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(101, 23);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "E-Commerce";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Firebrick;
            btnCerrarSesion.Location = new Point(576, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(114, 27);
            btnCerrarSesion.TabIndex = 20;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(8, 21);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(651, 180);
            dgvUsuarios.TabIndex = 21;
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(8, 222);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.Size = new Size(852, 180);
            dgvVendedores.TabIndex = 23;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(8, 21);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.Size = new Size(1346, 180);
            dgvCompras.TabIndex = 24;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(8, 21);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(955, 180);
            dgvProductos.TabIndex = 25;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // lblVendedores
            // 
            lblVendedores.AutoSize = true;
            lblVendedores.Location = new Point(19, 204);
            lblVendedores.Name = "lblVendedores";
            lblVendedores.Size = new Size(68, 15);
            lblVendedores.TabIndex = 26;
            lblVendedores.Text = "Vendedores";
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Location = new Point(19, 3);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(55, 15);
            lblCompras.TabIndex = 27;
            lblCompras.Text = "Compras";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(19, 3);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(61, 15);
            lblProductos.TabIndex = 28;
            lblProductos.Text = "Productos";
            // 
            // dgvIngresosECommerce
            // 
            dgvIngresosECommerce.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresosECommerce.Location = new Point(8, 222);
            dgvIngresosECommerce.Name = "dgvIngresosECommerce";
            dgvIngresosECommerce.Size = new Size(651, 180);
            dgvIngresosECommerce.TabIndex = 30;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(19, 204);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(51, 15);
            lblIngresos.TabIndex = 31;
            lblIngresos.Text = "Ingresos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1370, 594);
            tabControl1.TabIndex = 32;
            tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblVendedores);
            tabPage1.Controls.Add(dgvUsuarios);
            tabPage1.Controls.Add(lblUsuarios);
            tabPage1.Controls.Add(dgvVendedores);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 566);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblImagenesProducto);
            tabPage2.Controls.Add(flpImagenes);
            tabPage2.Controls.Add(dgvProductos);
            tabPage2.Controls.Add(lblProductos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1362, 566);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Productos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblImagenesProducto
            // 
            lblImagenesProducto.AutoSize = true;
            lblImagenesProducto.Location = new Point(19, 227);
            lblImagenesProducto.Name = "lblImagenesProducto";
            lblImagenesProducto.Size = new Size(276, 15);
            lblImagenesProducto.TabIndex = 30;
            lblImagenesProducto.Text = "Seleccione un producto para mostrar sus imagenes";
            // 
            // flpImagenes
            // 
            flpImagenes.Location = new Point(8, 245);
            flpImagenes.Name = "flpImagenes";
            flpImagenes.Size = new Size(522, 145);
            flpImagenes.TabIndex = 29;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblIngresosECommece);
            tabPage3.Controls.Add(dgvCompras);
            tabPage3.Controls.Add(dgvIngresosECommerce);
            tabPage3.Controls.Add(lblCompras);
            tabPage3.Controls.Add(lblIngresos);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1362, 566);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Transacciones";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblIngresosECommece
            // 
            lblIngresosECommece.AutoSize = true;
            lblIngresosECommece.Location = new Point(8, 415);
            lblIngresosECommece.Name = "lblIngresosECommece";
            lblIngresosECommece.Size = new Size(181, 15);
            lblIngresosECommece.TabIndex = 32;
            lblIngresosECommece.Text = "Ingresos totales de E-Commerce:";
            // 
            // progressBarCarga
            // 
            progressBarCarga.Location = new Point(119, 9);
            progressBarCarga.MarqueeAnimationSpeed = 30;
            progressBarCarga.Name = "progressBarCarga";
            progressBarCarga.Size = new Size(100, 23);
            progressBarCarga.Style = ProgressBarStyle.Marquee;
            progressBarCarga.TabIndex = 33;
            progressBarCarga.Visible = false;
            // 
            // btnRefrescar
            // 
           
            btnRefrescar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefrescar.Location = new Point(539, 1);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(31, 31);
            btnRefrescar.TabIndex = 34;
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 632);
            Controls.Add(btnRefrescar);
            Controls.Add(progressBarCarga);
            Controls.Add(tabControl1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblTitulo);
            Controls.Add(btnCerrar);
            Controls.Add(groupBoxIngresar);
            Controls.Add(btnContraseña1);
            Controls.Add(txtContraseña1);
            Controls.Add(lblContraseña1);
            Controls.Add(checkBoxContraseña1Visible);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Administracion";
            Text = "Administrador";
            groupBoxIngresar.ResumeLayout(false);
            groupBoxIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngresosECommerce).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContraseña1;
        private TextBox txtContraseña1;
        private Button btnContraseña1;
        private GroupBox groupBoxIngresar;
        private TextBox txtContraseñaAdmin;
        private TextBox txtCorreoAdmin;
        private Label lblContraseñaAdmin;
        private Label lblCorreoAdmin;
        private Button btnIngresar;
        private Button btnCerrar;
        private CheckBox checkBoxContraseñaCorreoVisible;
        private CheckBox checkBoxContraseña1Visible;
        private Label lblTitulo;
        private Button btnCerrarSesion;
        private DataGridView dgvUsuarios;
        private DataGridView dgvVendedores;
        private DataGridView dgvCompras;
        private DataGridView dgvProductos;
        private Label lblUsuarios;
        private Label lblVendedores;
        private Label lblCompras;
        private Label lblProductos;
        private DataGridView dgvIngresosECommerce;
        private Label lblIngresos;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblIngresosECommece;
        private ProgressBar progressBarCarga;
        private Button btnRefrescar;
        private Label lblImagenesProducto;
        private FlowLayoutPanel flpImagenes;
    }
}