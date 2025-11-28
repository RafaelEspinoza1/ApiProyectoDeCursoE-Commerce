using ApiProyectoDeCursoE_Commerce.Models.Auth;
using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.Finance
{
    public class MovimientoContable
    {
        [Key]
        public int IdMovimiento { get; set; }

        [Required]
        public int IdComprobante { get; set; }

        [Required]
        public int IdPeriodo { get; set; }

        [Required]
        public int IdCuenta { get; set; }

        public int? IdTransaccion { get; set; }

        public int? IdFactura { get; set; }

        public int? IdVendedor { get; set; }

        [Required]
        public bool EsMovimientoPlataforma { get; set; } = false;

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        // Valores de partida doble
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Debe { get; set; } = 0;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Haber { get; set; } = 0;

        [MaxLength(400)]
        public string? Descripcion { get; set; }

        // --- Propiedades de Navegación ---

        // FK_Movimientos_ComprobantesContables
        [ForeignKey("IdComprobante")]
        public ComprobanteContable? ComprobanteContable { get; set; }

        // FK_Movimientos_Periodo
        [ForeignKey("IdPeriodo")]
        public PeriodoContable? PeriodoContable { get; set; }

        // FK_Movimientos_Cuentas
        [ForeignKey("IdCuenta")]
        public Cuenta? Cuenta { get; set; }

        // FK_Movimientos_Transaccion
        [ForeignKey("IdTransaccion")]
        public Transaccion? Transaccion { get; set; } // Asumo que tienes una clase Transaccion

        // FK_Movimientos_Factura
        [ForeignKey("IdFactura")]
        public Factura? Factura { get; set; } // Asumo que tienes una clase Factura

        // FK_Movimientos_Vendedores
        [ForeignKey("IdVendedor")]
        public Vendedor? Vendedor { get; set; }
    }
}
