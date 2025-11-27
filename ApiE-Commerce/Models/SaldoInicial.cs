using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class SaldoInicial
    {
        [Key]
        public int IdSaldo { get; set; }

        [Required]
        public int IdCuenta { get; set; }

        [Required]
        public int IdPeriodo { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SaldoInicialMonto { get; set; } // Renombrado para evitar conflicto con el nombre de la clase

        // Propiedades de navegación para las claves foráneas

        [ForeignKey("IdCuenta")]
        public Cuenta? Cuenta { get; set; }

        [ForeignKey("IdPeriodo")]
        public PeriodoContable? PeriodoContable { get; set; }
    }
}
