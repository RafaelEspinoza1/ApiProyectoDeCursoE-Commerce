using System;

namespace FormApiE_Commerce
{
    public static class TokenDataStorage
    {
        // Guardar tokens en Properties.Settings
        public static void Save(TokenData authResponse)
        {
            Properties.Settings.Default.IdUsuario = authResponse.IdUsuario;
            Properties.Settings.Default.PrimerNombre = authResponse.PrimerNombre;
            Properties.Settings.Default.PrimerApellido = authResponse.PrimerApellido;
            Properties.Settings.Default.Correo = authResponse.Correo;
            Properties.Settings.Default.Telefono = authResponse.Telefono;
            Properties.Settings.Default.Token = authResponse.Token;
            Properties.Settings.Default.RefreshToken = authResponse.RefreshToken;

            Properties.Settings.Default.Save();
        }


        public static TokenData? Load()
        {
            return new TokenData
            {
                IdUsuario = Properties.Settings.Default.IdUsuario,
                PrimerNombre = Properties.Settings.Default.PrimerNombre ?? "",
                PrimerApellido = Properties.Settings.Default.PrimerApellido ?? "",
                Correo = Properties.Settings.Default.Correo ?? "",
                Telefono = Properties.Settings.Default.Telefono,
                Token = Properties.Settings.Default.Token ?? "",
                RefreshToken = Properties.Settings.Default.RefreshToken ?? "",
            };
        }


        // Limpiar tokens del sistema
        public static void Clear()
        {
            Properties.Settings.Default.IdUsuario = 0;
            Properties.Settings.Default.PrimerNombre = null;
            Properties.Settings.Default.PrimerApellido = null;
            Properties.Settings.Default.Correo = null;
            Properties.Settings.Default.Telefono = 0;
            Properties.Settings.Default.Token = null;
            Properties.Settings.Default.RefreshToken = null;

            Properties.Settings.Default.Save();
        }
    }
}