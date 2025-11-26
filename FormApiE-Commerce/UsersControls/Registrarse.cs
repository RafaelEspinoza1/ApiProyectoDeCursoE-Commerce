
using FormApiE_Commerce.DTOs.UsuariosDTOs;
using FormApiE_Commerce.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApiE_Commerce.UsersControls
{
    public partial class Registrarse : UserControl
    {
        public Registrarse()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void CargarRoles()
        {
            var roles = new List<object>
        {
            new { Id = 1, Nombre = "Administrador" },
            new { Id = 2, Nombre = "Vendedor" },
            new { Id = 3, Nombre = "Comprador" }
        };

            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "Nombre"; // lo que ve el usuario
            cmbRol.ValueMember = "Id";       // el valor real que se envía al backend
            cmbRol.SelectedIndex = -1;       // ningún rol seleccionado por defecto
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtP_Nombre_Regis.Content))
            {
                MessageBox.Show("El primer nombre es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtP_Apellido_Regis.Content))
            {
                MessageBox.Show("El primer apellido es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono_Regis.Content))
            {
                MessageBox.Show("El teléfono es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo_Regis.Content))
            {
                MessageBox.Show("El correo es obligatorio.");
                return false;
            }

            if (!txtCorreo_Regis.Content.Contains("@"))
            {
                MessageBox.Show("El correo no es válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña_Regis.Content))
            {
                MessageBox.Show("La contraseña es obligatoria.");
                return false;
            }

            if (txtContraseña_Regis.Content != txtConfim_contra_Regis.Content)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            if (cmbRol.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un rol.");
                return false;
            }

            return true;
        }



        private async Task<TokenData?> RegistrarUsuario(UsuariosCreateDTO data)
        {
            try
            {
                using var httpClient = new HttpClient();
                var url = "http://localhost:5028/api/Auth/register";

                // Serializar el objeto con Newtonsoft.Json
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, content);
                var responseJson = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error del servidor: {response.StatusCode}\n{responseJson}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                // Deserializar la respuesta correctamente
                var authResponse = System.Text.Json.JsonSerializer.Deserialize<TokenData>(
                    responseJson
                );

                return authResponse;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        private async void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (!ValidarCampos())
                return;

            if (cmbRol.SelectedValue == null)
            {
                MessageBox.Show("Debes seleccionar un rol válido.");
                return;
            }

            int idRol = Convert.ToInt32(cmbRol.SelectedValue);


            // Construir objeto con los datos que pide el backend
            var data = new UsuariosCreateDTO
            {
                IdRol = idRol,
                PrimerNombre = txtP_Nombre_Regis.Content.Trim(),
                SegundoNombre = string.IsNullOrWhiteSpace(txtS_Nombre_Regis.Content) ? null : txtS_Nombre_Regis.Content.Trim(),
                PrimerApellido = txtP_Apellido_Regis.Content.Trim(),
                SegundoApellido = string.IsNullOrWhiteSpace(txtS_Apellido_Regis.Content) ? null : txtS_Apellido_Regis.Content.Trim(),
                Telefono = txtTelefono_Regis.Content.Trim(),
                Correo = txtCorreo_Regis.Content.Trim(),
                Contraseña = txtContraseña_Regis.Content
            };

            // Registrar usuario
            var authResponse = await RegistrarUsuario(data);

            if (authResponse == null)
                return;

            // Guardar token automáticamente
            TokenDataStorage.Save(authResponse);

            MessageBox.Show("Registro exitoso. ¡Bienvenido!");

            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            var formInicio = this.FindForm();
            if (formInicio != null)
            {
                paginaPrincipal.FormClosed += (s, args) => formInicio.Close();
            }
            paginaPrincipal.Show();
            formInicio?.Hide();
        }

        private void cuiLabel9_Load(object sender, EventArgs e)
        {

        }

        private void txtP_Nombre_Regis_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
