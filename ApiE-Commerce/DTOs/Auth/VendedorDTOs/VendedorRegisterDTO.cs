using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs
{
    public class VendedorRegisterDTO
    {
        [Required(ErrorMessage = "El identificador de usuario es obligatorio")]
        public required int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre del negocio es obligatorio")]
        [MaxLength(100)]
        public required string NombreNegocio { get; set; }

        [MaxLength(255)]
        public string? LogoNegocio { get; set; }

        [MaxLength(300)]
        public string? DescripcionNegocio { get; set; }

        [Required(ErrorMessage = "El campo EsContribuyente es obligatorio")]
        public required bool EsContribuyente { get; set; }
    }
}
