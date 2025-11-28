using FormApiE_Commerce.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApiE_Commerce.Views
{
    public partial class Registro_para_Vendedores : Form
    {
        public RegistrarVendedorDTO? datosVendedor { get; private set; }
        private bool esContribuyente = false;

        public Registro_para_Vendedores()
        {
            InitializeComponent();
        }

        private void cuiLabel3_Load(object sender, EventArgs e)
        {

        }

        private void cuiLabel9_Load(object sender, EventArgs e)
        {

        }

        private void btnEsContribuyente_Click(object sender, EventArgs e)
        {
            esContribuyente = true;
        }

        private void btnNoEsContribuyente_Click(object sender, EventArgs e)
        {
            esContribuyente = true;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Crear el DTO con los datos ingresados
            datosVendedor = new RegistrarVendedorDTO
            {
                NombreNegocio = txtNombreNegocio.contentTextField.Text,
                DescripcionNegocio = txtDescripcionNegocio.contentTextField.Text,
                LogoNegocio = "",
                EsContribuyente = esContribuyente
            };

            // Marcar el resultado y cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
