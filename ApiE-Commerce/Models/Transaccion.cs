using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Transacciones")]
    public class Transaccion
    {
        [Key]
        public int IdTransaccion { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int IdComprador { get; set; }

        [Required]
        public int IdEstadoTransaccion { get; set; }

        [Required]
        public int IdMetodoDePago { get; set; }

        [Required]
        public int UnidadesCompradas { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? PrecioEnvio { get; set; }  // puede ser null

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioTotal { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; } = null!;

        [ForeignKey("IdComprador")]
        public Comprador Comprador { get; set; } = null!;

        [ForeignKey("IdEstadoTransaccion")]
        public EstadoTransaccion EstadoTransaccion { get; set; } = null!;

        [ForeignKey("IdMetodoDePago")]
        public MetodoDePago MetodoDePago { get; set; } = null!;
        public ICollection<Ingreso>? Ingresos { get; set; }
    }
}
