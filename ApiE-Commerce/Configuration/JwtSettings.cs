namespace ApiProyectoDeCursoE_Commerce.Configuration
{
    public class JwtSettings
    {
        // Configuración del JWT
        public string Key { get; set; } = null!;
        public string Issuer { get; set; } = null!;
        public string Audience { get; set; } = null!;
        public int ExpireMinutes { get; set; }
    }
}
