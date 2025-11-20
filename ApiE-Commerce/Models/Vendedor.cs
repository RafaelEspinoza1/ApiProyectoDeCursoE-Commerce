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

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Ingresos { get; set; } = 0;
    }
}
