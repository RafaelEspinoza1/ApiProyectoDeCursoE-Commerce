using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.IngresosECommerceDTOs
{
    public class IngresosECommerceUpdateDTO
    {
        [Required]
        [Range(0.01, 999999.99, ErrorMessage = "La cantidad debe ser mayor que 0.")]
        public decimal Cantidad { get; set; }
        //[Required]
        //[Range(1,2, ErrorMessage = "Solo se puede ingresar 1 0 2, tipo 1 = ComisionDeVenta , tipo 2 = Envio")]
        //public TipoIngreso Tipo { get; set; }
    }
}
