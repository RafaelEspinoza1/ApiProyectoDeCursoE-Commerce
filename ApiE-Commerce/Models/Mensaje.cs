﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Mensajes")]
    public class Mensaje
    {
        [Key]
        public int IdMensaje { get; set; }

        [Required]
        public int IdChat { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [Required]
        public string Contenido { get; set; } = null!;

        // Relaciones
        [ForeignKey("IdChat")]
        public Chat Chat { get; set; } = null!;

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; } = null!;
    }
}
