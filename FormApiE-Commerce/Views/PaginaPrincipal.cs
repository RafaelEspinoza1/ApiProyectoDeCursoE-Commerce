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
using FormApiE_Commerce.DTOs;
using FormApiE_Commerce.Views;
using FormApiE_Commerce.UsersControls;



namespace FormApiE_Commerce
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal(bool Inicio)
        {
            InitializeComponent();

            if (Inicio)
            {
                CargarInicio();
            }
        }


        private void BtnRegistro_Vendedor_Click(object sender, EventArgs e)
        {

        }

        private void CargarInicio()
        {
            try
            {
                // Verificar si ya hay una instancia de FuncionComprar en el panel
                var existente = pnlGenerico.Controls.OfType<funcionComprar>().FirstOrDefault();
                if (existente != null)
                {
                    existente.BringToFront();
                    return;
                }

                // Si hay cualquier otro control (otro formulario), sustituirlo
                if (pnlGenerico.Controls.Count > 0)
                {
                    // Dispose y limpiar para liberar recursos
                    foreach (Control c in pnlGenerico.Controls.OfType<Control>().ToList())
                    {
                        pnlGenerico.Controls.Remove(c);
                        c.Dispose();
                    }
                }

                // Crear y configurar el formulario FuncionComprar
                funcionComprar compraForm = new funcionComprar
                {
                    Dock = DockStyle.Fill
                };

                // Agregar al panel y mostrar
                pnlGenerico.Controls.Add(compraForm);
                compraForm.Show();
                compraForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la función Comprar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar una instancia ya agregada
                var existente = pnlGenerico.Controls.OfType<Analisis_Financieros>().FirstOrDefault();
                if (existente != null)
                {
                    // Si ya existe, traer al frente y asegurarse de que esté visible
                    existente.BringToFront();
                    return;
                }

                // Limpiar panel (opcional, evita múltiples formularios)
                pnlGenerico.Controls.Clear();

                // Crear y configurar el formulario hijo
                Analisis_Financieros analisisForm = new Analisis_Financieros
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                // Agregar al panel y mostrar
                pnlGenerico.Controls.Add(analisisForm);
                analisisForm.Show();
                analisisForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Análisis Financieros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnInicio_Click(object sender, EventArgs e)
        {
            CargarInicio();
        }

        private void btnDashboard_Vendedor_Click(object sender, EventArgs e)
        {

        }
    }
}
