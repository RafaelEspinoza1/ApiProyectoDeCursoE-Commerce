using FormApiE_Commerce.DTOs;
using FormApiE_Commerce.UsersControls;
using FormApiE_Commerce.Views;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FormApiE_Commerce
{
    public partial class PaginaPrincipal : Form
    {
        private TokenData tokenData; // <-- guarda los datos del login
        public PaginaPrincipal(TokenData tokenData)
        {
            InitializeComponent();
            this.tokenData = tokenData;
            BtnInicio_Click(null, null);
            ConfigurarBotonesPorRol();
        }
        private void ConfigurarBotonesPorRol()
        {
            int rolId = ObtenerRolUsuario(tokenData.IdUsuario);

            switch (rolId)
            {
                case 1: // Administrador
                    btnDashboard_Vendedor.Visible = false;
                    break;
                case 2: // Vendedor
                    break;
                case 3: // Comprador
                    btnDashboard_Vendedor.Visible = false;
                    break;
            }
        }
        private int ObtenerRolUsuario(int idUsuario)
        {
            int rolId = 0;
            string connStr = "Server=RAFAELESPINOZA\\SQLSERVER2019;Database=ECommerce;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT IdRol FROM Usuarios WHERE IdUsuario = @IdUsuario", conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            rolId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el rol: " + ex.Message);
            }

            return rolId;
        }

        private void BtnRegistro_Vendedor_Click(object sender, EventArgs e)
        {

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

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
            "¿Estás seguro que deseas cerrar sesión?",
            "Cerrar sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                // Cancelar acción
                return;
            }
            // Sí: limpiar tokens y datos persistentes
            TokenDataStorage.Clear();
            // Mensaje de despedida
            MessageBox.Show("¡Vuelve pronto!", "Sesión cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir FormInicio
            FormInicio formInicio = new FormInicio();
            formInicio.Show();

            // Cerrar o esconder la página principal
            this.Hide(); // si prefieres mantenerlo en memoria
        }
    }
}
