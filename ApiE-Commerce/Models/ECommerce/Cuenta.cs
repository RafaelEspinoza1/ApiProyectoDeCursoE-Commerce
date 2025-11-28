namespace ApiProyectoDeCursoE_Commerce.Models.ECommerce
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public int IdTipoCuenta { get; set; }
        public int? IdVendedor { get; set; }
        public bool EsCuentaPlataforma { get; set; } = false;
        public string NombreCuenta { get; set; } = string.Empty;
        public string CodigoCuenta { get; set; } = string.Empty;
        public bool EsAfectable { get; set; } = true;
        public bool EsCuentaDeSistema { get; set; } = false;
        public string? Descripcion { get; set; }
        public decimal SaldoActual { get; set; } = 0;
    }
}
