using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.Auth.RefreshTokenDTOs
{
    public class RefreshTokenCreateDTO
    {

        [Required(ErrorMessage = "El identificador de usuario es obligatorio")]
        public required int IdUsuario { get; set; }

        [Required(ErrorMessage = "El token de usuario es obligatorio")]
        public required Guid Token { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "La fecha de expiración es obligatoria")]
        public required DateTime FechaExpiracion { get; set; }
        public bool Revoked { get; set; } = false;
    }
}
