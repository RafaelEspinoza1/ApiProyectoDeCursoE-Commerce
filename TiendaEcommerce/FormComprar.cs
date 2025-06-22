using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaEcommerce
{
    public partial class FormComprar : UserControl
    {
        
        int UsuarioId = FormInicio.UsuarioId; // Asumiendo que tienes una forma de obtener el ID del usuario actual


        string filtroTipo = "Cualquiera";
        string filtroEstado = "Cualquiera";
        decimal? filtroPrecioMin = null;
        decimal? filtroPrecioMax = null;
        public FormComprar()
        {
            InitializeComponent();
            MostrarProductosAleatorios();
            if (cboTipos.Items.Count > 0)
            {
                cboTipos.SelectedIndex = 0;
            }
            if (cboEstado.Items.Count > 0)
            {
                cboEstado.SelectedIndex = 0;
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFiltros.Visible = true;
            btnBuscar.Enabled = false;
            btnFiltros.Visible = false;
        }


        private void MostrarProductosAleatorios()
        {
            flpProductos.Controls.Clear(); // Limpia cualquier control anterior

            // Obtener el ID del usuario actual desde FormInicio
            int idUsuarioActual = FormInicio.UsuarioId;

            // Obtener productos con al menos una imagen
            //var productosConImagen = db.Productos
            //    .Include(p => p.Imagenes)
            //    .Include(p => p.Vendedor)
            //    .Where(p => p.Imagenes.Any() && p.Vendedor.UsuarioId != idUsuarioActual && p.Cantidad >= 1)
            //    .ToList();

            // Mezclar aleatoriamente y tomar 10 sin repetir
            //var random = new Random();
            //var productosAleatorios = productosConImagen
            //    .OrderBy(x => random.Next())
            //    .Take(10)
            //    .ToList();

            //foreach (var producto in productosAleatorios)
            //{
            //    MostrarProductoEnFlowLayout(producto);
            //}
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            flowLayoutPanelSeleccionFiltro.Visible = true;
            cboTipos.Visible = true;
            flowLayoutPanelFiltros.Visible = false;
        }

        private void btnCerrarFiltros_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnFiltros.Visible = true;
            flowLayoutPanelFiltros.Visible = false;
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            flowLayoutPanelSeleccionFiltro.Visible = true;
            lblPrecioMin.Visible = true;
            txtPrecioMin.Visible = true;
            lblPrecioMax.Visible = true;
            txtPrecioMax.Visible = true;
            flowLayoutPanelFiltros.Visible = false;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            flowLayoutPanelSeleccionFiltro.Visible = true;
            cboEstado.Visible = true;
            flowLayoutPanelFiltros.Visible = false;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            // Tipo
            if (cboTipos.Visible && cboTipos.SelectedItem != null)
                filtroTipo = cboTipos.SelectedItem.ToString();

            // Estado
            if (cboEstado.Visible && cboEstado.SelectedItem != null)
                filtroEstado = cboEstado.SelectedItem.ToString();

            // Precio mínimo
            filtroPrecioMin = null;
            if (txtPrecioMin.Visible && decimal.TryParse(txtPrecioMin.Text.Trim(), out decimal min))
                filtroPrecioMin = min >= 0 ? min : null;

            // Precio máximo
            filtroPrecioMax = null;
            if (txtPrecioMax.Visible && decimal.TryParse(txtPrecioMax.Text.Trim(), out decimal max))
                filtroPrecioMax = max >= 0 ? max : null;

            MessageBox.Show("Filtros aplicados temporalmente.", "Filtros", MessageBoxButtons.OK, MessageBoxIcon.Information);


            flowLayoutPanelSeleccionFiltro.Visible = false;
            flowLayoutPanelFiltros.Visible = true;
            txtPrecioMax.Visible = false;
            txtPrecioMin.Visible = false;
            cboTipos.Visible = false;
            cboEstado.Visible = false;
            lblPrecioMax.Visible = false;
            lblPrecioMin.Visible = false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            filtroTipo = "Cualquiera";
            filtroEstado = "Cualquiera";
            filtroPrecioMin = null;
            filtroPrecioMax = null;

            cboTipos.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            txtPrecioMin.Clear();
            txtPrecioMax.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // string nombreBusqueda = txtBuscar.Text.Trim();

           // var productos = db.Productos
           //.Include(p => p.Imagenes)
           //.Include(p => p.Vendedor)
           // .AsQueryable();

           // // Buscar por nombre (contiene)
           // if (!string.IsNullOrWhiteSpace(nombreBusqueda))
           //     productos = productos.Where(p => p.NombreProducto.Contains(nombreBusqueda));

           // // Filtrar por tipo si no es "Cualquiera"
           // if (filtroTipo != "Cualquiera")
           //     productos = productos.Where(p => p.Tipo == filtroTipo);

           // // Filtrar por estado si no es "Cualquiera"
           // if (filtroEstado != "Cualquiera")
           //     productos = productos.Where(p => p.Estado == filtroEstado);

           // // Filtrar por precio mínimo
           // if (filtroPrecioMin.HasValue)
           //     productos = productos.Where(p => p.Precio >= filtroPrecioMin.Value);

           // // Filtrar por precio máximo
           // if (filtroPrecioMax.HasValue)
           //     productos = productos.Where(p => p.Precio <= filtroPrecioMax.Value);

           // productos = productos.Where(p => p.Vendedor.UsuarioId != UsuarioId && p.Cantidad <= 1);
           // // Mostrar resultados
           // flpProductos.Controls.Clear();

           // foreach (var producto in productos.Include(p => p.Imagenes).ToList())
           // {
           //     MostrarProductoEnFlowLayout(producto);
           // }

        }
        // MÉTODO PARA VALIDAR SOLO NÚMEROS POSITIVOS EN TextBox
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Solo un punto decimal
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        private void MostrarProductoEnFlowLayout(Productos producto)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Width = 154;
            groupBox.Height = 150;
            groupBox.Text = "";
            Tag = producto.ProductoId; // Guarda el ID del producto

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 140;
            pictureBox.Height = 100;
            pictureBox.Top = 10;
            pictureBox.Left = 7;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Tag = producto.ProductoId; // Guarda el ID del producto

            //var imagenBytes = producto.Imagenes.FirstOrDefault()?.Imagen;
            //if (imagenBytes != null)
            //{
            //    using (var ms = new MemoryStream(imagenBytes))
            //    {
            //        pictureBox.Image = Image.FromStream(ms);
            //    }
            //}

            Label lbl = new Label();
            lbl.Width = 140;
            lbl.Height = 40;
            lbl.Top = 110;
            lbl.Left = 7;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Text = $"{producto.NombreProducto}\n{producto.Precio:C2}";
            Tag = producto.ProductoId; // Guarda el ID del producto

            // Asignar evento de doble clic
            groupBox.DoubleClick += AbrirDetallesProducto;
            pictureBox.DoubleClick += AbrirDetallesProducto;
            lbl.DoubleClick += AbrirDetallesProducto;

            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(lbl);

            flpProductos.Controls.Add(groupBox);
        }
        private void AbrirDetallesProducto(object sender, EventArgs e)
        {
            int productoId = 0;

            if (sender is Control control && control.Tag != null)
            {
                productoId = (int)control.Tag;

                DetallesProducto detallesForm = new DetallesProducto(productoId);
                detallesForm.ShowDialog();
            }
        }

    }
}
