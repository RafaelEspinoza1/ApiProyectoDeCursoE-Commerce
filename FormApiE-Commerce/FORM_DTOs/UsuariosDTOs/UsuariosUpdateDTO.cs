using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.UsuariosDTOs
{
    public class UsuariosUpdateDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [RegularExpression(@"^[^@\s]+@(gmail|yahoo|hotmail)\.com$",
    ErrorMessage = "Solo se permiten correos @gmail.com, @yahoo.com o @hotmail.com")]
        public string Correo { get; set; } 

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^[1-9][0-9]{7}$", ErrorMessage = "El número debe tener 8 dígitos y no puede iniciar con 0.")]
        public string Telefono { get; set; }
    }
}
