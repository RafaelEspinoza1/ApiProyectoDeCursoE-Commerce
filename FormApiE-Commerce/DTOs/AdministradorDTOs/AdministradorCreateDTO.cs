using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.AdministradorDTOs
{
    public class AdministradorCreateDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string Apellido { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [RegularExpression(@"^[^@\s]+@(gmail|yahoo|hotmail)\.com$",
    ErrorMessage = "Solo se permiten correos @gmail.com, @yahoo.com o @hotmail.com")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "ELa contraseña es obligatorio.")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Contraseña { get; set; }
    }
}
