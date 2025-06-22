using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.Models;
using System.Net.Http.Json;

namespace TiendaEcommerce
{
    public partial class FormInicio : Form
    {
        
        public Usuarios NuevoUsuario { get; private set; }
        public static int UsuarioId { get; private set; } // Para almacenar el ID del usuario actual

        public FormInicio()
        {
            InitializeComponent();


            toolTip1.SetToolTip(btnConfig, "Opciones");
            toolTip1.SetToolTip(btnCerrarInicioSesion, "Cerrar");
            toolTip1.SetToolTip(txtCorreo, "Correo electronico");
            toolTip1.SetToolTip(btnCerrarOpciones, "Cerrar");
            toolTip1.SetToolTip(btnAdmin, "Solo admin");
            toolTip1.SetToolTip(btnCerrarRegistro, "Cerrar");
            toolTip1.SetToolTip(txtCorreoRegistro, "Correo electronico");
            toolTip1.SetToolTip(checkBoxContrase�aRegistroVisible, "Hacer visible Contrase�a");
            toolTip1.SetToolTip(checkBoxContrase�aInicioDeSesionVisible, "Hacer visible Contrase�a");
            // Esto sirve para que la contrase�a se muestre como puntos
            txtContrase�aRegistro.UseSystemPasswordChar = true;
            txtContrase�aRegistro.ContextMenuStrip = null; // Desactiva click derecho
            txtContrase�aRegistro.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
            txtContrase�a.UseSystemPasswordChar = true;
            txtContrase�a.ContextMenuStrip = null; // Desactiva click derecho
            txtContrase�a.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxInicioDeSesion.Visible = true;
                btnIniciarSesion.Visible = false;
                btnRegistrase.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inerperado al iniciar sesi�n: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxInicioDeSesion.Visible = false;
                groupBoxRegristrarse.Visible = false;
                btnIniciarSesion.Visible = true;
                btnRegistrase.Visible = true;
                flowLayoutPanelOpciones.Visible = false;
                btnConfig.Visible = true;
                txtApellido.Clear();
                txtContrase�aRegistro.Clear();
                txtCorreoRegistro.Clear();
                txtNombre.Clear();
                mtxtTelefono.Clear();
                txtCorreo.Clear();
                txtContrase�a.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cancelar inicio de sesi�n: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxRegristrarse.Visible = true;
                btnRegistrase.Visible = false;
                btnIniciarSesion.Visible = false;
            }catch(Exception ex)
            {
                MessageBox.Show($"Error inesperado al registrarte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        // Cierra el formulario y abre el formulario PaginaPrincipal.
        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contrase�a = txtContrase�a.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrase�a))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrase�a))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaci�n: Formato general de correo con expresi�n regular
            var regexCorreo = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexCorreo.IsMatch(correo))
            {
                MessageBox.Show("El formato del correo no es v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Validaci�n: Dominio permitido
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };
            bool dominioValido = dominiosPermitidos.Any(d => correo.EndsWith(d, StringComparison.OrdinalIgnoreCase));
            if (!dominioValido)
            {
                MessageBox.Show("Solo se permiten correos de @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Validaci�n: Que haya texto antes del @
            if (correo.IndexOf('@') <= 0)
            {
                MessageBox.Show("Correo no v�lido. Falta el nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            var api = new ApiService();
            try
            {
                var usuario = await api.LoginAsync(correo, contrase�a);
                if (usuario == null)
                {
                    MessageBox.Show("Correo o contrase�a incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormInicio.UsuarioId = usuario.UsuarioId;
                MessageBox.Show($"Bienvenido {usuario.Nombre}", "Inicio de Sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Tag = "PaginaPrincipal";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la API: " + ex.Message);
            }
        }




        private async void btnTerminarRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreoRegistro.Text.Trim();
            string contrase�a = txtContrase�aRegistro.Text.Trim();
            string telefono = mtxtTelefono.Text.Trim();

            // Validaciones locales (como campos vac�os, longitud, dominio del correo, etc.)

            // Pregunta por t�rminos y condiciones
            var aceptar = MessageBox.Show("�Aceptas los t�rminos y condiciones?", "T�rminos y Condiciones", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (aceptar != DialogResult.Yes) return;

            var nuevoUsuario = new Usuarios
            {
                Nombre = nombre,
                Apellido = apellido,
                Correo = correo,
                Contrase�a = contrase�a,
                Telefono = telefono
            };

            try
            {
                var api = new ApiService();
                bool registrado = await api.RegistroAsync(nuevoUsuario);

                if (registrado)
                {
                    MessageBox.Show("Registro exitoso. Bienvenido a E-Commerce", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Tag = "PaginaPrincipal";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El correo o n�mero de tel�fono ya est�n registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreoRegistro.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        

        private void btnConfig_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOpciones.Visible = true;
            btnConfig.Visible = false;
            groupBoxInicioDeSesion.Visible = false;
            groupBoxRegristrarse.Visible = false;
            btnIniciarSesion.Visible = true;
            btnRegistrase.Visible = true;
        }

        private void btnEcommerce_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-Commerce es una tienda en linea disponible para .....", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�Que puedes hacer en E-Commerce? Comprar, verder, ....", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Tag = "Administracion";
            this.DialogResult = DialogResult.OK; 
            this.Close();

        }

        // Hace vicible la contrase�a en el registro y viceversa
        private void checkBoxContrase�aRegistroVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContrase�aRegistroVisible.Checked)
            {
                // Mostrar el texto
                txtContrase�aRegistro.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContrase�aRegistro.UseSystemPasswordChar = true;
            }
        }
        private void checkBoxContrase�aInicioDeSesionVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContrase�aInicioDeSesionVisible.Checked)
            {
                // Mostrar el texto
                txtContrase�a.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

        public class ApiService
        {
            private readonly HttpClient client;

            public ApiService()
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7221/api/Usuarios"); // tu URL base
            }

            public async Task<Usuarios> LoginAsync(string correo, string contrase�a)
            {
                var loginData = new { correo, contrase�a };
                var response = await client.PostAsJsonAsync("api/usuarios/login", loginData);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Usuarios>();
                }

                return null;
            }

            public async Task<bool> RegistroAsync(Usuarios usuario)
            {
                var response = await client.PostAsJsonAsync("api/usuarios", usuario);
                return response.IsSuccessStatusCode;
            }
        }


    }
}
 