using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Vendedores")]
    public class Vendedor
    {
        [Key]
        public int IdVendedor { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [MaxLength(100)]
        public string? NombreNegocio { get; set; }

        [MaxLength(255)]
        public string? LogoNegocio { get; set; }

        [MaxLength(300)]
        public string? DescripcionNegocio { get; set; }

        [Required(ErrorMessage = "El campo EsContribuyente es obligatorio")]
        public required bool EsContribuyente { get; set; }
    }
}
