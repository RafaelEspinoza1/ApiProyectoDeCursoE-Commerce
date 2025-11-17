using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public int IdVendedor { get; set; }

        [Required]
        public int IdCategoria { get; set; }

        [Required]
        public int IdEstadoProducto { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; } = null!;

        [Required]
        public decimal Precio { get; set; }

        [Required, MaxLength(1000)]
        public string Descripcion { get; set; } = null!;

        [Required]
        public int StockDisponible { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("IdVendedor")]
        public Vendedor Vendedor { get; set; } = null!;

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; } = null!;

        [ForeignKey("IdEstadoProducto")]
        public EstadoProducto EstadoProducto { get; set; } = null!;

        public ICollection<ImagenProducto>? Imagenes { get; set; }
        public ICollection<Transaccion>? Transacciones { get; set; }
        public ICollection<ReseñaProducto>? Reseñas { get; set; }
    }
}