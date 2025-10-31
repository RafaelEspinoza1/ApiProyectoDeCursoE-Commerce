using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Tags("TiposIngreso")]
    public class TipoIngreso
    {
        [Key]
        public int IdTipoIngreso { get; set; }

        [Required, MaxLength(20)]
        public string Detalle { get; set; } = null!;
        public ICollection<Ingreso>? Ingresos { get; set; }
    }
}
