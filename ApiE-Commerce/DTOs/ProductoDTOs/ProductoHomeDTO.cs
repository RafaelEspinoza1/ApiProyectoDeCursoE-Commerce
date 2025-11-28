namespace ApiProyectoDeCursoE_Commerce.DTOs.ProductoDTOs
{
    public class ProductoHomeDTO
    {
        public int IdProducto { get; set; }
        public required string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Datos JOIN
        public required string NombreVendedor { get; set; }
        public required string NombreCategoria { get; set; }
        public required string UrlImagenPrincipal { get; set; }
    }
}
