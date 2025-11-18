using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.VendedoresDTOs
{
    public class VendedoresUpdateDTO
    {
        [Key]
        public int IdVendedor { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required, MaxLength(100)]
        public int NombreNegocio { get; set; }
        [Required, MaxLength(255)]
        public string LogoNegocio { get; set; } = string.Empty;
        [Required, MaxLength(300)]
        public string DescripcionNegocio { get; set; } = string.Empty;
        [Required]
        public bool EsContribuyente { get; set; }

    }
}
