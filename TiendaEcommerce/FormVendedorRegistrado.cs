using ApiProyectoDeCursoE_Commerce.Data;
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
    public partial class FormVendedorRegistrado : UserControl
    {
        public FormVendedorRegistrado()
        {
            InitializeComponent();
        }

        private void FormVendedorRegistrado_Load(object sender, EventArgs e)
        {
            //using (var db = new ECommerceContext())
            //{
            //    var usuario = db.Usuarios.FirstOrDefault(u => u.UsuarioId == FormInicio.UsuarioId);
            //    if (usuario != null)
            //    {
            //        lblSaludo.Text = $"HOLA DE NUEVO, {usuario.Nombre}!";
            //    }
            //}

        }
    }
}
