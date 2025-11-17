using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Guards;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Repositories;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APIProyectoDeCursoE_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosRepository _usuariosRepository;
        private readonly JwtService _jwtService;

        public UsuariosController(UsuariosRepository usuariosRepository, JwtService jwtService)
        {
            _usuariosRepository = usuariosRepository;
            _jwtService = jwtService;
        }

        // GET: api/Usuarios
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
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
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
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
                Nombre = $"{usuarios.PrimerNombre} + {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} + {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/primerNombre
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
        [HttpGet("primerNombre")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByFirstName(string primerNombre)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetByFirstName(primerNombre);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} + {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} + {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/segundoNombre
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
        [HttpGet("segundoNombre")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosBySecondName(string segundoNombre)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetByFirstName(segundoNombre);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} + {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} + {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/primerApellido
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
        [HttpGet("primerApellido")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByFirstSurname(string firstSurname)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetByFirstName(firstSurname);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} + {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} + {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/segundoApellido
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
        [HttpGet("segundoApellido")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosBySecondSurname(string secondSurname)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetBySecondName(secondSurname);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} + {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} + {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/primerApellido
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
        [HttpGet("telefono")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByTelephone(string telephone)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetByTelephone(telephone);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} + {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} + {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // GET: api/Usuarios/primerApellido
        [AuthGuard(
            allowedRoles: new RolesEnum[] { RolesEnum.Administrador }
        )]
        [Authorize]
        [HttpGet("correo")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuariosByCorreo(string correo)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetByEmail(correo);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.IdUsuario,
                Nombre = $"{usuarios.PrimerNombre} + {usuarios.SegundoNombre}",
                Apellido = $"{usuarios.PrimerApellido} + {usuarios.SegundoApellido}",
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
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
        [HttpPost("login")]
        [AllowAnonymous]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[]
        {
            "X-Auth-Buyers"
        })]
        public async Task<ActionResult<string>> Login(int id, string contraseña)
        {
            // Validar las credenciales del usuario
            var usuario = await _usuariosRepository.LoginUser(id, contraseña);

            // Verificar si el usuario es válido
            if (usuario == null)
            {
                return Unauthorized("Acceso no autorizado: Usuario o contraseña inválidos");
            }

            // Generar el token JWT para el usuario autenticado
            var token = _jwtService.GenerateToken(usuario!);
            return Ok(token);
        }

        // POST: api/Usuarios/register
        [HttpPost("register")]
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[]
        {
            "X-Auth-Buyers"
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

            // Generar el token JWT para el usuario registrado
            var token = _jwtService.GenerateToken(usuarioRegistrado!);
            return Ok(token);
        }

        // DELETE api/Usuarios/5
        [HttpDelete("{id}")]
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[]
        {
            "X-Auth-Buyers"
        })]
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
