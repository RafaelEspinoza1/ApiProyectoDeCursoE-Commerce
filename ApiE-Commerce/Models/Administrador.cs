using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    public class Administrador
    {
        [Key]
        public int IdAdministrador { get; set; }
        [Required]
        public int IdUsuario { set; get; }
        //// Relación con Usuario
        //[ForeignKey("IdUsuario")]
        //public Usuario Usuario { get; set; } = null!;
    }
}
