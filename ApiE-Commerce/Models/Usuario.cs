using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required, MaxLength(30)]
        public string PrimerNombre { get; set; }
        [MaxLength(30)]
        public string? SegundoNombre { get; set; }
        [Required, MaxLength(30)]
        public string PrimerApellido { get; set; }
        [MaxLength(30)]
        public string? SegundoApellido { get; set; }
        [Required, MaxLength(20)]
        public string Telefono { get; set; }
        [Required, MaxLength(50)]
        [EmailAddress]
        public string Correo { get; set; }
        [Required, MaxLength(128)]
        public string Contraseña { get; set; }
        // Relaciones
        public ICollection<Vendedor>? Vendedores { get; set; }
        public ICollection<Comprador>? Compradores { get; set; }
        public ICollection<Administrador>? Administradores { get; set; }
        public ICollection<Mensaje>? Mensajes { get; set; }
        public ICollection<ParticipanEnChat>? Participaciones { get; set; }
        public ICollection<PasswordReset>? PasswordResets { get; set; }
    }
}
