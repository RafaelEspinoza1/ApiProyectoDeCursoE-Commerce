using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.FORM_DTOs.ChatDTOs
{
    internal class MensajeReadDTO
    {
        public int IdMensaje { get; set; }
        public int IdUsuario { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
    }
}
