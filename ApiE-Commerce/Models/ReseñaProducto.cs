using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("ReseñasProductos")]
    public class ReseñaProducto
    {
        [Key]
        public int IdReseñaProducto { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int IdComprador { get; set; }

        [Required, Column(TypeName = "decimal(3,1)")]
        [Range(1, 5)]
        public decimal Calificacion { get; set; } = 5.0m;

        public string? Comentario { get; set; }

        [Required]
        public DateTime FechaReseña { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; } = null!;

        [ForeignKey("IdComprador")]
        public Comprador Comprador { get; set; } = null!;
    }
}
