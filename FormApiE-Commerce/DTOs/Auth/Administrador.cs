using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.Auth
{
    public class Administrador
    {
        [Key]
        public int AdministradorId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string Contraseña { get; set; }
    }
}
