using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class ComprobanteContable
    {
        [[Key]
        public int IdComprobante { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(50)]
        public string Tipo { get; set; } = string.Empty; // "Venta", "Compra", "Pago", "Ajuste", etc.

        [MaxLength(400)]
        public string? Descripcion { get; set; }

        public int? IdVendedor { get; set; }

        [Required]
        public bool EsComprobantePlataforma { get; set; } = false;

        // Propiedad de navegación para la relación FK_Comprobantes_Vendedores
        [ForeignKey("IdVendedor")]
        public Vendedor? Vendedor { get; set; }
    }
}
