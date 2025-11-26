using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormApiE_Commerce.DTOs
{
    public class VendedorCreateDTO
    {
        [Required(ErrorMessage = "El rol es obligatorio")]
        public required int IdRol { get; set; }

        [Required(ErrorMessage = "El primer nombre es obligatorio")]
        [MaxLength(30)]
        public required string PrimerNombre { get; set; }

        [MaxLength(30)]
        public string? SegundoNombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [MaxLength(30)]
        public required string PrimerApellido { get; set; }

        [MaxLength(30)]
        public string? SegundoApellido { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [MaxLength(20)]
        public required string Telefono { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public required string Correo { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public required string Contraseña { get; set; }


        [Required(ErrorMessage = "El nombre del negocio es obligatorio")]
        [MaxLength(100)]
        public required string NombreNegocio { get; set; }

        [MaxLength(255)]
        public string? LogoNegocio { get; set; }

        [MaxLength(300)]
        public string? DescripcionNegocio { get; set; }

        [Required(ErrorMessage = "El campo EsContribuyente es obligatorio")]
        public required bool EsContribuyente { get; set; }
    }
}
