using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.ProductoDTOs
{
    public class ProductoUpdateDTO
    {
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del producto no puede tener más de 100 caracteres.")]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [StringLength(500, ErrorMessage = "La descripción no puede tener más de 500 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, 999999.99, ErrorMessage = "El precio debe ser mayor que 0.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa.")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "El tipo de producto es obligatorio.")]
        [StringLength(50, ErrorMessage = "El tipo no puede tener más de 50 caracteres.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El estado del producto es obligatorio.")]
        [StringLength(50, ErrorMessage = "El estado no puede tener más de 50 caracteres.")]
        public string Estado { get; set; }
    }
}
