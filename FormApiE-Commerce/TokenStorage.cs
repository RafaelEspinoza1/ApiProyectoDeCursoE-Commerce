using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

public class TokenStorage
{
    private static readonly string FilePath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "ecommerce_tokens.json");

    public string? JwtToken { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime JwtExpiry { get; set; }
    public DateTime RefreshExpiry { get; set; }

    // Guardar tokens cifrados
    public void Save()
    {
        var json = JsonConvert.SerializeObject(this);
        var encrypted = ProtectedData.Protect(
            Encoding.UTF8.GetBytes(json),
            null,
            DataProtectionScope.CurrentUser);
        File.WriteAllBytes(FilePath, encrypted);
    }

    // Cargar tokens cifrados
    public static TokenStorage? Load()
    {
        if (!File.Exists(FilePath)) return null;

        var encrypted = File.ReadAllBytes(FilePath);
        var jsonBytes = ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser);
        var json = Encoding.UTF8.GetString(jsonBytes);

        return JsonConvert.DeserializeObject<TokenStorage>(json)!;
    }

    // Limpiar tokens
    public static void Clear()
    {
        if (File.Exists(FilePath)) File.Delete(FilePath);
    }
}
