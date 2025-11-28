using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.ECommerce
{
    [Table("MetodosDePago")]
    public class MetodoDePago
    {
        [Key]
        public int IdMetodoDePago { get; set; }

        [Required, MaxLength(25)]
        public string NombreMetodoDePago { get; set; } = null!;
        public ICollection<Transaccion>? Transacciones { get; set; }
    }
}
