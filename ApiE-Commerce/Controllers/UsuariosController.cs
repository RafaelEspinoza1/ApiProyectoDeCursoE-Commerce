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
        [HttpGet]
        [Authorize]
        [AuthGuard([RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador], "X-Auth-Buyers")]
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
                Console.WriteLine("Error interno:");
                return StatusCode(500, "Error interno en el servidor.");
            }
            
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        [Authorize]
        [AuthGuard([RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador], "X-Auth-Buyers")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuarios(int id)
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

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        [AuthGuard([RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador], "X-Auth-Buyers")]
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

        [AuthGuard([RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador], "X-Auth-Buyers")]
        // POST: api/Usuarios/register
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<string>> Login(int id)
        {
            var usuario = await _usuariosRepository.GetById(id);

            // IMPLEMENTAR VERIFICACIÓN DE CONTRASEÑA

            //if (usuario == null || !VerifyPassword(usuario, loginDto.Password))
            //    return Unauthorized("Usuario o contraseña inválidos");

            var token = _jwtService.GenerateToken(usuario!);
            return Ok(token);
        }

        // POST: api/Usuarios/login
        [HttpPost("login")]
        [AllowAnonymous]
        [AuthGuard([RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador], "X-Auth-Buyers")]
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
        [AuthGuard([RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador], "X-Auth-Buyers")]
        [HttpPost("register")]
        [Authorize]
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
        [AuthGuard([RolesEnum.Comprador, RolesEnum.Vendedor, RolesEnum.Administrador], "X-Auth-Buyers")]
        [HttpDelete("{id}")]
        [Authorize]
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
