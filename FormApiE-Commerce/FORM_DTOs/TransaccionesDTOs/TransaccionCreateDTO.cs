using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.FORM_DTOs.TransaccionesDTOs
{
    internal class TransaccionCreateDTO
    {
        public int IdProducto { get; set; }
        public int IdComprador { get; set; }
        public int IdEstadoTransaccion { get; set; }
        public int IdMetodoDePago { get; set; }
        public int UnidadesCompradas { get; set; }
        public decimal PrecioEnvio { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
