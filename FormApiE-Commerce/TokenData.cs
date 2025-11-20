using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce
{
    public class TokenData
    {
        public int IdUsuario { get; set; }
        public string JwtToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public string JwtExpiry { get; set; } = string.Empty;
        public string RefreshExpiry { get; set; } = string.Empty;
    }

}
