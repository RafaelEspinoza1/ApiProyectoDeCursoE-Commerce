using ApiProyectoDeCursoE_Commerce.Models.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models.ECommerce
{
    [Table("ReseñasVendedor")]
    public class ReseñaVendedor
    {
        [Key]
        public int IdReseñaVendedor { get; set; }

        [Required]
        public int IdVendedor { get; set; }

        [Required]
        public int IdComprador { get; set; }
        [Required]
        public int IdTransaccion { get; set; }


        [Required, Column(TypeName = "decimal(3,1)")]
        [Range(1, 5)]
        public decimal Calificacion { get; set; } = 5.0m;

        public string? Comentario { get; set; }

        [Required]
        public DateTime FechaReseña { get; set; } = DateTime.Now;

        // Relaciones
        [ForeignKey("IdVendedor")]
        public Vendedor Vendedor { get; set; } = null!;

        [ForeignKey("IdComprador")]
        public Comprador Comprador { get; set; } = null!;
    }
}
