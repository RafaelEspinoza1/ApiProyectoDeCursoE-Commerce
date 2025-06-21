using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public string Telefono { get; set; }
    }
}
