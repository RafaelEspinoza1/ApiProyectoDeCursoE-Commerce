using ApiProyectoDeCursoE_Commerce.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.ECommerce
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
    }
}