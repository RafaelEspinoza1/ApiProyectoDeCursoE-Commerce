using Azure;
using FormApiE_Commerce.DTOs;
using FormApiE_Commerce.UsersControls;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace FormApiE_Commerce
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private async void FormInicio_Load(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                var url = "http://localhost:5028/api/Auth/login";

                var tokenData = TokenDataStorage.Load();

                var idUsuario = tokenData?.IdUsuario;
                var token = tokenData?.Token;
                var refreshToken = tokenData?.RefreshToken;

                // --------------------------------------------------
                // Inicio r嫚ido: JWT solo, o Refresh Token + IdUsuario
                // --------------------------------------------------
                if (!string.IsNullOrEmpty(token) ||
                    (!string.IsNullOrEmpty(refreshToken) && idUsuario != null && idUsuario > 0))
                {
                    var loginData = new Dictionary<string, object>();

                    if (!string.IsNullOrEmpty(token))
                        loginData["Token"] = token;

                    if (!string.IsNullOrEmpty(refreshToken) && idUsuario != null && idUsuario > 0)
                    {
                        loginData["IdUsuario"] = idUsuario;
                        loginData["RefreshToken"] = refreshToken;
                    }

                    var json = JsonSerializer.Serialize(loginData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    try
                    {
                        var response = await httpClient.PostAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            var nuevoToken = await response.Content.ReadAsStringAsync();
                            var authResponse = JsonSerializer.Deserialize<TokenData>(
                                nuevoToken,
                                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                            );

                            if (authResponse == null)
                            {
                                MessageBox.Show("Error al obtener credenciales.");
                                return;
                            }

                            // Guardar el nuevo token
                            TokenDataStorage.Save(authResponse);

                            MessageBox.Show("、ienvenido de nuevo!");

                            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(tokenData);
                            var formInicio = this.FindForm();
                            if (formInicio != null)
                            {
                                paginaPrincipal.FormClosed += (s, args) => formInicio.Close();
                            }

                            paginaPrincipal.Show();
                            formInicio?.Hide();
                        }
                        else
                        {

                            MessageBox.Show("Error al leer credenciales. ERROR: " + response.StatusCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de conexi鏮: " + ex.Message);
                    }
                }
            }
        }


        private async Task<TokenData?> LoginUser(string correo, string contrase鎙)
        {
            using var httpClient = new HttpClient();
            var url = "http://localhost:5028/api/Auth/login";

            var loginData = new
            {
                Correo = correo,
                Contrase鎙 = contrase鎙,
                Token = "" // En este flujo, no usamos token previo
            };

            var json = JsonSerializer.Serialize(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Inicio de sesi鏮 fallido. ERROR: {response.StatusCode}");
                    return null;
                }

                var responseJson = await response.Content.ReadAsStringAsync();
                var authResponse = JsonSerializer.Deserialize<TokenData>(
                    responseJson,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

                return authResponse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No hay conexi鏮, intente nuevamente.\n{ex.Message}", "Error de conexi鏮", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var correo = txtCorreo.contentTextField.Text;
            var contraseña = txtContraseña.contentTextField.Text;

            MessageBox.Show("Intentando el inicio de sesi鏮.");
            var tokenData = await LoginUser(correo, contraseña);

            if (tokenData != null)
            {
                // Guardar IdUsuario y token
                TokenDataStorage.Save(
                    tokenData
                );

                MessageBox.Show("Inicio de sesi鏮 exitoso. 、ienvenido de nuevo!");

                PaginaPrincipal paginaPrincipal = new PaginaPrincipal(tokenData);
                var formInicio = this.FindForm();
                if (formInicio != null)
                {
                    paginaPrincipal.FormClosed += (s, args) => formInicio.Close();
                }
                paginaPrincipal.Show();
                formInicio?.Hide();

                //var token = TokenStorage.Load();

                //if (token != null)
                //{
                //    MessageBox.Show(token.JwtToken);
                //}
            }
            else
            {
                MessageBox.Show("Correo o contrase鎙 incorrectos.");
            }
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            UserControl registro = new Registrarse();
            registro.Dock = DockStyle.Fill;

            // Ahora cargamos en Panel1 del SplitContainer
            splCon_Separador.Panel1.Controls.Clear();
            splCon_Separador.Panel1.Controls.Add(registro);
           // BtnSalir.Visible = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            UserControl inicioSesion = new Inicio_de_Sesion();
            inicioSesion.Dock = DockStyle.Fill;
            // Ahora cargamos en Panel1 del SplitContainer
            splCon_Separador.Panel1.Controls.Clear();
           // splCon_Separador.Panel1.Controls.Add(inicioSesion);
            BtnSalir.Visible = false;
        }
    }
}