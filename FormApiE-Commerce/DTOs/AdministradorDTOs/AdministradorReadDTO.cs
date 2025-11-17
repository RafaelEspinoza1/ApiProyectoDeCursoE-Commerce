using System.ComponentModel.DataAnnotations;

namespace FormApiE_Commerce.DTOs.AdministradorDTOs
{
    public class AdministradorReadDTO
    {
        public int AdministradorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}
