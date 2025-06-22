using ApiProyectoDeCursoE_Commerce;

namespace TiendaEcommerce
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
            Application.Run(new FormInicio());


            string siguienteForm = "FormInicio";

            while (true)
            {
                Form formularioActual = siguienteForm switch
                {
                    "FormInicio" => new FormInicio(),
                    "PaginaPrincipal" => new PaginaPrincipal(),
                    "Administracion" => new Administracion(),
                    _ => null
                };

                if (formularioActual == null)
                    break;
                if (siguienteForm == "Administracion")
                {
                    formularioActual.Size = new Size(309, 184); // Tamaño especial para Administrador
                }

                DialogResult resultado = formularioActual.ShowDialog();

                // Si el formulario indica cuál sigue, lo tomamos
                if (formularioActual.Tag is string siguiente && !string.IsNullOrEmpty(siguiente))
                {
                    siguienteForm = siguiente;
                }
                else
                {
                    break; // salir de la aplicación
                }
            }
        }


    }
}