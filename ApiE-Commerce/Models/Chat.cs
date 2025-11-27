using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Chats")]
    public class Chat
    {
        [Key]
        public int IdChat { get; set; }
        public int IdProducto { get; set; }
        public int IdTransaccion { get; set; }


        [Required]
        public DateTime FechaInicio { get; set; } = DateTime.Now;

        public DateTime? FechaFinal { get; set; }

        [Required]
        public bool Estado { get; set; } = true;

        // Relación con Mensajes
        public ICollection<Mensaje>? Mensajes { get; set; }

        // Relación con ParticipanEnChat
        public ICollection<ParticipanEnChat>? Participantes { get; set; }
    }
}
