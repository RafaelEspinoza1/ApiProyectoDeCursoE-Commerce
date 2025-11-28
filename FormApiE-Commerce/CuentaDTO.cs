using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApiE_Commerce
{
    public class CuentaDTO
    {
        public int IdCuenta { get; set; }
        public int IdTipoCuenta { get; set; }
        public int? IdVendedor { get; set; }
        public bool EsCuentaPlataforma { get; set; }
        public string NombreCuenta { get; set; }
        public string CodigoCuenta { get; set; }
        public bool EsAfectable { get; set; }
        public bool EsCuentaDeSistema { get; set; }
        public string Descripcion { get; set; }
        public decimal SaldoActual { get; set; }
    }
}
