using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class RatioFinanciero
    {
        [Key]
        public int IdRatio { get; set; }

        [Required]
        public int IdPeriodo { get; set; }

        public int? IdVendedor { get; set; }

        [Required]
        public bool EsRatioPlataforma { get; set; } = false;

        // --- Razones de liquidez ---

        [Column(TypeName = "decimal(18,4)")]
        public decimal? RazonCorriente { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? PruebaAcida { get; set; }

        // --- Razones de actividad ---

        [Column(TypeName = "decimal(18,4)")]
        public decimal? RotacionInventarios { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? RotacionCuentasPorCobrar { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? PeriodoPromedioCobro { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? RotacionActivosFijos { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? RotacionActivosTotales { get; set; }

        // --- Razones de endeudamiento ---

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DeudaTotalSobreActivos { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DeudaCapital { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? RotacionInteresesAUtilidades { get; set; }

        // --- Razones de rentabilidad ---

        [Column(TypeName = "decimal(18,4)")]
        public decimal? MargenBruto { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? MargenOperativo { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? MargenNeto { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? ROA { get; set; } // Retorno sobre Activos (Return on Assets)

        [Column(TypeName = "decimal(18,4)")]
        public decimal? ROE { get; set; } // Retorno sobre Patrimonio (Return on Equity)

        // --- Sistema DuPont ---

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DuPont_MargenNeto { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DuPont_RotacionActivos { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DuPont_ApalancamientoFinanciero { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DuPont_ROE { get; set; }

        [Required]
        public DateTime FechaGeneracion { get; set; } = DateTime.Now;

        // --- Propiedades de Navegación ---

        // FK_Ratios_Periodo
        [ForeignKey("IdPeriodo")]
        public PeriodoContable? PeriodoContable { get; set; }

        // FK_Ratios_Vendedores
        [ForeignKey("IdVendedor")]
        public Vendedor? Vendedor { get; set; }
    }
}
