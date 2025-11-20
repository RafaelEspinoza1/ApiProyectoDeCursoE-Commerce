using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce
{
    public class AuthResponse
    {
        public int idUsuario { get; set; }
        public string jwtToken { get; set; } = string.Empty;
        public string refreshToken { get; set; } = string.Empty;
    }
}
