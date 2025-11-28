using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.Finance
{
    public class DetalleRatioFinanciero
    {
        [Key]
        public int IdDetalleRatio { get; set; }

        [Required]
        public int IdRatio { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreComponente { get; set; } = string.Empty; // Ej: "Inventarios", "CostoVentas"

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Valor { get; set; }

        public int? IdCuenta { get; set; } // Opcional, si el valor proviene directamente de una cuenta

        // --- Propiedades de Navegación ---

        // FK_DetalleRatios_Ratio
        [ForeignKey("IdRatio")]
        public RatioFinanciero? RatioFinanciero { get; set; }

        // FK_DetalleRatios_Cuenta
        [ForeignKey("IdCuenta")]
        public Cuenta? Cuenta { get; set; } // Asumo que tienes una clase Cuenta
    }
}
