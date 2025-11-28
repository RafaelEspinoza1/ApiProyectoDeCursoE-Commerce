using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.DTOs.TransaccionDTOs
{
    public class TransaccionCreateDTO
    {
        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int IdComprador { get; set; }

        [Required]
        public int IdVendedor { get; set; }

        [Required]
        public int IdEstadoTransaccion { get; set; }

        [Required]
        public int IdMetodoDePago { get; set; }

        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public int UnidadesCompradas { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? PrecioEnvio { get; set; } = 0m; // puede ser null

        [Column(TypeName = "decimal(10,2)")]
        public decimal Descuento { get; set; } = 0m;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioTotal { get; set; }

        [Required]
        public decimal CostoUnitario { get; set; }
    }
}
