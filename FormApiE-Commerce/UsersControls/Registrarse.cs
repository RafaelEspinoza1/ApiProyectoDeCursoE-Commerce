using FormApiE_Commerce.DTOs.Auth;
using FormApiE_Commerce.Views;
using GMap.NET.MapProviders;
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
            cmbRol. DropDownStyle = ComboBoxStyle.DropDownList;
            CargarRoles();
            cmbRol.SelectedIndex = 2;
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
        private async Task<TokenData?> RegistrarAdmin(AdministradorCreateDTO admin)
        {
            string url = "http://localhost:5028/api/Auth/register/admin";
            return await EnviarRegistro(url, admin);
        }

        private async Task<TokenData?> RegistrarVendedor(VendedorCreateDTO seller)
        {
            string url = "http://localhost:5028/api/Auth/register/seller";
            return await EnviarRegistro(url, seller);
        }

        private async Task<TokenData?> RegistrarComprador(CompradorCreateDTO buyer)
        {
            string url = "http://localhost:5028/api/Auth/register/buyer";
            return await EnviarRegistro(url, buyer);
        }

        private async Task<TokenData?> EnviarRegistro(string url, object dto)
        {
            try
            {
                using var httpClient = new HttpClient();

                var json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, content);
                var responseJson = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error del servidor: {response.StatusCode}\n{responseJson}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                return JsonConvert.DeserializeObject<TokenData>(responseJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async Task<TokenData?> RegistrarUsuarioPorRol<T>(int idRol, T? usuario)
        {
            switch (idRol)
            {
                case 1:
                    var adminDto = ObtenerAdminDTO();
                    return await RegistrarAdmin(adminDto);

                case 2:
                    if (usuario is not VendedorCreateDTO vendedor)
                        throw new ArgumentException("El objeto no es un VendedorCreateDTO");

                    return await RegistrarVendedor(vendedor);

                case 3:
                    var buyerDto = ObtenerCompradorDTO();
                    return await RegistrarComprador(buyerDto);

                default:
                    throw new ArgumentException("Rol inválido");
            }
        }

        private AdministradorCreateDTO ObtenerAdminDTO()
        {
            return new AdministradorCreateDTO
            {
                IdRol = (int)cmbRol.SelectedValue!,
                PrimerNombre = txtP_Nombre_Regis.contentTextField.Text,
                SegundoNombre = txtS_Nombre_Regis.contentTextField.Text,
                PrimerApellido = txtP_Apellido_Regis.contentTextField.Text,
                SegundoApellido = txtS_Apellido_Regis.contentTextField.Text,
                Correo = txtCorreo_Regis.contentTextField.Text,
                Telefono = txtTelefono_Regis.contentTextField.Text,
                Contraseña = txtContraseña_Regis.contentTextField.Text
            };
        }

        private VendedorCreateDTO ObtenerVendedorDTO(RegistrarVendedorDTO vendedor)
        {
            return new VendedorCreateDTO
            {
                IdRol = (int)cmbRol.SelectedValue!,
                PrimerNombre = txtP_Nombre_Regis.contentTextField.Text,
                SegundoNombre = txtS_Nombre_Regis.contentTextField.Text,
                PrimerApellido = txtP_Apellido_Regis.contentTextField.Text,
                SegundoApellido = txtS_Apellido_Regis.contentTextField.Text,
                Correo = txtCorreo_Regis.contentTextField.Text,
                Telefono = txtTelefono_Regis.contentTextField.Text,
                Contraseña = txtContraseña_Regis.contentTextField.Text,
                NombreNegocio = vendedor?.NombreNegocio ?? "",
                LogoNegocio = vendedor?.LogoNegocio ?? "",
                DescripcionNegocio = vendedor?.DescripcionNegocio ?? "",
                EsContribuyente = vendedor?.EsContribuyente ?? false
            };
        }

        private CompradorCreateDTO ObtenerCompradorDTO()
        {
            return new CompradorCreateDTO
            {
                IdRol = (int)cmbRol.SelectedValue!,
                PrimerNombre = txtP_Nombre_Regis.contentTextField.Text,
                SegundoNombre = txtS_Nombre_Regis.contentTextField.Text,
                PrimerApellido = txtP_Apellido_Regis.contentTextField.Text,
                SegundoApellido = txtS_Apellido_Regis.contentTextField.Text,
                Correo = txtCorreo_Regis.contentTextField.Text,
                Telefono = txtTelefono_Regis.contentTextField.Text,
                Contraseña = txtContraseña_Regis.contentTextField.Text
            };
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

            object? usuario = null;

            if (idRol == 2)
            {
                using var registro = new Registro_para_Vendedores();

                var result = registro.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var vendedor = registro.datosVendedor;
                    MessageBox.Show("Los datos se cargaron con éxito.");
                }
                else
                {
                    MessageBox.Show("Se rechazó la solicitud.");
                    return;
                }
            }

            // Registrar según el rol
            var authResponse = await RegistrarUsuarioPorRol(idRol, usuario);

            if (authResponse == null)
                return;

            // Guardar token automáticamente
            TokenDataStorage.Save(authResponse);

            MessageBox.Show("Registro exitoso. ¡Bienvenido!");

            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(authResponse);
            var formInicio = this.FindForm();

            if (formInicio != null)
                paginaPrincipal.FormClosed += (s, args) => formInicio.Close();

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
