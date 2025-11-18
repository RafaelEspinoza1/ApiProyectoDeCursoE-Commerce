using ApiProyectoDeCursoE_Commerce.Configuration;
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
        // Repositorios
        private readonly UsuariosRepository _usuariosRepository;
        private readonly VendedoresRepository _vendedoresRepository;
        private readonly CompradoresRepository _compradoresRepository;
        private readonly AdministradoresRepository _administradoresRepository;

        // Servicios JWT
        private readonly JwtService _jwtService;
        private readonly JwtSettings _jwtSettings;

        // Constructor
        public AuthController(
            UsuariosRepository usuariosRepository,
            VendedoresRepository vendedoresRepository,
            CompradoresRepository compradoresRepository,
            AdministradoresRepository administradoresRepository,
            JwtService jwtService,
            JwtSettings jwtSettings)
        {
            _usuariosRepository = usuariosRepository;
            _vendedoresRepository = vendedoresRepository;
            _compradoresRepository = compradoresRepository;
            _administradoresRepository = administradoresRepository;
            _jwtService = jwtService;
            _jwtSettings = jwtSettings;
        }

        // POST: api/Auth/login
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(string correo, string contraseña, string? token)
        {
            // Validar usuario
            var usuario = await _usuariosRepository.LoginUser(correo, contraseña);

            if (usuario == null)
            {
                return Unauthorized("Acceso no autorizado: Usuario o contraseña inválidos");
            }

            // Validar token recibido
            if (!string.IsNullOrWhiteSpace(token))
            {
                var handler = new JwtSecurityTokenHandler();
                try
                {
                    handler.ValidateToken(token, new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = _jwtSettings.issuer,
                        ValidAudience = _jwtSettings.audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.key))
                    }, out _);

                    return Ok(token);
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
            var usuarioRegistrado = await _usuariosRepository.RegisterUser(usuario);

            if (usuarioRegistrado == null)
            {
                return BadRequest("Error al registrar el usuario.");
            }

            var rol = (RolesEnum)usuario.IdRol;

            switch (rol)
            {
                case RolesEnum.Comprador:
                    // Usar el IdUsuario creado
                    await _compradoresRepository.Create(usuarioRegistrado.IdUsuario);
                    break;
                case RolesEnum.Vendedor:
                    await _vendedoresRepository.Create(usuario, usuarioRegistrado.IdUsuario);
                    break;
                case RolesEnum.Administrador:
                    await _administradoresRepository.Create(usuarioRegistrado.IdUsuario);
                    break;
                default:
                    return BadRequest("No existe el rol específicado.");
            }

            // Generar token JWT
            var token = _jwtService.GenerateToken(usuarioRegistrado);
            return Ok(token);
        }

    }
}
