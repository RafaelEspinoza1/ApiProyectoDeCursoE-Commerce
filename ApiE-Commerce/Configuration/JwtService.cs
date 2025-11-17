using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace ApiProyectoDeCursoE_Commerce.Configuration
{
    public class JwtService
    {
        // Configuración del JWT
        private readonly JwtSettings _settings;

        // Constructor que recibe la configuración del JWT
        public JwtService(JwtSettings settings)
        {
            _settings = settings;
        }

        // Genera un token JWT para el usuario dado
        public string GenerateToken(Usuario usuario)
        {
            // Define el rol del usuario
            var rol = (RolesEnum)usuario.IdRol;

            // Crea los claims del token
            var claims = new List<Claim>
            {
                new Claim("id", usuario.IdUsuario.ToString()),
                new Claim("email", usuario.Correo),
                new Claim("role", rol.ToString())
            };

            // Crea la clave de seguridad y las credenciales de firma
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_settings.key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Crea el token JWT
            var token = new JwtSecurityToken(
                issuer: _settings.issuer,
                audience: _settings.audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_settings.ExpirationInMinutes),
                signingCredentials: creds
            );

            // Devuelve el token como una cadena
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
