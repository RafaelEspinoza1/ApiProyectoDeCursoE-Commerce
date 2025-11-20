using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.VendedoresDTOs
{
    public class VendedoresCreateDTO
    {
        [Required]
        public int IdUsuario { get; set; }
        public decimal? Ingresos { get; set; }
    }
}
