using FormApiE_Commerce.DTOs.ComprasDTOs;
using FormApiE_Commerce.DTOs.IngresosECommerceDTOs;
using FormApiE_Commerce.DTOs.ProductoDTOs;
using FormApiE_Commerce.DTOs.UsuariosDTOs;
using FormApiE_Commerce.DTOs.VendedoresDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FormApiE_Commerce
{
    public partial class Administracion : Form
    {
        public string UsuariosUrl = "https://localhost:7221/api/Usuarios";
        public string VendedoresUrl = "https://localhost:7221/api/Vendedores";
        public string ProductosUrl = "https://localhost:7221/api/Productos";
        public string ImagenProducto = "https://localhost:7221/api/ImagenProductos";
        public string ComprasUrl = "https://localhost:7221/api/Compras";
        public string IngresosEcommerceUrl = "https://localhost:7221/api/IngresosECommerce";
        public string AdministradorUrl = "https://localhost:7221/api/Administrador";

        HttpClient client = new HttpClient();
        public Administracion()
        {
            InitializeComponent();
            txtContraseña1.UseSystemPasswordChar = true;
            txtContraseña1.ContextMenuStrip = null; // Desactiva click derecho
            txtContraseña1.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
            txtContraseñaAdmin.UseSystemPasswordChar = true;
            txtContraseñaAdmin.ContextMenuStrip = null; // Desactiva click derecho
            txtContraseñaAdmin.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
            flpImagenes.AutoScroll = true;


        }
        private async void CargarDatos()
        {
            var usuarios = await client.GetFromJsonAsync<List<UsuariosReadDTO>>(UsuariosUrl);
            dgvUsuarios.DataSource = usuarios;

            var vendedores = await client.GetFromJsonAsync<List<VendedoresReadDTO>>(VendedoresUrl);
            dgvVendedores.DataSource = vendedores;

            var productos = await client.GetFromJsonAsync<List<ProductoReadDTO>>(ProductosUrl);
            dgvProductos.DataSource = productos;

            var compras = await client.GetFromJsonAsync<List<ComprasReadDTO>>(ComprasUrl);
            dgvCompras.DataSource = compras;

            var ingresos = await client.GetFromJsonAsync<List<IngresosECommerceReadDTO>>(IngresosEcommerceUrl);
            dgvIngresosECommerce.DataSource = ingresos;
        }

        private void btnContraseña1_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña1.Text.Trim();
            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contraseña.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña1.Focus();
                return;
            }
            if (contraseña != "12345678")
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña1.Focus();
                return;
            }
            MessageBox.Show("Contraseña correcta. Ingrese el correo y contraseña de el administrador.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBoxIngresar.Visible = true;
            btnContraseña1.Visible = false;
            txtContraseña1.Visible = false;
            lblContraseña1.Visible = false;
            checkBoxContraseña1Visible.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "FormInicio";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var administrador = db.Administrador.FirstOrDefault(a => a.Contraseña == txtContraseñaAdmin.Text && a.Correo == txtCorreoAdmin.Text);
            //    if (string.IsNullOrWhiteSpace(txtContraseñaAdmin.Text)|| string.IsNullOrWhiteSpace(txtCorreoAdmin.Text))
            //    {
            //        MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (administrador == null)
            //    {
            //        MessageBox.Show("Correo o contraseña incorrectos. Si no es el admin no va a lograr entrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    MessageBox.Show("Cargando datos, espere un momento...", "Cargando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarCarga.Visible = true;

                await Task.Run(() =>
                {
                    // Llamamos al método que ya tenés
                    CargarDatos();
                    Invoke((MethodInvoker)CargarDatos); // Esto asegura que los DataGridView se actualicen en el hilo de la UI
                });

                progressBarCarga.Visible = false;

                MessageBox.Show("Datos cargados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(1386, 671);
               groupBoxIngresar.Visible = false;
               btnCerrar.Visible = false;
               tabControl1.Visible = true;
            //}
            //catch (Exception ex)
            //{
            //    progressBarCarga.Visible = false;
            //    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            

        }
        private void checkBoxContraseña1Visible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseña1Visible.Checked)
            {
                // Mostrar el texto
                txtContraseña1.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContraseña1.UseSystemPasswordChar = true;
            }
        }
        private void checkBoxContraseñaCorreoVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseñaCorreoVisible.Checked)
            {
                // Mostrar el texto
                txtContraseñaAdmin.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContraseñaAdmin.UseSystemPasswordChar = true;
            }
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtener el ID del producto seleccionado
                int productoId = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ProductoId"].Value);

                // Llamar método para mostrar imágenes
                MostrarImagenesProducto(productoId);
                lblImagenesProducto.Text = "Imágenes del producto seleccionado:"; 
            }
        }
        private void MostrarImagenesProducto(int productoId)
        {
            // Limpiar imágenes anteriores
            flpImagenes.Controls.Clear();

            // Obtener las imágenes del producto desde la base de datos
            //var imagenes = db.ImagenesProducto
            //                 .Where(img => img.ProductoId == productoId)
            //                 .ToList();

            //foreach (var imagen in imagenes)
            //{
            //    PictureBox pic = new PictureBox();
            //    pic.SizeMode = PictureBoxSizeMode.Zoom;
            //    pic.Width = 120;
            //    pic.Height = 120;

            //    // Cargar imagen desde byte[]
            //    using (var ms = new MemoryStream(imagen.Imagen))
            //    {
            //        pic.Image = Image.FromStream(ms);
            //    }

            //    // Guardar los bytes en el Tag para mostrarlos ampliados al hacer clic
            //    pic.Tag = imagen.Imagen;
            //    pic.Cursor = Cursors.Hand;
            //    pic.Click += Pic_Click;

            //    flpImagenes.Controls.Add(pic);
            //}
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic?.Tag is byte[] imagenBytes)
            {
                using (var ms = new MemoryStream(imagenBytes))
                {
                    Image imagenGrande = Image.FromStream(ms);

                    Form frmImagen = new Form();
                    frmImagen.Text = "Vista ampliada";
                    frmImagen.Width = 800;
                    frmImagen.Height = 600;

                    PictureBox picGrande = new PictureBox();
                    picGrande.Dock = DockStyle.Fill;
                    picGrande.SizeMode = PictureBoxSizeMode.Zoom;
                    picGrande.Image = imagenGrande;

                    frmImagen.Controls.Add(picGrande);
                    frmImagen.ShowDialog();
                }
            }
        }


    }
}
