namespace FormApiE_Commerce
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string siguienteForm = "FormInicio";

            
            int usuarioId = 0;


            while (true)
            {
                Form formularioActual = siguienteForm switch
                {
                    "FormInicio" => new FormInicio(),
                    "PaginaPrincipal" => new PaginaPrincipal(FormInicio.UsuarioId),
                    "Administracion" => new Administracion(),
                    _ => null
                };

                if (formularioActual == null)
                    break;
                if (siguienteForm == "Administracion")
                {
                    formularioActual.Size = new Size(309, 184); // Tama�o especial para Administrador
                }

                DialogResult resultado = formularioActual.ShowDialog();

                if (formularioActual is FormInicio formInicio)
                {
                    usuarioId = FormInicio.UsuarioId; // Captura el ID que se guard� est�ticamente
                }
                // Si el formulario indica cu�l sigue, lo tomamos
                if (formularioActual.Tag is string siguiente && !string.IsNullOrEmpty(siguiente))
                {
                    siguienteForm = siguiente;
                }
                else
                {
                    break; // salir de la aplicaci�n
                }
            }
        }
    }

    
}