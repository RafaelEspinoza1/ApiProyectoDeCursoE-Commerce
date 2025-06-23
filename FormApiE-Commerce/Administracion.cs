using FormApiE_Commerce.DTOs.AdministradorDTOs;
using FormApiE_Commerce.DTOs.ComprasDTOs;
using FormApiE_Commerce.DTOs.ImagenProductoDTOS;
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
            client.DefaultRequestHeaders.Remove("admin-password");
            client.DefaultRequestHeaders.Add("admin-password", "12345678");
        }
        private async Task CargarDatos()
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

            lblIngresosECommece.Text = "Ingresos E-Commerce: " + ingresos.Sum(i => i.Cantidad).ToString("C");
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
            string correo = txtCorreoAdmin.Text.Trim();
            string contraseña = txtContraseñaAdmin.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Traer todos los administradores (o hacer un endpoint de login si lo tenés)
                var admins = await client.GetFromJsonAsync<List<AdministradorReadDTO>>(AdministradorUrl);

                var adminEncontrado = admins.FirstOrDefault(a => a.Correo == correo && a.Contraseña == contraseña);

                if (adminEncontrado == null)
                {
                    MessageBox.Show("Correo o contraseña incorrectos. Solo el administrador puede ingresar.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Cargando datos, espere un momento...", "Cargando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarCarga.Visible = true;

                await CargarDatos();

                progressBarCarga.Visible = false;

                MessageBox.Show("Datos cargados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(1386, 671);
                groupBoxIngresar.Visible = false;
                btnCerrar.Visible = false;
                tabControl1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la API: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            progressBarCarga.Visible = true;
            await CargarDatos();
            progressBarCarga.Visible = false;
            MessageBox.Show("Datos cargados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async void MostrarImagenesProducto(int productoId)
        {
            try
            {
                flpImagenes.Controls.Clear(); // Limpiar las imágenes anteriores

                // Obtener la lista de imágenes del producto desde la API
                var imagenes = await client.GetFromJsonAsync<List<ImagenProductoReadDTO>>($"{ImagenProducto}/PorProducto/{productoId}");


                foreach (var img in imagenes)
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Width = 120;
                    pic.Height = 120;
                    pic.Cursor = Cursors.Hand;

                    // Cargar imagen desde la URL
                    pic.LoadAsync(img.ImagenUrl);

                    // Guardar la URL en el Tag para mostrar en grande después
                    pic.Tag = img.ImagenUrl;
                    pic.Click += Pic_Click;

                    flpImagenes.Controls.Add(pic);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imágenes: " + ex.Message);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pic && pic.Tag is string url)
            {
                Form frmImagen = new Form();
                frmImagen.Text = "Vista ampliada";
                frmImagen.Width = 800;
                frmImagen.Height = 600;

                PictureBox picGrande = new PictureBox();
                picGrande.Dock = DockStyle.Fill;
                picGrande.SizeMode = PictureBoxSizeMode.Zoom;
                picGrande.Load(url);

                frmImagen.Controls.Add(picGrande);
                frmImagen.ShowDialog();
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productoId = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ProductoId"].Value);
                MostrarImagenesProducto(productoId);
                lblImagenesProducto.Text = "Imágenes del producto seleccionado:";
            }
        }

    }
}
