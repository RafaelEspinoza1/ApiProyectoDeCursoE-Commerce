using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required, MaxLength(50)]
        public string NombreCategoria { get; set; }
        // Relación con productos, navegación automática, para consultas más limpias y carga de datos relacionados fácil.
        public ICollection<Producto>? Productos { get; set; }
    }
}
