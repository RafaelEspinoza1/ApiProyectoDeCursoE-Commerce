using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        public string NombreProducto { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public decimal Cantidad { get; set; }
        [Required]
        public string Estado { get; set; }

        public int VendedorId { get; set; }
        [ForeignKey("VendedorId")]
        public Vendedores Vendedor { get; set; }

        public List<ImagenProducto> Imagenes { get; set; } = new List<ImagenProducto>();
    }
}
