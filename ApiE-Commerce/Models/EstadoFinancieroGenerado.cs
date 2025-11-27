using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class EstadoFinancieroGenerado
    {
        [Key]
        public int IdEstado { get; set; }

        [Required]
        public int IdPeriodo { get; set; }

        public int? IdVendedor { get; set; }

        [Required]
        public bool EsEstadoPlataforma { get; set; } = false;

        // --- Totales Generales ---

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalActivos { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPasivos { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalCapital { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalIngresos { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalGastos { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UtilidadNeta { get; set; }

        [Required]
        public DateTime FechaGeneracion { get; set; } = DateTime.Now;

        // --- Propiedades de Navegación ---

        // FK_Estados_Periodo
        [ForeignKey("IdPeriodo")]
        public PeriodoContable? PeriodoContable { get; set; }

        // FK_Estados_Vendedores
        [ForeignKey("IdVendedor")]
        public Vendedor? Vendedor { get; set; }
    }
}
