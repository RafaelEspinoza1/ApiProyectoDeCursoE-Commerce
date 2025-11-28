using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.Models.Finance
{
    public class Cuenta
    {
        [Required]
        public int IdCuenta { get; set; }
        [Required]
        public int IdTipoCuenta { get; set; }
        public int ? IdVendedor { get; set; }
        [Required]
        public bool EsCuentaPlataforma { get; set; } = false;
        [Required]
        public string NombreCuenta { get; set; } = null!;
        [Required]
        public string CodigoCuenta { get; set; } = null!;
        [Required]
        public bool EsAfectable { get; set; } = true;
        [Required]
        public bool EsCuentaDeSistema { get; set; } = false;
        public string? Descripcion { get; set; } 
        [Required]
        public decimal SaldoActual { get; set; } = 0.0m;
    }
}
