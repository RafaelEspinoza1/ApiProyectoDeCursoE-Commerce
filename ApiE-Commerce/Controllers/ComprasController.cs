using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.ComprasDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
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
    public class ComprasController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public ComprasController(ECommerceContext context)
        {
            _context = context;
        }

        //// GET: api/Compras
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ComprasReadDTO>>> GetCompras()
        //{
        //    return await _context.Compras
        //    .Include(c => c.Usuario)
        //    .Include(c => c.Vendedor).ThenInclude(v => v.Usuario)
        //    .Include(c => c.Producto)
        //    .Select(c => new ComprasReadDTO
        //    {
        //        CompraId = c.CompraId,
        //        CuentaUsuario = c.CuentaUsuario,
        //        Precio = c.Precio,
        //        Cantidad = c.Cantidad,
        //        Envio = c.Envio,
        //        PrecioTotal = c.PrecioTotal,
        //        Fecha = c.Fecha,

        //        LatitudOrigen = c.LatitudOrigen,
        //        LongitudOrigen = c.LongitudOrigen,
        //        NombreDireccionOrigen = c.NombreDireccionOrigen,
        //        LatitudDestino = c.LatitudDestino,
        //        LongitudDestino = c.LongitudDestino,
        //        NombreDireccionDestino = c.NombreDireccionDestino,

        //        UsuarioId = c.UsuarioId,
        //        UsuarioNombre = c.Usuario.Nombre,
        //        UsuarioApellido = c.Usuario.Apellido,

        //        VendedorId = c.VendedorId,
        //        VendedorNombre = c.Vendedor.Usuario.Nombre,
        //        VendedorApellido = c.Vendedor.Usuario.Apellido,

        //        ProductoId = c.ProductoId,
        //        ProductoNombre = c.Producto.NombreProducto
        //    })
        //    .ToListAsync();
        //}

        //// GET: api/Compras/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<ComprasReadDTO>> GetCompras(int id)
        //{
        //    var compra = await _context.Compras
        //    .Include(c => c.Usuario)
        //    .Include(c => c.Vendedor).ThenInclude(v => v.Usuario)
        //    .Include(c => c.Producto)
        //    .Where(c => c.CompraId == id)
        //    .Select(c => new ComprasReadDTO
        //    {
        //        CompraId = c.CompraId,
        //        CuentaUsuario = c.CuentaUsuario,
        //        Precio = c.Precio,
        //        Cantidad = c.Cantidad,
        //        Envio = c.Envio,
        //        PrecioTotal = c.PrecioTotal,
        //        Fecha = c.Fecha,

        //        LatitudOrigen = c.LatitudOrigen,
        //        LongitudOrigen = c.LongitudOrigen,
        //        NombreDireccionOrigen = c.NombreDireccionOrigen,
        //        LatitudDestino = c.LatitudDestino,
        //        LongitudDestino = c.LongitudDestino,
        //        NombreDireccionDestino = c.NombreDireccionDestino,

        //        UsuarioId = c.UsuarioId,
        //        UsuarioNombre = c.Usuario.Nombre,
        //        UsuarioApellido = c.Usuario.Apellido,

        //        VendedorId = c.VendedorId,
        //        VendedorNombre = c.Vendedor.Usuario.Nombre,
        //        VendedorApellido = c.Vendedor.Usuario.Apellido,

        //        ProductoId = c.ProductoId,
        //        ProductoNombre = c.Producto.NombreProducto
        //    })
        //    .FirstOrDefaultAsync();

        //    if (compra == null)
        //    {
        //        return NotFound();
        //    }

        //    return compra;
        //}

        //// PUT: api/Compras/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCompras(int id, ComprasUpdateDTO dto)
        //{
        //    if (!Regex.IsMatch(dto.CuentaUsuario, @"^\d{16}$"))
        //    {
        //        return BadRequest("El número de cuenta debe tener exactamente 16 dígitos numéricos.");
        //    }
        //    string cuentaFormateada = FormatearCuenta(dto.CuentaUsuario);

        //    var compra = await _context.Compras.FindAsync(id);
        //    if (compra == null)
        //    {
        //        return NotFound();
        //    }

        //    compra.CuentaUsuario = cuentaFormateada;
        //    compra.Cantidad = dto.Cantidad;
        //    compra.Envio = dto.Envio;
        //    compra.PrecioTotal = (compra.Precio * dto.Cantidad) + dto.Envio;

        //    compra.LatitudDestino = dto.LatitudDestino;
        //    compra.LongitudDestino = dto.LongitudDestino;
        //    compra.NombreDireccionDestino = dto.NombreDireccionDestino;

        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //// POST: api/Compras
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<ComprasReadDTO>> PostCompras(ComprasCreateDTO dto)
        //{
        //    if (!Regex.IsMatch(dto.CuentaUsuario, @"^\d{16}$"))
        //    {
        //        return BadRequest("El número de cuenta debe tener exactamente 16 dígitos numéricos.");
        //    }
        //    string cuentaFormateada = FormatearCuenta(dto.CuentaUsuario);

        //    var producto = await _context.Productos.FindAsync(dto.ProductoId);
        //    if (producto == null)
        //    {
        //        return BadRequest("Producto no encontrado.");
        //    }
        //    var vendedor = await _context.Vendedores.FindAsync(dto.VendedorId);
        //    if (vendedor == null)
        //    {
        //        return BadRequest("Vendedor no encontrado.");
        //    }
        //    var usuario = await _context.Usuarios.FindAsync(dto.UsuarioId);
        //    if (usuario == null)
        //    {
        //        return BadRequest("Producto no encontrado.");
        //    }

        //    var compra = new Transaccion
        //    {
        //        CuentaUsuario = cuentaFormateada,
        //        Cantidad = dto.Cantidad,
        //        Envio = dto.Envio,
        //        Precio = producto.Precio,
        //        PrecioTotal = (producto.Precio * dto.Cantidad) + dto.Envio,
        //        Fecha = DateTime.Now,

        //        LatitudOrigen = vendedor.LatitudOrigen,
        //        LongitudOrigen = vendedor.LongitudOrigen,
        //        NombreDireccionOrigen = vendedor.DireccionOrigen,
        //        LatitudDestino = dto.LatitudDestino,
        //        LongitudDestino = dto.LongitudDestino,
        //        NombreDireccionDestino = dto.NombreDireccionDestino,

        //        UsuarioId = dto.UsuarioId,
        //        VendedorId = dto.VendedorId,
        //        ProductoId = dto.ProductoId
        //    };

        //    _context.Compras.Add(compra);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetCompras), new { id = compra.CompraId }, new ComprasReadDTO
        //    {
        //        CompraId = compra.CompraId,
        //        CuentaUsuario = compra.CuentaUsuario,
        //        Precio = compra.Precio,
        //        Cantidad = compra.Cantidad,
        //        Envio = compra.Envio,
        //        PrecioTotal = compra.PrecioTotal,
        //        Fecha = compra.Fecha,

        //        LatitudOrigen = compra.LatitudOrigen,
        //        LongitudOrigen = compra.LongitudOrigen,
        //        NombreDireccionOrigen = compra.NombreDireccionOrigen,
        //        LatitudDestino = compra.LatitudDestino,
        //        LongitudDestino = compra.LongitudDestino,
        //        NombreDireccionDestino = compra.NombreDireccionDestino,

        //        UsuarioId = dto.UsuarioId,
        //        UsuarioNombre = (await _context.Usuarios.FindAsync(dto.UsuarioId))?.Nombre,
        //        UsuarioApellido = (await _context.Usuarios.FindAsync(dto.UsuarioId))?.Apellido,
        //        VendedorId = dto.VendedorId,
        //        VendedorNombre = (await _context.Vendedores.Include(v => v.Usuario).FirstOrDefaultAsync(v => v.VendedorId == dto.VendedorId))?.Usuario.Nombre,
        //        VendedorApellido = (await _context.Vendedores.Include(v => v.Usuario).FirstOrDefaultAsync(v => v.VendedorId == dto.VendedorId))?.Usuario.Apellido,
        //        ProductoId = dto.ProductoId,
        //        ProductoNombre = producto.NombreProducto
        //    });
        //}

        //// DELETE: api/Compras/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCompras(int id)
        //{
        //    var compras = await _context.Compras.FindAsync(id);
        //    if (compras == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Compras.Remove(compras);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ComprasExists(int id)
        //{
        //    return _context.Compras.Any(e => e.CompraId == id);
        //}
        //private string FormatearCuenta(string numero)
        //{
        //    return $"{numero.Substring(0, 4)}-{numero.Substring(4, 4)}-{numero.Substring(8, 4)}-{numero.Substring(12, 4)}";
        //}
    }
}
