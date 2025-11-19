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
    public partial class Inicio_de_Sesion : UserControl
    {
        private ApiClient apiClient = new ApiClient();

        // Evento para notificar al formulario principal
        public event Action<string>? OnLoginSuccess;
        public Inicio_de_Sesion()
        {
            InitializeComponent();
        }

        private async Task<string?> LoginUser(string correo, string contraseña, string? token)
        {
            using (var httpClient = new HttpClient())
            {
                var url = "http://localhost:5028/api/Auth/login";

                var loginData = new
                {
                    Correo = correo,
                    Contraseña = contraseña,
                    Token = token
                };

                var json = System.Text.Json.JsonSerializer.Serialize(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(url, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Credenciales incorrectas o error: {response.StatusCode}");
                        return null;
                    }

                    var nuevoToken = await response.Content.ReadAsStringAsync();
                    return nuevoToken.Replace("\"", "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Vuelve a intentar nuevamente.\n{ex.Message}",
                        "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        // --------------------------
        //   BOTÓN LOGIN
        // --------------------------
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var correo = txtCorreo.contentTextField.Text;
            var contraseña = txtContraseña.contentTextField.Text;

            string? token = await LoginUser(correo, contraseña, apiClient.Token);

            if (token != null)
            {
                apiClient.EstablecerToken(token);

                // Avisamos al formulario que fue exitoso
                OnLoginSuccess?.Invoke(token);
            }
        }
    }
}
