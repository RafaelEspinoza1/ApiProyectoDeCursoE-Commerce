using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("IngresosECommerce")]
    public class Ingreso
    {
        [Key]
        public int IdIngresoEcommerce { get; set; }

        [Required]
        public int IdTransaccion { get; set; }

        [Required]
        public int IdTipoIngreso { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Cantidad { get; set; }

        // Relaciones
        [ForeignKey("IdTransaccion")]
        public Transaccion Transaccion { get; set; } = null!;

        [ForeignKey("IdTipoIngreso")]
        public TipoIngreso TipoIngreso { get; set; } = null!;
    }
}
