using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce
{
    public class TokenData
    {
        public int IdUsuario { get; set; } = 0;
        public string PrimerNombre { get; set; } = string.Empty;
        public string PrimerApellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
