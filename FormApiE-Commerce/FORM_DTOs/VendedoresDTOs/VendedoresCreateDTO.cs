using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.VendedoresDTOs
{
    public class VendedoresCreateDTO
    {
        [Required(ErrorMessage = "El numero de cuenta es obligatorio.")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "El número de cuenta debe tener exactamente 16 dígitos.")]
        public string NumeroDeCuenta { get; set; }
        
        [Required(ErrorMessage = "La direccion es obligatoria.")]
        public string DireccionOrigen { get; set; }

        [Required(ErrorMessage = "La latitud es obligatoria.")]
        public double LatitudOrigen { get; set; }

        [Required(ErrorMessage = "La longitud es obligatoria.")]
        public double LongitudOrigen { get; set; }

        public int UsuarioId { get; set; }
    }
}
