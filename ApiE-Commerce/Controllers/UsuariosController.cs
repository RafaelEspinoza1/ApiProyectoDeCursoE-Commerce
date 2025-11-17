using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Guards;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace APIProyectoDeCursoE_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosRepository _usuariosRepository;
        private readonly JwtService _jwtService;
        private readonly JwtSettings _jwtSettings;

        public UsuariosController(
            UsuariosRepository usuariosRepository,
            JwtService jwtService,
            JwtSettings jwtSettings)
        {
            _usuariosRepository = usuariosRepository;
            _jwtService = jwtService;
            _jwtSettings = jwtSettings;
        }

        // GET: api/Usuarios
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuariosReadDTO>>> GetUsuarios()
        {
            // Obtener todos los usuarios
            try
            {
                // Llamar al repositorio para obtener los usuarios
                var usuario = await _usuariosRepository.GetAll();
                if (usuario == null) return NotFound();
                return Ok(usuario);
            }
            catch
            {
                return StatusCode(500, "Error interno en el servidor.");
            }
        }

        // GET: api/Usuarios/5
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador }
        })]
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosById(int id)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetById(id);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/primerNombre
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet("primerNombre")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByFirstName(string primerNombre)
        {
            var usuarios = await _usuariosRepository.GetByFirstName(primerNombre);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/segundoNombre
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet("segundoNombre")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosBySecondName(string segundoNombre)
        {
            var usuarios = await _usuariosRepository.GetBySecondName(segundoNombre);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/primerApellido
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet("primerApellido")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByFirstSurname(string firstSurname)
        {
            var usuarios = await _usuariosRepository.GetByFirstSurname(firstSurname);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/segundoApellido
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet("segundoApellido")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosBySecondSurname(string secondSurname)
        {
            var usuarios = await _usuariosRepository.GetBySecondSurname(secondSurname);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/telefono
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet("telefono")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByTelephone(string telephone)
        {
            var usuarios = await _usuariosRepository.GetByTelephone(telephone);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/correo
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet("correo")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByCorreo(string correo)
        {
            var usuarios = await _usuariosRepository.GetByEmail(correo);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // PUT: api/Usuarios/5
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador }
        })]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarios(UsuariosUpdateDTO dto, int id)
        {
            // Verificar si el usuario existe
            var usuario = await _usuariosRepository.GetById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            // Validar que el correo no exista en otro usuario
            var usuarioConCorreo = await _usuariosRepository.GetByEmail(usuario.Correo);

            if (usuarioConCorreo != null)
            {
                return BadRequest("El correo ya está registrado por otro usuario.");
            }

            // Actualizar los datos del usuario
            try
            {
                var filasAfectadas = await _usuariosRepository.Update(dto, id);
            }
            catch
            {
                return StatusCode(500, "Error interno en el servidor.");
            }

            return NoContent();
        }

        // POST: api/Usuarios/login
        [AllowAnonymous]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador }
        })]
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(int id, string contraseña, string? token)
        {
            // Validar usuario
            var usuario = await _usuariosRepository.LoginUser(id, contraseña);

            if (usuario == null)
            {
                return Unauthorized("Acceso no autorizado: Usuario o contraseña inválidos");
            }

            // Validar el token recibido
            if (!string.IsNullOrWhiteSpace(token))
            {
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
                catch {}
            }

            // Generar un nuevo token JWT
            var nuevoToken = _jwtService.GenerateToken(usuario);

            return Ok(nuevoToken);
        }

        // POST: api/Usuarios/register
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

            // Generar el token JWT
            var token = _jwtService.GenerateToken(usuarioRegistrado!);
            return Ok(token);
        }

        // DELETE api/Usuarios/5
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador }
        })]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarios(int id)
        {
            try
            {
                int filasAfectadas = await _usuariosRepository.Delete(id);

                return NoContent();
            }
            catch
            {
                return StatusCode(500, "Error interno al intentar eliminar el usuario.");
            }
        }
    }
}