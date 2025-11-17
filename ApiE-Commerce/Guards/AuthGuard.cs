using ApiProyectoDeCursoE_Commerce.Models.Enums;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiProyectoDeCursoE_Commerce.Guards
{
    public class AuthGuard : Attribute, IAsyncActionFilter
    {
        // Campos para almacenar el rol requerido y los detalles del encabezado
        private readonly RolesEnum[] _allowedRoles;
        private readonly string? _headerName;

        // Constructor que recibe el rol requerido y los detalles del encabezado
        public AuthGuard(RolesEnum[] allowedRoles, string? headerName = null)
        {
            _allowedRoles = allowedRoles;
            _headerName = headerName;
        }

        // Verifica si el usuario tiene el rol requerido
        // SOLO ES ACCESIBLE DESDE EL GUARDIA
        private bool UserHasRole(ClaimsPrincipal user)
        {
            // Obtiene el claim del rol del usuario
            var roleClaim = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);

            // Si no tiene el rol asignado, negar el acceso
            if (roleClaim == null) return false;

            // Verifica si el valor puede ser convertido al enum RolesEnum
            // Compara el rol del usuario con los roles permitidos
            return Enum.TryParse<RolesEnum>(roleClaim.Value, out var role) && _allowedRoles.Contains(role);
        }

        // Método principal para autorizar la solicitud
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var user = context.HttpContext.User;

            // Verifica si el usuario tiene el rol requerido
            if (!UserHasRole(user))
            {
                context.Result = new UnauthorizedObjectResult("Acceso no autorizado: Sin permisos para esta acción...");
                return;
            }

            // Verifica la presencia del encabezado solo si se especificó
            if (!string.IsNullOrEmpty(_headerName))
            {
                if (!context.HttpContext.Request.Headers.ContainsKey(_headerName!))
                {
                    context.Result = new UnauthorizedObjectResult("Acceso no autorizado: No se proporcionó ningún encabezado...");
                    return;
                }

                // Verifica el valor del encabezado a través del ApiKeyGuard
                string headerValue = context.HttpContext.Request.Headers[_headerName!]!;
                var apiKeyGuard = new ApiKeyGuard(); // suponiendo que tiene un método estático o singleton
                if (!apiKeyGuard.IsValid(_headerName!, headerValue))
                {
                    context.Result = new UnauthorizedObjectResult("Acceso no autorizado: Valor de encabezado inválido...");
                    return;
                }
            }

            // Si todas las verificaciones pasan, continúa con la ejecución del controlador
            await next();
        }
    }
}
