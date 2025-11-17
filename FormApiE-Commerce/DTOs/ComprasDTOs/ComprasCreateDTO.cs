using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormApiE_Commerce.DTOs.ComprasDTOs
{
    public class ComprasCreateDTO
    {
        [Required(ErrorMessage = "El numero de cuenta es obligatorio.")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "El número de cuenta debe tener exactamente 16 dígitos.")]
        public string CuentaUsuario { get; set; }
        [Required(ErrorMessage = "La cantidad es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa.")]
        public decimal Cantidad { get; set; } = 1;
        [Required(ErrorMessage = "Si no se realiza un envio puedes dejarlo en 0, pero no vacio ni negativo.")]
        [Range(0, int.MaxValue, ErrorMessage = "El envio no puede ser negativa.")]
        public decimal Envio { get; set; } = 0;

        [Required(ErrorMessage = "La latitud es obligatoria.")]
        [Range(-90, 90, ErrorMessage = "La latitud debe estar entre -90 y 90.")]
        public double LatitudDestino { get; set; }
        [Required(ErrorMessage = "La longitud es obligatoria.")]
        [Range(-180, 180, ErrorMessage = "La longitud debe estar entre -180 y 180.")]
        public double LongitudDestino { get; set; }
        [Required(ErrorMessage = "La direccion es obligatoria.")]
        public string NombreDireccionDestino { get; set; }

        [Required(ErrorMessage = "El ID del usuario es obligatorio.")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "El ID del vendedor es obligatorio.")]
        public int VendedorId { get; set; }
        [Required(ErrorMessage = "El ID del producto es obligatorio.")]
        public int ProductoId { get; set; }
    }
}
