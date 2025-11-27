using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.DTOs
{
    public class RegistrarVendedorDTO
    {
        public string NombreNegocio { get; set; } = string.Empty;
        public string LogoNegocio { get; set; } = string.Empty;
        public string DescripcionNegocio { get; set; } = string.Empty;
        public bool EsContribuyente { get; set; } = false;
    }
}
