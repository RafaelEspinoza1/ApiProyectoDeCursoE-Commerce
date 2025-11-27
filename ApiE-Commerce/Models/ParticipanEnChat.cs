using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("ParticipanEnChat")]
    public class ParticipanEnChat
    {
        [Key, Column(Order = 0)]
        public int IdUsuario { get; set; }

        [Key, Column(Order = 1)]
        public int IdChat { get; set; }

        public string RolEnChat { get; set; } = null!;
        // Relaciones
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; } = null!;

        [ForeignKey("IdChat")]
        public Chat Chat { get; set; } = null!;
    }
}
