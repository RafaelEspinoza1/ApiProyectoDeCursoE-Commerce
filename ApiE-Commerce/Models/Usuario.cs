using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public required int IdRol { get; set; }
        [Required, MaxLength(30)]
        public required string PrimerNombre { get; set; }
        [MaxLength(30)]
        public string? SegundoNombre { get; set; }
        [Required, MaxLength(30)]
        public required string PrimerApellido { get; set; }
        [MaxLength(30)]
        public string? SegundoApellido { get; set; }
        [Required, MaxLength(20)]
        public required string Telefono { get; set; }
        [Required, MaxLength(50)]
        [EmailAddress]
        public required string Correo { get; set; }
        [Required]
        public byte[] Contraseña { get; set; } = null!;
    }
}
