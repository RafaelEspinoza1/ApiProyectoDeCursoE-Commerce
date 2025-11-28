namespace ApiProyectoDeCursoE_Commerce.Models.Auth
{
    public class RefreshToken
    {
        public int IdRefreshToken { get; set; }
        public int IdUsuario { get; set; }
        public Guid Token { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public bool Revoked { get; set; }
    }
}
