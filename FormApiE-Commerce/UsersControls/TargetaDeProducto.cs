using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApiE_Commerce.UsersControls
{
    public partial class TargetaDeProducto : UserControl
    {
        public TargetaDeProducto()
        {
            InitializeComponent();
        }

        //public void CargarDatos(Producto producto)
        //{
        //    // 1. Mapeo de textos básicos
        //    lblNombre.Text = producto.Nombre;
        //    lblPrecio.Text = producto.Precio.ToString("C"); // Formato moneda ($)

        //    // 2. Convertir el ID de estado a Texto (Puedes ajustar los casos según tu BD)
        //    lblEstado.Text = ObtenerNombreEstado(producto.IdEstadoProducto);

            // 3. Cargar Imagen desde URL (Web)
            // Verificamos si la lista de imágenes existe y tiene al menos una
            /* if (producto.Imagenes != null && producto.Imagenes.Count > 0)
             {
                 string urlImagen = producto.Imagenes.First().URLImagen;

                 // Solución: Descargar la imagen manualmente y asignarla a Content
                 try
                 {
                     using (var webClient = new System.Net.WebClient())
                     {
                         using (var stream = webClient.OpenRead(urlImagen))
                         {
                             picImagen.Content = Image.FromStream(stream);
                         }
                     }
                 }
                 catch
                 {
                     // Si la URL falla, poner imagen de error o dejar vacío
                     picImagen.Content = null;
                 }
             }
             else
             {
                 // Imagen por defecto si la lista está vacía
                 // picImagen.Image = Properties.Resources.placeholder; 
                 picImagen.BackColor = Color.LightGray; // O un color gris de fondo
             }*/
        }

        private string ObtenerNombreEstado(int idEstado)
        {
            // Ajusta estos IDs a los que tengas en tu base de datos real
            switch (idEstado)
            {
                case 1: return "Nuevo";
                case 2: return "Usado";
                case 3: return "Reacondicionado";
                default: return "Disponible";
            }
        }
    }

}

