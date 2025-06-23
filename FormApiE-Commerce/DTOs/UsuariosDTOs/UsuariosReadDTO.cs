using System.Text.Json.Serialization;

namespace FormApiE_Commerce.DTOs.UsuariosDTOs
{
    public class UsuariosReadDTO
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        [JsonPropertyName("contraseña")]
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
    }
}