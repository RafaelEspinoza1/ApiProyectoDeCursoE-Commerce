
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.DTOs.Ecommerce
{
    public class Productos
    {
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

        [Required]
        public DateTime FechaPublicacion { get; set; } = DateTime.Now;

        public ICollection<ImagenProducto>? Imagenes { get; set; }
      

    }
}
