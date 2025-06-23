using FormApiE_Commerce.DTOs.UsuariosDTOs;
using System.Net.Http.Json;

namespace FormApiE_Commerce
{
    public partial class FormInicio : Form
    {
        public string UsuariosUrl = "https://localhost:7221/api/Usuarios"; // URL de la API de usuarios
        HttpClient client = new HttpClient();
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
            toolTip1.SetToolTip(checkBoxContraseñaRegistroVisible, "Hacer visible Contraseña");
            toolTip1.SetToolTip(checkBoxContraseñaInicioDeSesionVisible, "Hacer visible Contraseña");
            // Esto sirve para que la contraseña se muestre como puntos
            txtContraseñaRegistro.UseSystemPasswordChar = true;
            txtContraseñaRegistro.ContextMenuStrip = null; // Desactiva click derecho
            txtContraseñaRegistro.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.ContextMenuStrip = null; // Desactiva click derecho
            txtContraseña.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
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
                MessageBox.Show($"Error inerperado al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtContraseñaRegistro.Clear();
                txtCorreoRegistro.Clear();
                txtNombre.Clear();
                mtxtTelefono.Clear();
                txtCorreo.Clear();
                txtContraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cancelar inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                string correo = txtCorreo.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();
                if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Lista de dominios válidos
                string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };

                // Verificar si el correo termina en alguno de los dominios permitidos
                bool esValido = dominiosPermitidos.Any(d => correo.EndsWith(d));

                if (!esValido)
                {
                    MessageBox.Show("Correo no válido. Solo se permiten dominios: @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }

                // También puedes validar que tenga algo antes del dominio
                int posicionArroba = correo.IndexOf('@');
                if (posicionArroba <= 0)
                {
                    MessageBox.Show("Correo no válido. Falta nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return;
                }

                // Consultar en la base de datos usando Entity Framework
                var usuario = await client.GetFromJsonAsync<List<UsuariosReadDTO>>(UsuariosUrl); 

                if (usuario == null)
                {
                    MessageBox.Show("Usuario no existente.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Buscar usuario que coincida con correo y contraseña
                var usuarioEncontrado = usuario.FirstOrDefault(u => u.Correo == correo && u.Contrasena == contraseña);

                if (usuarioEncontrado != null)
                {
                    MessageBox.Show($"Bienvenido a E-Commerce", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Tag = "PaginaPrincipal";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la API: " + ex.Message);
            }
        }

        private async void btnTerminarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto y los guarda en variables
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreoRegistro.Text.Trim();
            string contraseña = txtContraseñaRegistro.Text.Trim();
            string telefono = mtxtTelefono.Text.Replace("-", "").Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar que la contraseña tenga al menos 8 caracteres
            if (contraseña.Length <= 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseñaRegistro.Focus();
                return;
            }

            // Validar el formato del correo electrónico
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };

            // Verificar si el correo termina en alguno de los dominios permitidos
            bool esValido = dominiosPermitidos.Any(d => correo.EndsWith(d));

            if (!esValido)
            {
                MessageBox.Show("Correo no válido. Solo se permiten dominios: @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // También puedes validar que tenga algo antes del dominio
            int posicionArroba = correo.IndexOf('@');
            if (posicionArroba <= 0)
            {
                MessageBox.Show("Correo no válido. Falta nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }
            var usuario = await client.GetFromJsonAsync<List<UsuariosReadDTO>>(UsuariosUrl);
            if (usuario.Any(u => u.Correo == correo) || usuario.Any(u => u.Telefono == telefono))
            {
                MessageBox.Show("Ya hay un usuario con ese correo o numero de telefono, ingrese otros. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreoRegistro.Focus();
                return;
            }

            var result = MessageBox.Show("Aceptas los terminos y condiciones... si no los aceptas no puedes registrarte.", "Terminos y condiciones.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result != DialogResult.Yes) return;
            try
            {
                var nuevoUsuario = new UsuariosCreateDTO
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Correo = correo,
                    Contraseña = contraseña,
                    Telefono = telefono
                };

                var response = await client.PostAsJsonAsync(UsuariosUrl, nuevoUsuario);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registro exitoso. Bienvenido a E-Commerce", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Tag = "PaginaPrincipal";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al registrar: " + error, "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la API: " + ex.Message);
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
            MessageBox.Show("E-Commerce es una tienda en linea disponible para .....", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Que puedes hacer en E-Commerce? Comprar, verder, ....", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Tag = "Administracion";
            this.DialogResult = DialogResult.OK; 
            this.Close();

        }

        // Hace vicible la contraseña en el registro y viceversa
        private void checkBoxContraseñaRegistroVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseñaRegistroVisible.Checked)
            {
                // Mostrar el texto
                txtContraseñaRegistro.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContraseñaRegistro.UseSystemPasswordChar = true;
            }
        }
        private void checkBoxContraseñaInicioDeSesionVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseñaInicioDeSesionVisible.Checked)
            {
                // Mostrar el texto
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
 