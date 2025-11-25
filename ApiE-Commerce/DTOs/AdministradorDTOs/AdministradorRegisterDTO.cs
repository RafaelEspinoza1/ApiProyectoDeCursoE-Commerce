using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs
{
    public class AdministradorRegisterDTO
    {
        [Required(ErrorMessage = "El identificador de usuario es obligatorio")]
        public required int IdUsuario { get; set; }
    }
}
