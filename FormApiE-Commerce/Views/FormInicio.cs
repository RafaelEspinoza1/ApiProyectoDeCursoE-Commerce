
using FormApiE_Commerce.Models;
using System.Net.Http.Json;
using System.Text;

namespace FormApiE_Commerce
{
    public partial class FormInicio : Form
    {
        private ApiClient apiClient = new ApiClient();

        public FormInicio()
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

                MessageBox.Show(correo, contraseña);

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
                    return nuevoToken.Replace("\"", ""); // Limpiar comillas
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Vuelve a intentar nuevamente.\n{ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }



        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var correo = txtCorreo.contentTextField.Text;
            var contraseña = txtContraseña.contentTextField.Text;

            string? token = await LoginUser(correo, contraseña, apiClient.Token);

            if (token != null)
            {
                apiClient.EstablecerToken(token);
                MessageBox.Show("Login exitoso!");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }






        //public Usuarios NuevoUsuario { get; private set; }
        //public static int UsuarioId { get; private set; } // Para almacenar el ID del usuario actual

        //public FormInicio()
        //{
        //    InitializeComponent();


        //    toolTip1.SetToolTip(btnConfig, "Opciones");
        //    toolTip1.SetToolTip(btnCerrarInicioSesion, "Cerrar");
        //    toolTip1.SetToolTip(txtCorreo, "Correo electronico");
        //    toolTip1.SetToolTip(btnCerrarOpciones, "Cerrar");
        //    toolTip1.SetToolTip(btnAdmin, "Solo admin");
        //    toolTip1.SetToolTip(btnCerrarRegistro, "Cerrar");
        //    toolTip1.SetToolTip(txtCorreoRegistro, "Correo electronico");
        //    toolTip1.SetToolTip(checkBoxContraseñaRegistroVisible, "Hacer visible Contraseña");
        //    toolTip1.SetToolTip(checkBoxContraseñaInicioDeSesionVisible, "Hacer visible Contraseña");
        //    // Esto sirve para que la contraseña se muestre como puntos
        //    txtContraseñaRegistro.UseSystemPasswordChar = true;
        //    txtContraseñaRegistro.ContextMenuStrip = null; // Desactiva click derecho
        //    txtContraseñaRegistro.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
        //    txtContraseña.UseSystemPasswordChar = true;
        //    txtContraseña.ContextMenuStrip = null; // Desactiva click derecho
        //    txtContraseña.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
        //}
        //private void btnIniciarSesion_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        groupBoxInicioDeSesion.Visible = true;
        //        btnIniciarSesion.Visible = false;
        //        btnRegistrase.Visible = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error inerperado al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void btnCerrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        groupBoxInicioDeSesion.Visible = false;
        //        groupBoxRegristrarse.Visible = false;
        //        btnIniciarSesion.Visible = true;
        //        btnRegistrase.Visible = true;
        //        flowLayoutPanelOpciones.Visible = false;
        //        btnConfig.Visible = true;
        //        txtApellido.Clear();
        //        txtContraseñaRegistro.Clear();
        //        txtCorreoRegistro.Clear();
        //        txtNombre.Clear();
        //        mtxtTelefono.Clear();
        //        txtCorreo.Clear();
        //        txtContraseña.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error inesperado al cancelar inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        // REDIRECCIONAR AL FORMULARIO DEL MENÚ PRINCIPAL DE E-COMMERCE
        //private void btnRegistrase_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        groupBoxRegristrarse.Visible = true;
        //        btnRegistrase.Visible = false;
        //        btnIniciarSesion.Visible = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error inesperado al registrarte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }



        //}

        //// Cierra el formulario y abre el formulario PaginaPrincipal.
        //private async void btnEntrar_Click(object sender, EventArgs e)
        //{
        //    string correo = txtCorreo.Text.Trim();
        //    string contraseña = txtContraseña.Text.Trim();

        //    if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
        //    {
        //        MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }


        //    if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
        //    {
        //        MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Validación: Formato general de correo con expresión regular
        //    var regexCorreo = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        //    if (!regexCorreo.IsMatch(correo))
        //    {
        //        MessageBox.Show("El formato del correo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtCorreo.Focus();
        //        return;
        //    }

        //    // Validación: Dominio permitido
        //    string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };
        //    bool dominioValido = dominiosPermitidos.Any(d => correo.EndsWith(d, StringComparison.OrdinalIgnoreCase));
        //    if (!dominioValido)
        //    {
        //        MessageBox.Show("Solo se permiten correos de @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtCorreo.Focus();
        //        return;
        //    }

        //    // Validación: Que haya texto antes del @
        //    if (correo.IndexOf('@') <= 0)
        //    {
        //        MessageBox.Show("Correo no válido. Falta el nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtCorreo.Focus();
        //        return;
        //    }

        //    var api = new ApiService();
        //    try
        //    {
        //        var usuario = await api.LoginAsync(correo, contraseña);
        //        if (usuario == null)
        //        {
        //            MessageBox.Show("Correo o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        FormInicio.UsuarioId = usuario.UsuarioId;
        //        MessageBox.Show($"Bienvenido {usuario.Nombre}", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Tag = "PaginaPrincipal";
        //        this.DialogResult = DialogResult.OK;
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al conectarse a la API: " + ex.Message);
        //    }
        //}




        //private async void btnTerminarRegistro_Click(object sender, EventArgs e)
        //{
        //    string nombre = txtNombre.Text.Trim();
        //    string apellido = txtApellido.Text.Trim();
        //    string correo = txtCorreoRegistro.Text.Trim();
        //    string contraseña = txtContraseñaRegistro.Text.Trim();
        //    string telefono = mtxtTelefono.Text.Trim();

        //    // Validaciones locales (como campos vacíos, longitud, dominio del correo, etc.)

        //    // Pregunta por términos y condiciones
        //    var aceptar = MessageBox.Show("¿Aceptas los términos y condiciones?", "Términos y Condiciones", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //    if (aceptar != DialogResult.Yes) return;

        //    var nuevoUsuario = new Usuarios
        //    {
        //        Nombre = nombre,
        //        Apellido = apellido,
        //        Correo = correo,
        //        Contraseña = contraseña,
        //        Telefono = telefono
        //    };

        //    try
        //    {
        //        var api = new ApiService();
        //        bool registrado = await api.RegistroAsync(nuevoUsuario);

        //        if (registrado)
        //        {
        //            MessageBox.Show("Registro exitoso. Bienvenido a E-Commerce", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Tag = "PaginaPrincipal";
        //            this.DialogResult = DialogResult.OK;
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("El correo o número de teléfono ya están registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txtCorreoRegistro.Focus();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al conectar con el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        //private void btnConfig_Click(object sender, EventArgs e)
        //{
        //    flowLayoutPanelOpciones.Visible = true;
        //    btnConfig.Visible = false;
        //    groupBoxInicioDeSesion.Visible = false;
        //    groupBoxRegristrarse.Visible = false;
        //    btnIniciarSesion.Visible = true;
        //    btnRegistrase.Visible = true;
        //}

        //private void btnEcommerce_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("E-Commerce es una tienda en linea disponible para .....", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void btnPreguntas_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("¿Que puedes hacer en E-Commerce? Comprar, verder, ....", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void btnAdmin_Click(object sender, EventArgs e)
        //{
        //    this.Tag = "Administracion";
        //    this.DialogResult = DialogResult.OK;
        //    this.Close();

        //}

        //// Hace vicible la contraseña en el registro y viceversa
        //private void checkBoxContraseñaRegistroVisible_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBoxContraseñaRegistroVisible.Checked)
        //    {
        //        // Mostrar el texto
        //        txtContraseñaRegistro.UseSystemPasswordChar = false;
        //    }
        //    else
        //    {
        //        // Ocultar el texto
        //        txtContraseñaRegistro.UseSystemPasswordChar = true;
        //    }
        //}
        //private void checkBoxContraseñaInicioDeSesionVisible_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBoxContraseñaInicioDeSesionVisible.Checked)
        //    {
        //        // Mostrar el texto
        //        txtContraseña.UseSystemPasswordChar = false;
        //    }
        //    else
        //    {
        //        // Ocultar el texto
        //        txtContraseña.UseSystemPasswordChar = true;
        //    }
        //}

        //public class ApiService
        //{
        //    private readonly HttpClient client;

        //    public ApiService()
        //    {
        //        client = new HttpClient();
        //        client.BaseAddress = new Uri("https://localhost:7221/api/Usuarios"); // tu URL base
        //    }

        //    public async Task<Usuarios> LoginAsync(string correo, string contraseña)
        //    {
        //        var loginData = new { correo, contraseña };
        //        var response = await client.PostAsJsonAsync("api/usuarios/login", loginData);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            return await response.Content.ReadFromJsonAsync<Usuarios>();
        //        }

        //        return null;
        //    }

        //    public async Task<bool> RegistroAsync(Usuarios usuario)
        //    {
        //        var response = await client.PostAsJsonAsync("api/usuarios", usuario);
        //        return response.IsSuccessStatusCode;
        //    }
        //}
    }
}
 