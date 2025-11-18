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
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
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
        public async Task<ActionResult<Usuario>> GetUsuariosById(int id)
        {
            // Obtener usuario por ID
            var usuarios = await _usuariosRepository.GetById(id);

            // Verificar si el usuario existe
            if (usuarios == null)
            {
                return NotFound();
            }

            // Mapear a DTO y retornar
            return new Usuario
            {
                IdUsuario = usuarios.IdUsuario,
                IdRol = usuarios.IdRol,
                PrimerNombre = usuarios.PrimerNombre,
                SegundoNombre = usuarios.SegundoNombre,
                PrimerApellido = usuarios.PrimerApellido,
                SegundoApellido = usuarios.SegundoApellido,
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
        public async Task<ActionResult<Usuario>> GetUsuariosByFirstName(string primerNombre)
        {
            var usuarios = await _usuariosRepository.GetByFirstName(primerNombre);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new Usuario
            {
                IdUsuario = usuarios.IdUsuario,
                IdRol = usuarios.IdRol,
                PrimerNombre = usuarios.PrimerNombre,
                SegundoNombre = usuarios.SegundoNombre,
                PrimerApellido = usuarios.PrimerApellido,
                SegundoApellido = usuarios.SegundoApellido,
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
        public async Task<ActionResult<Usuario>> GetUsuariosBySecondName(string segundoNombre)
        {
            var usuarios = await _usuariosRepository.GetBySecondName(segundoNombre);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new Usuario
            {
                IdUsuario = usuarios.IdUsuario,
                IdRol = usuarios.IdRol,
                PrimerNombre = usuarios.PrimerNombre,
                SegundoNombre = usuarios.SegundoNombre,
                PrimerApellido = usuarios.PrimerApellido,
                SegundoApellido = usuarios.SegundoApellido,
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
        public async Task<ActionResult<Usuario>> GetUsuariosByFirstSurname(string firstSurname)
        {
            var usuarios = await _usuariosRepository.GetByFirstSurname(firstSurname);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new Usuario
            {
                IdUsuario = usuarios.IdUsuario,
                IdRol = usuarios.IdRol,
                PrimerNombre = usuarios.PrimerNombre,
                SegundoNombre = usuarios.SegundoNombre,
                PrimerApellido = usuarios.PrimerApellido,
                SegundoApellido = usuarios.SegundoApellido,
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
        public async Task<ActionResult<Usuario>> GetUsuariosBySecondSurname(string secondSurname)
        {
            var usuarios = await _usuariosRepository.GetBySecondSurname(secondSurname);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new Usuario
            {
                IdUsuario = usuarios.IdUsuario,
                IdRol = usuarios.IdRol,
                PrimerNombre = usuarios.PrimerNombre,
                SegundoNombre = usuarios.SegundoNombre,
                PrimerApellido = usuarios.PrimerApellido,
                SegundoApellido = usuarios.SegundoApellido,
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
        public async Task<ActionResult<Usuario>> GetUsuariosByCorreo(string correo)
        {
            var usuarios = await _usuariosRepository.GetByEmail(correo);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new Usuario
            {
                IdUsuario = usuarios.IdUsuario,
                IdRol = usuarios.IdRol,
                PrimerNombre = usuarios.PrimerNombre,
                SegundoNombre = usuarios.SegundoNombre,
                PrimerApellido = usuarios.PrimerApellido,
                SegundoApellido = usuarios.SegundoApellido,
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
        public async Task<ActionResult<Usuario>> GetUsuariosByTelephone(string telephone)
        {
            var usuarios = await _usuariosRepository.GetByTelephone(telephone);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new Usuario
            {
                IdUsuario = usuarios.IdUsuario,
                IdRol = usuarios.IdRol,
                PrimerNombre = usuarios.PrimerNombre,
                SegundoNombre = usuarios.SegundoNombre,
                PrimerApellido = usuarios.PrimerApellido,
                SegundoApellido = usuarios.SegundoApellido,
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