using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class FacturaComision
    {
        [Required]
        public int IdFacturaComision { get; set; }
        [Required]
        public int IdTransaccion { get; set; }
        [Required]
        public string NumeroFactura { get; set; } = null!;
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required]
        public int IdVendedor { get; set; }
        [Required]
        public string NombreVendedor { get; set; } = null!;
        [Required]
        public string NombreNegocio { get; set; } = null!;
        [Required]
        public string DireccionVendedor { get; set; } = null!;
        [Required]
        public bool EsContribuyente { get; set; }
        public decimal ? PorcentajeIVA { get; set; }
        [Required]
        public int UnidadesVendidas { get; set; }
        [Required]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public decimal PrecioTotalVenta { get; set; }
        [Required]
        public decimal PorcentajeComision { get; set; }
        [Required]
        public decimal MontoComision { get; set; }
        [Required]
        public decimal MontoIVAComision { get; set; }
        [Required]
        public decimal TotalAPagar { get; set; }
        [Required]
        public string EstadoPago { get; set; } = null!;
        public string MetodoPago { get; set; } 
    }
}
