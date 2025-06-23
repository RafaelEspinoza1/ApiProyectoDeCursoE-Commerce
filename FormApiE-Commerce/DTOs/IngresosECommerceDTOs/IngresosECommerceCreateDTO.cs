using FormApiE_Commerce.Enums;
using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.IngresosECommerceDTOs
{
    public class IngresosECommerceCreateDTO
    {
        [Required]
        [Range(0.01, 999999.99, ErrorMessage = "La cantidad debe ser mayor que 0.")]
        public decimal Cantidad { get; set; }
        [Required]
        [Range(1, 2, ErrorMessage = "Solo se puede ingresar 1 0 2, tipo 1 = ComisionDeVenta , tipo 2 = Envio")]
        public TipoIngreso Tipo { get; set; }
        [Required]

        public int UsuarioId { get; set; } // Clave foránea a la tabla Vendedores
    }
}
