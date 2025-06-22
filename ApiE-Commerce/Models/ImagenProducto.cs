using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class ImagenProducto
    {
        [Key]
        public int ImagenId { get; set; }
        [Required]
        public string ImagenUrl { get; set; } // Ruta a la imagen, ej: "/imagenes/producto123_img1.jpg"

        public int ProductoId { get; set; } // clave foránea
        [ForeignKey("ProductoId")]
        public Productos Producto { get; set; }
    }
}
