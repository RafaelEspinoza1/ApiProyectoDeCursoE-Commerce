using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.DTOs.Auth.UsuariosDTOs
{
    public class UsuariosUpdateDTO
    {
        [Required(ErrorMessage = "El primer nombre es obligatorio")]
        public required string PrimerNombre { get; set; }
        [Required(ErrorMessage = "El segundo nombre es necesario para cambiar otros atributos")]
        public string? SegundoNombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        public required string PrimerApellido { get; set; }
        [Required(ErrorMessage = "El segundo apellido es necesario para cambiar otros atributos")]
        public required string SegundoApellido { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [RegularExpression(@"^[^@\s]+@(gmail|yahoo|hotmail)\.com$",
    ErrorMessage = "Solo se permiten correos @gmail.com, @yahoo.com o @hotmail.com")]
        public required string Correo { get; set; } 

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public required string Contraseña { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^[1-9][0-9]{7}$", ErrorMessage = "El número debe tener 8 dígitos y no puede iniciar con 0.")]
        public required string Telefono { get; set; }
    }
}
