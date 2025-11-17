using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.VendedoresDTOs
{
    public class VendedoresCreateDTO
    {
        [Required(ErrorMessage = "El numero de cuenta es obligatorio.")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "El número de cuenta debe tener exactamente 16 dígitos.")]
        public string NumeroDeCuenta { get; set; }
        
        [Required(ErrorMessage = "La direccion es obligatoria.")]
        public string DireccionOrigen { get; set; }

        [Required(ErrorMessage = "La latitud es obligatoria.")]
        [Range(-90, 90, ErrorMessage = "La latitud debe estar entre -90 y 90.")]
        public double LatitudOrigen { get; set; }

        [Required(ErrorMessage = "La longitud es obligatoria.")]
        [Range(-180, 180, ErrorMessage = "La longitud debe estar entre -180 y 180.")]
        public double LongitudOrigen { get; set; }

        public int UsuarioId { get; set; }
    }
}
