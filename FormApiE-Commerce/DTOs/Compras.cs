using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormApiE_Commerce.Models
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        [Required]
        public string CuentaUsuario { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public decimal Cantidad { get; set; } = 1;
        [Required]
        public decimal Envio { get; set; } = 0;
        [Required]
        public decimal PrecioTotal { get; set; }
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        public double LatitudOrigen { get; set; }
        [Required]
        public double LongitudOrigen { get; set; }
        [Required]
        public string NombreDireccionOrigen { get; set; }
        [Required]
        public double LatitudDestino { get; set; }
        [Required]
        public double LongitudDestino { get; set; }
        [Required]
        public string NombreDireccionDestino { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuarios Usuario { get; set; }
        public int VendedorId { get; set; }
        [ForeignKey("VendedorId")]
        public Vendedores Vendedor { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Productos Producto { get; set; }
    }
}
