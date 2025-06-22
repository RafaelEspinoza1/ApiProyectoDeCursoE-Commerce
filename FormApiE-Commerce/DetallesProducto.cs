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

namespace FormApiE_Commerce
{
    public partial class DetallesProducto: Form
    {
        
        private List<byte[]> imagenes;
        private int imagenActual = 0;
        public DetallesProducto(int productoId)
        {
            InitializeComponent();
            CargarProducto(productoId);
        }
        private void CargarProducto(int productoId)
        {
            //var producto = db.Productos
            //    .Include(p => p.Imagenes)
            //    .FirstOrDefault(p => p.ProductoId == productoId);

            //if (producto != null)
            //{
            //    // Mostrar detalles
            //    lblNombre.Text = "Nombre: " + producto.NombreProducto;
            //    lblDescripcion.Text = "Descripción: " + producto.Descripcion;
            //    lblPrecio.Text = "Precio: " + producto.Precio.ToString("C2");
            //    lblTipo.Text = "Tipo: " + producto.Tipo;
            //    lblEstado.Text = "Estado: " + producto.Estado;

            //    // Cargar imágenes
            //    imagenes = producto.Imagenes.Select(i => i.Imagen).ToList();

            //    if (imagenes.Count > 0)
            //    {
            //        MostrarImagen();

            //        btnAnteriorImagen.Visible = btnSiguienteImagen.Visible = imagenes.Count > 1;
            //        btnAnteriorImagen.Enabled = false;
            //        btnSiguienteImagen.Enabled = imagenes.Count > 1;
            //    }
            //    else
            //    {
            //        pictureBoxImagenesProducto.Image = null;
            //        btnAnteriorImagen.Visible = btnSiguienteImagen.Visible = false;
            //    }
        //}
        }

        private void MostrarImagen()
        {
            using (var ms = new MemoryStream(imagenes[imagenActual]))
            {
                pictureBoxImagenesProducto.Image = Image.FromStream(ms);
            }

            // Habilita/deshabilita botones
            btnAnteriorImagen.Enabled = imagenActual > 0;
            btnSiguienteImagen.Enabled = imagenActual < imagenes.Count - 1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenActual > 0)
            {
                imagenActual--;
                MostrarImagen();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenActual < imagenes.Count - 1)
            {
                imagenActual++;
                MostrarImagen();
            }
        }
    }
}
