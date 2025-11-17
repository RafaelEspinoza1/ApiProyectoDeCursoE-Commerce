using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Vendedores")]
    public class Vendedor
    {
        [Key]
        public int IdVendedor { set; get; }
        [Required]
        public int IdUsuario { set; get; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Ingresos { set; get; } = 0;
        [Required, MaxLength(25)]
        public string NumeroDeCuentaVendedor { set; get; }

        // Relación con Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { set; get; } = null!;

        // Relación inversa con Productos
        public ICollection<Producto>? Productos { get; set; }
        public ICollection<Direccion>? Direcciones { get; set; }
        public ICollection<ReseñaVendedor>? Reseñas { get; set; }
    }
}