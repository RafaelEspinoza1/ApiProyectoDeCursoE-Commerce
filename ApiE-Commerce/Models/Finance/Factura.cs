using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.Models.Finance
{
    public class Factura
    {
        [Required]
        public int IdFactura { get; set; }
        [Required]
        public int IdTransaccion { get; set; }
        [Required]
        public string NumeroFactura { get; set; } = null!;
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required]
        public string NombreComprador { get; set; } = null!;
        [Required]
        public string CorreoComprador { get; set; } = null!;
        [Required]
        public string DireccionComprador { get; set; } = null!;
        [Required]
        public string NombreVendedor { get; set; } = null!;
        public string? NombreNegocio { get; set; }
        [Required]
        public string DireccionVendedor { get; set; } = null!;
        [Required]
        public bool EsContribuyente { get; set; } 
        public decimal ? PorcentajeIVA { get; set; }
        public string? NombreProducto { get; set; } 
        public string ? DescripcionProducto { get; set; }
        [Required]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public int UnidadesCompradas { get; set; }
        public decimal ? Descuento { get; set; }
        public decimal ? PrecioEnvio { get; set; }
        [Required]
        public decimal SubtotalSinIVA { get; set; }
        public decimal ? MontoIVA { get; set; }
        [Required]
        public  decimal Total { get; set; }
        [Required]
        public string MetodoPago { get; set; } = null!;
        [Required]
        public string EstadoTransaccion { get; set; } = null!;
    }
}
