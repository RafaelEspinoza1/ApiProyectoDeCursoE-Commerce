using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.DTOs.VendedoresDTOs
{
    public class VendedoresUpdateDTO
    {

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Ingresos { get; set; } = 0;

    }
}
