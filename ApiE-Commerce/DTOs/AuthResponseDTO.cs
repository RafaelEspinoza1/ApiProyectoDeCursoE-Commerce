namespace ApiProyectoDeCursoE_Commerce.DTOs
{
    public class AuthResponseDTO
    {
        public int IdUsuario { get; set; }
        public string JwtToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
