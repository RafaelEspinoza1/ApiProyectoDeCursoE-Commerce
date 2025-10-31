using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("PasswordResets")]
    public class PasswordReset
    {
        [Key]
        public int IdReset { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [Required]
        public Guid Token { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime Expira { get; set; }

        [Required]
        public bool Usado { get; set; } = false;

        // Relación con Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; } = null!;
    }
}
