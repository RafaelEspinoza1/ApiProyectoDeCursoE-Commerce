using System;
using System.Security.Cryptography;
using System.Text;

namespace FormApiE_Commerce
{
    public static class TokenDataStorage
    {
        // Encriptar texto
        private static byte[] Encrypt(string plainText)
        {
            var bytes = Encoding.UTF8.GetBytes(plainText ?? "");
            return ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);
        }

        // Desencriptar texto de forma segura
        private static string Decrypt(byte[] cipherText)
        {
            try
            {
                if (cipherText == null || cipherText.Length == 0) return "";
                var bytes = ProtectedData.Unprotect(cipherText, null, DataProtectionScope.CurrentUser);
                return Encoding.UTF8.GetString(bytes);
            }
            catch
            {
                // Si falla la desencriptación, retornar cadena vacía
                return "";
            }
        }

        // Desencriptar de manera segura desde Base64
        private static string DecryptSafe(string? base64)
        {
            if (string.IsNullOrEmpty(base64)) return "";
            try
            {
                var bytes = Convert.FromBase64String(base64);
                return Decrypt(bytes);
            }
            catch
            {
                return "";
            }
        }

        // Guardar TokenData en Properties.Settings
        public static void Save(TokenData authResponse)
        {
            if (authResponse == null) return;

            Properties.Settings.Default.IdUsuario = authResponse.IdUsuario;
            Properties.Settings.Default.PrimerNombre = authResponse.PrimerNombre ?? "";
            Properties.Settings.Default.PrimerApellido = authResponse.PrimerApellido ?? "";
            Properties.Settings.Default.Correo = authResponse.Correo ?? "";
            Properties.Settings.Default.Telefono = authResponse.Telefono ?? "";

            // Encriptar tokens antes de guardar
            Properties.Settings.Default.Token = Convert.ToBase64String(Encrypt(authResponse.Token ?? ""));
            Properties.Settings.Default.RefreshToken = Convert.ToBase64String(Encrypt(authResponse.RefreshToken ?? ""));

            Properties.Settings.Default.Save();
        }

        // Cargar TokenData desde Properties.Settings
        public static TokenData? Load()
        {
            return new TokenData
            {
                IdUsuario = Properties.Settings.Default.IdUsuario,
                PrimerNombre = Properties.Settings.Default.PrimerNombre ?? "",
                PrimerApellido = Properties.Settings.Default.PrimerApellido ?? "",
                Correo = Properties.Settings.Default.Correo ?? "",
                Telefono = Properties.Settings.Default.Telefono ?? "",
                Token = DecryptSafe(Properties.Settings.Default.Token),
                RefreshToken = DecryptSafe(Properties.Settings.Default.RefreshToken)
            };
        }

        // Limpiar tokens y datos del sistema
        public static void Clear()
        {
            Properties.Settings.Default.IdUsuario = 0;
            Properties.Settings.Default.PrimerNombre = "";
            Properties.Settings.Default.PrimerApellido = "";
            Properties.Settings.Default.Correo = "";
            Properties.Settings.Default.Telefono = "";
            Properties.Settings.Default.Token = "";
            Properties.Settings.Default.RefreshToken = "";

            Properties.Settings.Default.Save();
        }
    }
}
