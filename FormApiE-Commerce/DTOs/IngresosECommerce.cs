using FormApiE_Commerce.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormApiE_Commerce.Models
{
    public class IngresosECommerce
    {
        [Key]
        public int IngresoId { get; set; }
        [Required]
        public decimal Cantidad { get; set; }
        [Required]
        public TipoIngreso Tipo { get; set; }
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public int UsuarioId { get; set; } // Clave foránea a la tabla Vendedores
        [ForeignKey("UsuarioId")]
        public Usuarios Usuario { get; set; } // Navegación a la entidad Vendedores
    }
}
