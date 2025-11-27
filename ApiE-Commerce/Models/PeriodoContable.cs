using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class PeriodoContable
    {
        [Key]
        public int IdPeriodo { get; set; }

        [Required]
        [Column(TypeName = "Date")] 
        public DateTime FechaInicio { get; set; }

        [Required]
        [Column(TypeName = "Date")] 
        public DateTime FechaFin { get; set; }

        [Required]
        public bool EstaCerrado { get; set; } = false;
    }
}
