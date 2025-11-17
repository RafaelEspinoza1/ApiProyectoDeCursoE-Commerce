using Microsoft.Extensions.Configuration;

namespace ApiProyectoDeCursoE_Commerce.Guards
{
    public class ApiKeyGuard
    {
        private readonly IConfiguration _config;

        // Constructor recibe IConfiguration vía DI o puedes usar singleton/servicio
        public ApiKeyGuard(IConfiguration config)
        {
            _config = config;
        }

        // Verifica si el valor del header coincide con el valor esperado en configuración
        // SOLO ES ACCESIBLE DESDE ESTE GUARD
        public bool IsValid(string headerName, string headerValue)
        {
            // Obtiene el valor esperado desde appsettings
            string expectedHeaderValue = _config[$"ApiSettings:{headerName}"] ?? "";

            // Compara el valor de la cabecera con el valor esperado
            return headerValue == expectedHeaderValue;
        }
    }
}

