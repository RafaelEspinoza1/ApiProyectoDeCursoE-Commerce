using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Compradores")]
    public class Comprador
    {
        [Key]
        public int IdComprador { get; set; }
        [Required]
        public int IdUsuario { set; get; }
        //[Required, MaxLength(25)]
        //public string NumeroDeCuentaComprador { get; set; } = null!;
        //// Relación con Usuario
        //[ForeignKey("IdUsuario")]
        //public Usuario Usuario { get; set; } = null!;
        public ICollection<Transaccion>? Transacciones { get; set; }
        public ICollection<Direccion>? Direcciones { get; set; }
        public ICollection<ReseñaVendedor>? Reseñas { get; set; }
        public ICollection<ReseñaProducto>? ReseñasP { get; set; }
    }
}
