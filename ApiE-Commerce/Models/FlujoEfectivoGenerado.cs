using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class FlujoEfectivoGenerado
    {
        [Key]
        public int IdFlujo { get; set; }

        [Required]
        public int IdPeriodo { get; set; }

        public int? IdVendedor { get; set; }

        [Required]
        public bool EsFlujoPlataforma { get; set; } = false;

        // --- Flujo de Efectivo por Actividades ---

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FlujoOperacion { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FlujoInversion { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FlujoFinanciamiento { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AumentoDisminucionEfectivo { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal EfectivoInicial { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal EfectivoFinal { get; set; }

        [Required]
        [MaxLength(20)]
        public string Metodo { get; set; } = string.Empty; // "Directo" o "Indirecto"

        [Required]
        public DateTime FechaGeneracion { get; set; } = DateTime.Now;

        // --- Propiedades de Navegación ---

        // FK_Flujos_Periodo
        [ForeignKey("IdPeriodo")]
        public PeriodoContable? PeriodoContable { get; set; }

        // FK_Flujos_Vendedores
        [ForeignKey("IdVendedor")]
        public Vendedor? Vendedor { get; set; }
    }
}
