using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.FORM_DTOs.TransaccionesDTOs
{
    internal class TransaccionUpdateDTO
    {
        public int IdTransaccion { get; set; }
        public int? IdEstadoTransaccion { get; set; }
    }
}