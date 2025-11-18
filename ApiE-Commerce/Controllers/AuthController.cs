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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador }
        })]
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(string correo, string contraseña, string? token)
        {
            // Validar usuario
            var usuario = await _usuariosRepository.LoginUser(correo, contraseña);

            // Verificar si el usuario es válido
            if (usuario == null)
            {
                return Unauthorized("Acceso no autorizado: Usuario o contraseña inválidos");
            }

            // Validar el token recibido
            if (!string.IsNullOrWhiteSpace(token))
            {
                // Crear el manejador de tokens JWT
                var handler = new JwtSecurityTokenHandler();

                try
                {
                    // Validar el token
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
        [HttpPost("register")]
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador }
        })]
        public async Task<ActionResult<string>> Register(UsuariosCreateDTO usuario)
        {
            // Registrar el usuario validando que el correo no exista ya en la base de datos
            var usuarioRegistrado = await _usuariosRepository.RegisterUser(usuario);

            // Verificar si el registro fue exitoso
            if (usuarioRegistrado == null)
            {
                return BadRequest("Error al registrar el usuario.");
            }

            // Crear la cuenta según el rol
            var rol = (RolesEnum)usuario.IdRol;

            switch (rol)
            {
                // Crear cuenta de comprador
                case RolesEnum.Comprador:
                    await _compradoresRepository.Create(usuario);
                    break;
                // Crear cuenta de vendedor
                case RolesEnum.Vendedor:
                    await _vendedoresRepository.Create(usuario);
                    break;
                // Crear cuenta de administrador
                case RolesEnum.Administrador:
                    await _administradoresRepository.Create(usuario);
                    break;
                default:
                    return BadRequest("No existe el rol específicado.");
            }

            // Generar el token JWT
            // GUARDAR EN TIEMPO DE APP
            var token = _jwtService.GenerateToken(usuarioRegistrado!);
            return Ok(token);
        }
    }
}
