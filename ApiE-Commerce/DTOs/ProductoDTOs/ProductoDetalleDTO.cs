namespace ApiProyectoDeCursoE_Commerce.DTOs.ProductoDTOs
{
    public class ProductoDetalleDTO
    {
        public int IdProducto { get; set; }
        public required string Nombre { get; set; }
        public decimal Precio { get; set; }
        public required string Descripcion { get; set; }
        public int StockDisponible { get; set; }
        public DateTime FechaPublicacion { get; set; }

        // Datos JOIN
        public required string NombreCategoria { get; set; }
        public required string NombreEstado { get; set; }

        // Información del Vendedor
        public required string NombreNegocio { get; set; }
        public required string LogoNegocioUrl { get; set; }

        // Todas las imágenes
        public required List<string> UrlImagenes { get; set; }
    }
}
