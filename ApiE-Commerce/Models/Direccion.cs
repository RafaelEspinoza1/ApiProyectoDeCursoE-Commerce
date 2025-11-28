using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace ApiProyectoDeCursoE_Commerce.Models
{
    [Table("Direcciones")]
    public class Direccion
    {
        [Key]
        public int IdDireccion { get; set; }

        public int? IdVendedor { get; set; }
        public int? IdComprador { get; set; }
        public string? Calle { get; set; }
        public string? Barrio { get; set; }
        public string ? Ciudad { get; set; }
        public string? Departamento { get; set; }
        public string? CodigoPostal { get; set; }

        [Required, MaxLength(255)]
        public string AliasDireccion { get; set; } = null!;

        [Required]
        public Point Ubicacion { get; set; } = null!; // NetTopologySuite Point para GEOGRAPHY
        [Required]
        public bool EsPrincipal { get; set; }

        // Relaciones
        [ForeignKey("IdVendedor")]
        public Vendedor? Vendedor { get; set; }

        [ForeignKey("IdComprador")]
        public Comprador? Comprador { get; set; }
    }
}
