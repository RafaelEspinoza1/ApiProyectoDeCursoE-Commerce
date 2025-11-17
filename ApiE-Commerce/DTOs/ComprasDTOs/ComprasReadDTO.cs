using ApiProyectoDeCursoE_Commerce.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoDeCursoE_Commerce.DTOs.ComprasDTOs
{
    public class ComprasReadDTO
    {
        public int CompraId { get; set; }
        public string CuentaUsuario { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; } 
        public decimal Envio { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; } 

        public double LatitudOrigen { get; set; }
        public double LongitudOrigen { get; set; }
        public string NombreDireccionOrigen { get; set; }
        public double LatitudDestino { get; set; }
        public double LongitudDestino { get; set; }
        public string NombreDireccionDestino { get; set; }

        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioApellido { get; set; }
        public int VendedorId { get; set; }
        public string VendedorNombre { get; set; }
        public string VendedorApellido { get; set; }
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; }
    }
}
