namespace ApiProyectoDeCursoE_Commerce.Configuration
{
    public class JwtSettings
    {
        public string key { get; set; } = string.Empty;
        public string issuer { get; set; } = string.Empty;
        public string audience { get; set; } = string.Empty;
        public int ExpirationInMinutes { get; set; }
    }
}
