using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIProyectoDeCursoE_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public UsuariosController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuariosReadDTO>>> GetUsuarios()
        {
            return await _context.Usuarios
            .Select(u => new UsuariosReadDTO
            {
                UsuarioId = u.UsuarioId,
                Nombre = u.Nombre,
                Apellido = u.Apellido,
                Correo = u.Correo,
                Contraseña = u.Contraseña,
                Telefono = u.Telefono
            }).ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuariosReadDTO>> GetUsuarios(int id)
        {
            var usuarios = await _context.Usuarios.FindAsync(id);

            if (usuarios == null)
            {
                return NotFound();
            }

            return new UsuariosReadDTO
            {
                UsuarioId = usuarios.UsuarioId,
                Nombre = usuarios.Nombre,
                Apellido = usuarios.Apellido,
                Correo = usuarios.Correo,
                Contraseña = usuarios.Contraseña,
                Telefono = usuarios.Telefono
            };
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarios(int id, UsuariosUpdateDTO dto)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            // Validar que el correo no exista en otro usuario
            bool correoExistente = await _context.Usuarios.AnyAsync(u => u.Correo == dto.Correo && u.UsuarioId != id);
            if (correoExistente)
            {
                return BadRequest("El correo ya está registrado por otro usuario.");
            }

            usuario.Nombre = dto.Nombre;
            usuario.Apellido = dto.Apellido;
            usuario.Correo = dto.Correo;
            usuario.Contraseña = dto.Contraseña;
            var telefono = string.IsNullOrWhiteSpace(dto.Telefono) ? "00000000" : dto.Telefono;
            usuario.Telefono = $"{dto.Telefono.Substring(0, 4)}-{dto.Telefono.Substring(4, 4)}";

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuariosCreateDTO>> PostUsuarios(UsuariosCreateDTO dto)
        {
            // Validar que el correo no exista ya en la base de datos
            bool correoExistente = await _context.Usuarios.AnyAsync(u => u.Correo == dto.Correo);
            if (correoExistente)
            {
                return BadRequest("El correo ya está registrado.");
            }
            var telefono = string.IsNullOrWhiteSpace(dto.Telefono) ? "00000000" : dto.Telefono;
            var nuevoUsuario = new Usuarios
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Correo = dto.Correo,
                Contraseña = dto.Contraseña,
                Telefono = $"{dto.Telefono.Substring(0, 4)}-{dto.Telefono.Substring(4, 4)}"
            };
            _context.Usuarios.Add(nuevoUsuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsuarios), new { id = nuevoUsuario.UsuarioId }, new UsuariosReadDTO
            {
                UsuarioId = nuevoUsuario.UsuarioId,
                Nombre = nuevoUsuario.Nombre,
                Apellido = nuevoUsuario.Apellido,
                Correo = nuevoUsuario.Correo,
                Telefono = nuevoUsuario.Telefono
            });
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarios(int id)
        {
            try
            {
                var usuario = await _context.Usuarios.FindAsync(id);
                if (usuario == null)
                {
                    return NotFound();
                }

                // Verificar si es vendedor
                var vendedor = await _context.Vendedores
                    .FirstOrDefaultAsync(v => v.UsuarioId == id);

                if (vendedor != null)
                {
                    // Buscar productos del vendedor
                    var productos = await _context.Productos
                        .Where(p => p.VendedorId == vendedor.VendedorId)
                        .ToListAsync();

                    // Obtener IDs de productos
                    var productosIds = productos.Select(p => p.ProductoId).ToList();

                    // Eliminar imágenes relacionadas a esos productos
                    var imagenes = await _context.ImagenesProducto
                        .Where(img => productosIds.Contains(img.ProductoId))
                        .ToListAsync();

                    _context.ImagenesProducto.RemoveRange(imagenes);

                    // Eliminar productos
                    _context.Productos.RemoveRange(productos);

                    // Eliminar vendedor
                    _context.Vendedores.Remove(vendedor);
                }

                // Eliminar usuario
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el usuario con ID {id}: {ex.Message}");
                return StatusCode(500, "Error interno al intentar eliminar el usuario.");
            }
        }

        private bool UsuariosExists(int id)
        {
            return _context.Usuarios.Any(e => e.UsuarioId == id);
        }
    }
}
