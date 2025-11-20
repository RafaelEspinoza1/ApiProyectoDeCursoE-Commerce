using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.DTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthRepository _authRepository;
    private readonly RefreshTokenRepository _refreshRepository;
    private readonly JwtService _jwtService;

    public AuthController(
        AuthRepository authRepository,
        RefreshTokenRepository resfreshRepository,
        JwtService jwtService)
    {
        _authRepository = authRepository;
        _refreshRepository = resfreshRepository;
        _jwtService = jwtService;
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<ActionResult<AuthResponseDTO>> Login([FromBody] LoginDTO login)
    {
        RefreshToken refreshToUse;
        Usuario? user;

        // -----------------------------------------
        // 0. Login rápido con refresh token
        // -----------------------------------------
        if (!string.IsNullOrWhiteSpace(login.RefreshToken))
        {
            if (!Guid.TryParse(login.RefreshToken, out Guid refreshGuid))
                return Unauthorized("Refresh token inválido");

            var refreshToken = await _refreshRepository.GetActiveToken(login.IdUsuario, refreshGuid);

            if (refreshToken == null || refreshToken.Revoked)
                return Unauthorized("Refresh token inválido o revocado");

            if (refreshToken.FechaExpiracion < DateTime.UtcNow)
            {
                refreshToken.Revoked = true;
                await _refreshRepository.Update(refreshToken);
                return Unauthorized("Refresh token expirado. Inicia sesión con correo y contraseña.");
            }


            // Token válido → login rápido
            user = await _authRepository.LoginUserById(login.IdUsuario);

            if (user == null)
                return NotFound("Usuario no encontrado.");

            var jwt = _jwtService.GenerateToken(user);

            // Renovar expiración del token
            refreshToken.FechaExpiracion = DateTime.UtcNow.AddDays(7);
            await _refreshRepository.Update(refreshToken);

            return Ok(new AuthResponseDTO
            {
                IdUsuario = user.IdUsuario,
                JwtToken = jwt,
                RefreshToken = refreshToken.Token.ToString()
            });
        }

        // -----------------------------------------
        // 1. Login normal con correo y contraseña
        // -----------------------------------------
        if (string.IsNullOrWhiteSpace(login.Correo) || string.IsNullOrWhiteSpace(login.Contraseña))
            return BadRequest("Correo y contraseña son requeridos.");

        user = await _authRepository.LoginUser(login.Correo, login.Contraseña);
        if (user == null)
            return Unauthorized("Usuario o contraseña incorrectos.");

        // -----------------------------------------
        // 2. Manejo del refresh token
        // -----------------------------------------
        var existingToken = await _refreshRepository.GetActiveTokenByUser(user.IdUsuario);

        if (existingToken != null && (existingToken.FechaExpiracion < DateTime.UtcNow || existingToken.Revoked))
        {
            existingToken.Revoked = true;
            await _refreshRepository.Update(existingToken);
            existingToken = null;
        }

        if (existingToken == null)
        {
            refreshToUse = new RefreshToken
            {
                IdUsuario = user.IdUsuario,
                Token = Guid.NewGuid(),
                FechaCreacion = DateTime.UtcNow,
                FechaExpiracion = DateTime.UtcNow.AddDays(7),
                Revoked = false
            };
            await _refreshRepository.Create(refreshToUse);
        }
        else
        {
            existingToken.FechaExpiracion = DateTime.UtcNow.AddDays(7);
            await _refreshRepository.Update(existingToken);
            refreshToUse = existingToken;
        }

        // -----------------------------------------
        // 3. Generar JWT
        // -----------------------------------------
        var jwtNormal = _jwtService.GenerateToken(user);

        return Ok(new AuthResponseDTO
        {
            IdUsuario = user.IdUsuario,
            JwtToken = jwtNormal,
            RefreshToken = refreshToUse.Token.ToString()
        });
    }





    // ============================================================
    // REGISTRO
    // ============================================================
    [AllowAnonymous]
    [HttpPost("register")]
    public async Task<ActionResult<AuthResponseDTO>> Register([FromBody] UsuariosCreateDTO usuario)
    {
        var registeredUser = await _authRepository.RegisterUser(usuario);

        if (registeredUser == null)
            return BadRequest("El correo ya está siendo utilizado.");

        // Crear ambos tokens
        var jwt = _jwtService.GenerateToken(registeredUser);

        var refresh = new RefreshToken
        {
            IdUsuario = registeredUser.IdUsuario,
            Token = Guid.NewGuid(),
            FechaCreacion = DateTime.UtcNow,
            FechaExpiracion = DateTime.UtcNow.AddDays(7),
            Revoked = false
        };

        await _refreshRepository.Create(refresh);

        return Ok(new AuthResponseDTO
        {
            IdUsuario = registeredUser.IdUsuario,
            JwtToken = jwt,
            RefreshToken = refresh.Token.ToString()
        });
    }
}

