using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.DTOs
{
    public class UsuariosCreateDTO
    {
        [Required]
        public required int IdUsuario { get; set; }
        [Required]
        public required int IdComprador { get; set; }
        [Required]
        public required int IdVendedor { get; set; }
        [Required]
        public required int IdAdministrador { get; set; }
        [Required(ErrorMessage = "El rol es obligatorio")]
        public required int IdRol { get; set; }
        [Required(ErrorMessage = "El primer nombre es obligatorio")]
        public required string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        public required string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
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
        [MaxLength(100)]
        public string? NombreNegocio { get; set; }
        [MaxLength(255)]
        public string? LogoNegocio { get; set; }
        [MaxLength(300)]
        public string? DescripcionNegocio { get; set; }
        [Required]
        public bool EsContribuyente { get; set; }
    }
}
