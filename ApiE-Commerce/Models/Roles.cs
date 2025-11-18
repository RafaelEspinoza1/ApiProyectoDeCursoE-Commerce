using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class Roles
    {
        [Key]
        public int IdRol { get; set; }
        [Required, MaxLength(60)]
        public required string Rol { get; set; }
    }
}
