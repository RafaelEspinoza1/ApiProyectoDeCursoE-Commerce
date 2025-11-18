using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.DTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Guards;
using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ApiProyectoDeCursoE_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // Repositorio de autenticación
        private readonly AuthRepository _authRepository;

        // Servicios JWT
        private readonly JwtService _jwtService;
        private readonly JwtSettings _jwtSettings;

        // Constructor
        public AuthController(
            AuthRepository authRepository,
            JwtService jwtService,
            JwtSettings jwtSettings)
        {
            _authRepository = authRepository;
            _jwtService = jwtService;
            _jwtSettings = jwtSettings;
        }

        // POST: api/Auth/login
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] LoginDTO login)
        {
            // Validar usuario
            var usuario = await _authRepository.LoginUser(login.Correo, login.Contraseña, login.Rol);

            if (usuario == null)
            {
                return Unauthorized("Acceso no autorizado: Usuario o contraseña inválidos");
            }

            // Validar token recibido
            if (!string.IsNullOrWhiteSpace(login.Token))
            {
                var handler = new JwtSecurityTokenHandler();
                try
                {
                    handler.ValidateToken(login.Token, new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = _jwtSettings.issuer,
                        ValidAudience = _jwtSettings.audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.key))
                    }, out _);

                    return Ok(login.Token);
                }
                catch { }
            }

            // Generar un nuevo token JWT
            var nuevoToken = _jwtService.GenerateToken(usuario);
            return Ok(nuevoToken);
        }

        // POST: api/Auth/register
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(UsuariosCreateDTO usuario)
        {
            // Registrar usuario validando que no exista ya en la base de datos
            var usuarioRegistrado = await _authRepository.RegisterUser(usuario);

            if (usuarioRegistrado == null)
            {
                return BadRequest("Error al registrar el usuario.");
            }

            // Generar token JWT
            var token = _jwtService.GenerateToken(usuarioRegistrado);
            return Ok(token);
        }

    }
}
