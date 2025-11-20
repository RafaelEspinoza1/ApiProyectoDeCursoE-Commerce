using System;

namespace FormApiE_Commerce
{
    public static class TokenStorage
    {
        // Guardar tokens en Properties.Settings
        public static void Save(AuthResponse authResponse)
        {
            Properties.Settings.Default.IdUsuario = authResponse.idUsuario;
            Properties.Settings.Default.JwtToken = authResponse.jwtToken;
            Properties.Settings.Default.RefreshToken = authResponse.refreshToken;

            Properties.Settings.Default.Save();
        }


        public static TokenData? Load()
        {
            return new TokenData
            {
                IdUsuario = Properties.Settings.Default.IdUsuario,
                JwtToken = Properties.Settings.Default.JwtToken ?? "",
                RefreshToken = Properties.Settings.Default.RefreshToken ?? "",
            };
        }


        // Limpiar tokens del sistema
        public static void Clear()
        {
            Properties.Settings.Default.IdUsuario = 0;
            Properties.Settings.Default.JwtToken = null;
            Properties.Settings.Default.RefreshToken = null;

            Properties.Settings.Default.Save();
        }
    }
}