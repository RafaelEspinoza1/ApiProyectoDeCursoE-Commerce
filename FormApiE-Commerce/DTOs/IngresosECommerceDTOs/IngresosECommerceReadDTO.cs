using FormApiE_Commerce.Enums;
using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.IngresosECommerceDTOs
{
    public class IngresosECommerceReadDTO
    {
        public int IngresoId { get; set; }
        public decimal Cantidad { get; set; }
        public TipoIngreso Tipo { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public int UsuarioId { get; set; } // Clave foránea a la tabla Vendedores
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
    }
}
