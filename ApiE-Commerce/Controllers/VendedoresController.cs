using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedoresDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APIProyectoDeCursoE_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public VendedoresController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: api/Vendedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendedoresReadDTO>>> GetVendedores()
        {
            return await _context.Vendedores
                .Include(v => v.Usuario)
                .Select(v => new VendedoresReadDTO
                {
                    VendedorId = v.VendedorId,
                    NumeroDeCuenta = v.NumeroDeCuenta,
                    Ingresos = v.Ingresos,
                    DireccionOrigen = v.DireccionOrigen,
                    LatitudOrigen = v.LatitudOrigen,
                    LongitudOrigen = v.LongitudOrigen,
                    UsuarioId = v.UsuarioId,
                    UsuarioNombre = v.Usuario.Nombre,
                    UsuarioApellido = v.Usuario.Apellido,
                    UsuarioCorreo = v.Usuario.Correo
                })
                .ToListAsync();
        }

        // GET: api/Vendedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VendedoresReadDTO>> GetVendedores(int id)
        {
            var vendedor = await _context.Vendedores
                .Include(v => v.Usuario)
                .Where(v => v.VendedorId == id)
                .Select(v => new VendedoresReadDTO
                {
                    VendedorId = v.VendedorId,
                    NumeroDeCuenta = v.NumeroDeCuenta,
                    Ingresos = v.Ingresos,
                    DireccionOrigen = v.DireccionOrigen,
                    LatitudOrigen = v.LatitudOrigen,
                    LongitudOrigen = v.LongitudOrigen,
                    UsuarioId = v.UsuarioId,
                    UsuarioNombre = v.Usuario.Nombre,
                    UsuarioApellido = v.Usuario.Apellido,
                    UsuarioCorreo = v.Usuario.Correo
                })
                .FirstOrDefaultAsync();

            if (vendedor == null)
            {
                return NotFound();
            }

            return vendedor;
        }

        // PUT: api/Vendedores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendedores(int id, VendedoresUpdateDTO dto)
        {
            if (!Regex.IsMatch(dto.NumeroDeCuenta, @"^\d{16}$"))
            {
                return BadRequest("El número de cuenta debe tener exactamente 16 dígitos numéricos.");
            }
            var vendedor = await _context.Vendedores.FindAsync(id);
            if (vendedor == null)
            {
                return NotFound();
            }
            string cuentaFormateada = FormatearCuenta(dto.NumeroDeCuenta);

            bool cuentaExiste = await _context.Vendedores
                .AnyAsync(v => v.NumeroDeCuenta == cuentaFormateada && v.VendedorId != id);

            if (cuentaExiste)
            {
                return BadRequest("Ya existe un vendedor con ese número de cuenta.");
            }


            vendedor.NumeroDeCuenta = cuentaFormateada;
            vendedor.DireccionOrigen = dto.DireccionOrigen;
            vendedor.LatitudOrigen = dto.LatitudOrigen;
            vendedor.LongitudOrigen = dto.LongitudOrigen;


            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Vendedores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VendedoresReadDTO>> PostVendedores(VendedoresCreateDTO dto)
        {
            if (!Regex.IsMatch(dto.NumeroDeCuenta, @"^\d{16}$"))
            {
                return BadRequest("El número de cuenta debe tener exactamente 16 dígitos numéricos.");
            }
            string cuentaFormateada = FormatearCuenta(dto.NumeroDeCuenta);
            var usuario = await _context.Usuarios.FindAsync(dto.UsuarioId);
            if (usuario == null)
            {
                return BadRequest("El usuario asociado no existe.");
            }
            // Verificar si el usuario ya es vendedor
            var vendedorExistente = await _context.Vendedores
                .AnyAsync(v => v.UsuarioId == dto.UsuarioId);

            if (vendedorExistente)
            {
                return BadRequest("Este usuario ya está registrado como vendedor. Si desea volver a registrarse, primero elimine su cuenta de vendedor actual.");
            }
            bool cuentaExiste = await _context.Vendedores
                .AnyAsync(v => v.NumeroDeCuenta == cuentaFormateada);

            if (cuentaExiste)
            {
                return BadRequest("Ya existe un vendedor con ese número de cuenta.");
            }
            var nuevoVendedor = new Vendedores
            {
                NumeroDeCuenta = cuentaFormateada,
                DireccionOrigen = dto.DireccionOrigen,
                LatitudOrigen = dto.LatitudOrigen,
                LongitudOrigen = dto.LongitudOrigen,
                UsuarioId = dto.UsuarioId
            };




            _context.Vendedores.Add(nuevoVendedor);
            await _context.SaveChangesAsync();

            // Opcional: devolver el DTO completo o solo lo necesario
            return CreatedAtAction(nameof(GetVendedores), new { id = nuevoVendedor.VendedorId }, new VendedoresReadDTO
            {
                VendedorId = nuevoVendedor.VendedorId,
                NumeroDeCuenta = nuevoVendedor.NumeroDeCuenta,
                Ingresos = nuevoVendedor.Ingresos,
                DireccionOrigen = nuevoVendedor.DireccionOrigen,
                LatitudOrigen = nuevoVendedor.LatitudOrigen,
                LongitudOrigen = nuevoVendedor.LongitudOrigen,
                UsuarioId = nuevoVendedor.UsuarioId,
                UsuarioNombre = usuario.Nombre,
                UsuarioApellido = usuario.Apellido,
                UsuarioCorreo = usuario.Correo
            });
        }

        // DELETE: api/Vendedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendedores(int id)
        {
            var vendedores = await _context.Vendedores.FindAsync(id);
            if (vendedores == null)
            {
                return NotFound();
            }

            _context.Vendedores.Remove(vendedores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendedoresExists(int id)
        {
            return _context.Vendedores.Any(e => e.VendedorId == id);
        }
        private string FormatearCuenta(string numero)
        {
            return $"{numero.Substring(0, 4)}-{numero.Substring(4, 4)}-{numero.Substring(8, 4)}-{numero.Substring(12, 4)}";
        }
    }
}
