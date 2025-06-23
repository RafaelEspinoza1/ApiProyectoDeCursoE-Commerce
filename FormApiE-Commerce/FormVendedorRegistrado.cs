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
    public partial class FormVendedorRegistrado : UserControl
    {

        public string ProductoUrl = "https://localhost:7221/api/Productos";
        public string ImagenProductoUrl = "https://localhost:7221/api/ImagenProductos";
        public string IngresosEcommerceUrl = "https://localhost:7221/api/IngresosECommerce";
        public FormVendedorRegistrado()

        {
            InitializeComponent();
            
        }

    }
}
