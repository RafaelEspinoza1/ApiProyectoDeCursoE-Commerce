using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.DTOs.Ecommerce
{
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
            public Productos Producto { get; set; } = null!;
   
    }
}
