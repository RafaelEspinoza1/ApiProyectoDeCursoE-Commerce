using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.ECommerce
{
    [Table("EstadosTransaccion")]
    public class EstadoTransaccion
    {
        [Key]
        public int IdEstadoTransaccion { get; set; }

        [Required, MaxLength(25)]
        public string NombreEstadoTransaccion { get; set; } = null!;
        public ICollection<Transaccion>? Transacciones { get; set; }
    }
}
