using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class AuthService
{
    private readonly HttpClient _client;

    public AuthService()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri("http://localhost:5028/api/"); // cambia tu URL
    }

    public async Task<(bool ok, TokenStorage tokens)> Login(string username, string password)
    {
        var content = new StringContent(JsonConvert.SerializeObject(new
        {
            username,
            password
        }), Encoding.UTF8, "application/json");

        var res = await _client.PostAsync("Auth/login", content);
        if (!res.IsSuccessStatusCode) return (false, null);

        var json = await res.Content.ReadAsStringAsync();
        dynamic data = JsonConvert.DeserializeObject(json);

        var tokens = new TokenStorage
        {
            JwtToken = data.jwt,
            RefreshToken = data.refreshToken,
            JwtExpiry = DateTime.UtcNow.AddMinutes(15), // ajusta según tu API
            RefreshExpiry = DateTime.UtcNow.AddDays(7)
        };
        tokens.Save();
        return (true, tokens);
    }

    public async Task<(bool ok, TokenStorage tokens)> RefreshToken(string refreshToken)
    {
        var content = new StringContent(JsonConvert.SerializeObject(new
        {
            refreshToken
        }), Encoding.UTF8, "application/json");

        var res = await _client.PostAsync("auth/refresh", content);
        if (!res.IsSuccessStatusCode) return (false, null);

        var json = await res.Content.ReadAsStringAsync();
        dynamic data = JsonConvert.DeserializeObject(json);

        var tokens = new TokenStorage
        {
            JwtToken = data.jwt,
            RefreshToken = data.refreshToken,
            JwtExpiry = DateTime.UtcNow.AddMinutes(15),
            RefreshExpiry = DateTime.UtcNow.AddDays(7)
        };
        tokens.Save();
        return (true, tokens);
    }

    // Método de prueba para llamar a la API con JWT
    public async Task<string> GetProtectedData(string jwt)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
        var res = await _client.GetAsync("protected/data");
        return await res.Content.ReadAsStringAsync();
    }
}

