using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormApiE_Commerce.DTOs.Auth
{
    public class Vendedores
    {
        [Key]
        public int VendedorId { set; get; }
        public int UsuarioId { set; get; }
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
    }
}
