using System.ComponentModel.DataAnnotations;

namespace ApiProyectoDeCursoE_Commerce.Models.Finance
{
    public class TipoDeCuenta
    {
        [Key]
        public int IdTipoCuenta { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;
        public string? Categoria { get; set; }
        public string? Descripcion { get; set; }
    }
}
