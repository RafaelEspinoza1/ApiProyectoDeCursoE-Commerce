using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.Finance
{
    public class EstadoFinancieroDetalle
    {
        [Key]
        public int IdDetalle { get; set; }

        [Required]
        public int IdEstado { get; set; }

        [Required]
        public int IdCuenta { get; set; }

        [Required]
        [MaxLength(20)]
        public string TipoEstado { get; set; } = string.Empty; // "Balance" o "Resultado"

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo { get; set; }

        // Campos para Análisis Financiero (Opcionales)
        [Column(TypeName = "decimal(18,4)")]
        public decimal? PorcentajeVertical { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? VariacionAbsoluta { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? VariacionPorcentual { get; set; }

        // --- Propiedades de Navegación ---

        // FK_EFDetalles_Estado
        [ForeignKey("IdEstado")]
        public EstadoFinancieroGenerado? EstadoFinancieroGenerado { get; set; }

        // FK_EFDetalles_Cuenta
        [ForeignKey("IdCuenta")]
        public Cuenta? Cuenta { get; set; } 
    }
}
