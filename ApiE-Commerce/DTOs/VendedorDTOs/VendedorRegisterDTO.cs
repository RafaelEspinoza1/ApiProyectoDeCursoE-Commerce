using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs
{
    public class VendedorRegisterDTO
    {
        [Required(ErrorMessage = "El identificador de usuario es obligatorio")]
        public required int IdUsuario { get; set; }

        [Required(ErrorMessage = "Los ingresos son obligatorios")]
        [Column(TypeName = "decimal(10,2)")]
        public required decimal Ingresos { get; set; }
    }
}
