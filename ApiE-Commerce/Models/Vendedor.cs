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
        [MaxLength(100)]
        public string? NombreNegocio { set; get; }
        [Required, MaxLength(255)]
        public string? LogoNegocio { set; get; }
        [MaxLength(300)]
        public string? DescripcionNegocio { set; get; }
        [Required]
        public required bool EsContribuyente { get; set; }

        // Relación con Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { set; get; } = null!;

        // Relación inversa con Productos
        public ICollection<Producto>? Productos { get; set; }
        public ICollection<Direccion>? Direcciones { get; set; }
        public ICollection<ReseñaVendedor>? Reseñas { get; set; }
    }
}