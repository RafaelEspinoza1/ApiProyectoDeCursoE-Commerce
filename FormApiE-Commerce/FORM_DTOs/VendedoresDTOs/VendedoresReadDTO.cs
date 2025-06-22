namespace FormApiE_Commerce.VendedoresDTOs
{
    public class VendedoresReadDTO
    {
        public int VendedorId { get; set; }
        public string NumeroDeCuenta { get; set; }
        public decimal Ingresos { get; set; }
        public string DireccionOrigen { get; set; }
        public double LatitudOrigen { get; set; }
        public double LongitudOrigen { get; set; }

        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioApellido { get; set; }
        public string UsuarioCorreo { get; set; }
    }
}
