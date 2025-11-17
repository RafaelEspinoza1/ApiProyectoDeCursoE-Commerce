using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.FORM_DTOs.CompradoresDTOs
{
    internal class CompradorReadDTO
    {
        public int IdComprador { get; set; }
        public int IdUsuario { get; set; }
        public string NumeroDeCuentaComprador { get; set; }
    }
}
