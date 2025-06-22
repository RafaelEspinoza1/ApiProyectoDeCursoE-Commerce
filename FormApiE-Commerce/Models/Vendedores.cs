using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormApiE_Commerce.Models
{
    public class Vendedores
    {
        [Key]
        public int VendedorId { set; get; }
        [Required]
        public string NumeroDeCuenta { set; get; }
        [Required]
        public decimal Ingresos { set; get; } = 0;
        [Required]
        public string DireccionOrigen { set; get; }
        [Required]
        public double LatitudOrigen { get; set; }
        [Required]
        public double LongitudOrigen { get; set; }

        public int UsuarioId { set; get; }
        [ForeignKey("UsuarioId")]
        public Usuarios Usuario { set; get; }
    }
}
