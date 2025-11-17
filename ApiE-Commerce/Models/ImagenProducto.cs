using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("ImagenProductos")]
    public class ImagenProducto
    {
        [Key]
        public int IdImagenProducto { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required, MaxLength(255)]
        public string URLImagen { get; set; } = null!;// Ruta a la imagen, ej: "/imagenes/producto123_img1.jpg"

         // clave foránea
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; } = null!;
    }
}
