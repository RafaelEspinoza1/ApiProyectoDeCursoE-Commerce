using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiProyectoDeCursoE_Commerce.DTOs.Auth
{
    public class LoginDTO
    {
        public int IdUsuario { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
    }
}
