namespace ApiProyectoDeCursoE_Commerce.DTOs.ProductoDTOs
{
    public class ProductoUpdateDTO
    {
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
    }
}
