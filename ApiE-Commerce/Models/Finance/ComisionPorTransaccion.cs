using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.Finance
{
    public class ComisionPorTransaccion
    {
        [Key]
        public int IdComision { get; set; }
        [Required]
        public int IdTransaccion { get; set; }
        [Required]
        public int IdVendedor { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Porcentaje { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal MontoComision { get; set; }
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
