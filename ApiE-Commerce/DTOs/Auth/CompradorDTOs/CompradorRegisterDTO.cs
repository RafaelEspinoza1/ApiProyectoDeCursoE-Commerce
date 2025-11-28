using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.Auth.CompradorDTOs
{
    public class CompradorRegisterDTO
    {
        [Required(ErrorMessage = "El identificador de usuario es obligatorio")]
        public required int IdUsuario { get; set; }
    }
}
