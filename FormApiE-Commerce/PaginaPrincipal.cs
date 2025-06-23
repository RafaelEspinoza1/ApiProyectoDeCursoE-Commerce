using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.Net.Http.Json;
using FormApiE_Commerce.Models;



namespace FormApiE_Commerce
{
    public partial class PaginaPrincipal : Form
    {


        public Vendedores vendedor = new Vendedores();
        public PaginaPrincipal()
        {
            InitializeComponent();
            MostrarFormularioEnTabPage();
        }
        // Cierra el formulario y abre el formulario FormInicio.
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var cerrar = MessageBox.Show("Seguro que desea cerrar seción?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cerrar == DialogResult.Yes)
                {
                    MessageBox.Show("E-Commerce le desea buen dia, vuelva pronto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Tag = "FormInicio";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            btnMenu.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            btnMenu.Visible = true;
        }
        public async void MostrarFormularioEnTabPage()
        {
            FormComprar formComprar = new FormComprar();
            formComprar.Dock = DockStyle.Fill;
            tabPageComprar.Controls.Clear();
            tabPageComprar.Controls.Add(formComprar);
            formComprar.Show();

            try
            {
                int usuarioId = FormInicio.UsuarioId;

                // Llamar a la API para obtener si es vendedor


                tabPageVender.Controls.Clear();

                if (vendedor != null)
                {
                    // Ya es vendedor
                    FormVendedorRegistrado interfaz = new FormVendedorRegistrado(); // este es un UserControl
                    interfaz.Dock = DockStyle.Fill;
                    tabPageVender.Controls.Add(interfaz);
                }
                else
                {
                    // No es vendedor
                    Vender registro = new Vender(); // este es el formulario de registro
                    registro.Dock = DockStyle.Fill;
                    tabPageVender.Controls.Add(registro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnChatBot_Click(object sender, EventArgs e)
        {
            Chatbot chatbot = new Chatbot();
            chatbot.Show();
        }
    }
}
