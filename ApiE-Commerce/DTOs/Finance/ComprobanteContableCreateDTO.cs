using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.Finance
{
    public class ComprobanteContableCreateDTO
    {
        [Required]
        [MaxLength(50)]
        public string Tipo { get; set; } = string.Empty; // "Venta", "Compra", "Pago", "Ajuste", etc.

        [MaxLength(400)]
        public string? Descripcion { get; set; }

        public int? IdVendedor { get; set; }

        [Required]
        public bool EsComprobantePlataforma { get; set; } = false;
    }
}