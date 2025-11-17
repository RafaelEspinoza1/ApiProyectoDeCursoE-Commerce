using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce.FORM_DTOs.TransaccionesDTOs
{
    internal class TransaccionReadDTO
    {
        public int IdTransaccion { get; set; }
        public string Producto { get; set; }
        public string Comprador { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
    }
}
