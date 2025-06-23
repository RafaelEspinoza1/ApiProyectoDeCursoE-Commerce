namespace FormApiE_Commerce.DTOs.ProductoDTOs
{
    public class ProductoReadDTO
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public int VendedorId { get; set; }
        public string VendedorNombre { get; set; }
        public string VendedorApellido { get; set; }
        public List<string> Imagenes { get; set; }
    }
}
