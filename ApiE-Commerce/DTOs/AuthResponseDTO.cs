namespace ApiProyectoDeCursoE_Commerce.DTOs
{
    public class AuthResponseDTO
    {
        public int IdUsuario { get; set; } = 0;
        public string PrimerNombre { get; set; } = string.Empty;
        public string PrimerApellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public int Telefono { get; set; } = 0;
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
