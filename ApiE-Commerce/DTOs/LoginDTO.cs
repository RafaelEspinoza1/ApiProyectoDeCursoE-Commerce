using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiProyectoDeCursoE_Commerce.DTOs
{
    public class LoginDTO
    {
        public required string Correo { get; set; }
        public required string Contraseña { get; set; }
        public required string Rol { get; set; }
        public string? Token { get; set; }

    }
}
