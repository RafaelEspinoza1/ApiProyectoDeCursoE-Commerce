using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("EstadosProducto")]
    public class EstadoProducto
    {
        [Key]
        public int IdEstadoProducto { get; set; }

        [Required, MaxLength(20)]
        public string NombreEstado { get; set; } = null!;

        // Relación con productos
        public ICollection<Producto>? Productos { get; set; }
    }
}
