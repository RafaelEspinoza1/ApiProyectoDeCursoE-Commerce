using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ApiProyectoDeCursoE_Commerce.Models.Enums;

namespace ApiProyectoDeCursoE_Commerce.Guards
{
    public class AuthGuard : Attribute, IAsyncActionFilter
    {
        // Campos para almacenar los roles permitidos
        private readonly RolesEnum[] _allowedRoles;

        // Constructor que recibe los roles permitidos
        public AuthGuard(RolesEnum[] allowedRoles)
        {
            _allowedRoles = allowedRoles;
        }

        // Verifica si el usuario tiene el rol requerido
        // SOLO ES ACCESIBLE DESDE EL GUARDIA
        private bool UserHasRole(ClaimsPrincipal user, out RolesEnum? userRole)
        {
            userRole = null;

            // Obtiene el claim del rol del usuario
            var roleClaim = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);

            if (roleClaim == null) return false;

            // Convierte el valor del claim al enum RolesEnum
            if (Enum.TryParse<RolesEnum>(roleClaim.Value, out var role))
            {
                userRole = role;
                return _allowedRoles.Contains(role);
            }

            return false;
        }

        // Método principal para autorizar la solicitud
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var user = context.HttpContext.User;

            // Verifica si el usuario tiene el rol requerido
            if (!UserHasRole(user, out var userRole))
            {
                context.Result = new UnauthorizedObjectResult("Acceso no autorizado: Sin permisos para esta acción...");
                return;
            }

            // Si pasa todas las verificaciones, continúa con la ejecución del controlador
            await next();
        }
    }
}


