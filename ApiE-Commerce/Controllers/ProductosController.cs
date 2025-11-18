using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.ProductoDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
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
    public class ProductosController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public ProductosController(ECommerceContext context)
        {
            _context = context;
        }

        //// GET: api/Productos
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ProductoReadDTO>>> GetProductosConImagenes()
        //{
        //    var productos = await _context.Productos
        //        .Include(p => p.Imagenes)
        //        .Include(p => p.Vendedor)
        //            .ThenInclude(v => v.Usuario)
        //        .Select(p => new ProductoReadDTO
        //        {
        //            ProductoId = p.ProductoId,
        //            NombreProducto = p.NombreProducto,
        //            Descripcion = p.Descripcion,
        //            Precio = p.Precio,
        //            Cantidad = p.Cantidad,
        //            Tipo = p.Tipo,
        //            Estado = p.Estado,
        //            VendedorId = p.VendedorId,
        //            VendedorNombre = p.Vendedor.Usuario.Nombre,
        //            VendedorApellido = p.Vendedor.Usuario.Apellido,
        //            Imagenes = p.Imagenes.Select(i => i.ImagenUrl).ToList()
        //        }).ToListAsync();


        //    return productos;
        //}

        //// GET: api/Productos/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<ProductoReadDTO>> GetProductos(int id)
        //{
        //    var producto = await _context.Productos
        //        .Include(p => p.Imagenes)
        //        .Include(p => p.Vendedor)
        //            .ThenInclude(v => v.Usuario)
        //        .Where(p => p.ProductoId == id)
        //        .Select(p => new ProductoReadDTO
        //        {
        //            ProductoId = p.ProductoId,
        //            NombreProducto = p.NombreProducto,
        //            Descripcion = p.Descripcion,
        //            Precio = p.Precio,
        //            Cantidad = p.Cantidad,
        //            Tipo = p.Tipo,
        //            Estado = p.Estado,
        //            VendedorId = p.VendedorId,
        //            VendedorNombre = p.Vendedor.Usuario.Nombre,
        //            VendedorApellido = p.Vendedor.Usuario.Apellido,
        //            Imagenes = p.Imagenes.Select(i => i.ImagenUrl).ToList()
        //        }).FirstOrDefaultAsync();

        //    if (producto == null)
        //    {
        //        return NotFound();
        //    }

        //    return producto;
        //}

        //// PUT: api/Productos/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProductos(int id, ProductoUpdateDTO dto)
        //{
        //    var producto = await _context.Productos.FindAsync(id);
        //    if (producto == null)
        //    {
        //        return NotFound();
        //    }
            
        //    if (!EstadosPermitidos.Contains(dto.Estado))
        //    {
        //        return BadRequest("Estado de producto no válido. Solo se permiten: Nuevo, Como nuevo, Buen estado, Aceptable.");
        //    }

        //    producto.NombreProducto = dto.NombreProducto;
        //    producto.Descripcion = dto.Descripcion;
        //    producto.Precio = dto.Precio;
        //    producto.Cantidad = dto.Cantidad;
        //    producto.Tipo = dto.Tipo;
        //    producto.Estado = dto.Estado;

        //    await _context.SaveChangesAsync();
            
        //    return NoContent();
        //}

        //// POST: api/Productos
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Producto>> PostProductos(ProductoCreateDTO dto)
        //{
        //    var nuevoProducto = new Producto
        //    {
        //        NombreProducto = dto.NombreProducto,
        //        Descripcion = dto.Descripcion,
        //        Precio = dto.Precio,
        //        Cantidad = dto.Cantidad,
        //        Tipo = dto.Tipo,
        //        Estado = dto.Estado,
        //        VendedorId = dto.VendedorId
        //    };
        //    if (!EstadosPermitidos.Contains(dto.Estado))
        //    {
        //        return BadRequest("Estado de producto no válido. Solo se permiten: Nuevo, Como nuevo, Buen estado, Aceptable.");
        //    }
        //    var vendedorExiste = await _context.Vendedores.AnyAsync(v => v.VendedorId == dto.VendedorId);
        //    if (!vendedorExiste)
        //    {
        //        return BadRequest("El ID del vendedor no existe.");
        //    }
        //    _context.Productos.Add(nuevoProducto);
        //    await _context.SaveChangesAsync();

        //    var vendedorUsuario = await _context.Vendedores
        //                        .Include(v => v.Usuario)
        //                        .Where(v => v.VendedorId == nuevoProducto.VendedorId)
        //                        .Select(v => new { v.Usuario.Nombre, v.Usuario.Apellido })
        //                        .FirstOrDefaultAsync();

        //    return CreatedAtAction(nameof(GetProductos), new { id = nuevoProducto.ProductoId }, new ProductoReadDTO
        //    {
        //        ProductoId = nuevoProducto.ProductoId,
        //        NombreProducto = nuevoProducto.NombreProducto,
        //        Descripcion = nuevoProducto.Descripcion,
        //        Precio = nuevoProducto.Precio,
        //        Cantidad = nuevoProducto.Cantidad,
        //        Tipo = nuevoProducto.Tipo,
        //        Estado = nuevoProducto.Estado,
        //        VendedorId = nuevoProducto.VendedorId,
        //        VendedorNombre = vendedorUsuario?.Nombre,
        //        VendedorApellido = vendedorUsuario?.Apellido,
        //        Imagenes = new List<string>()
        //    });

        //}

        //// DELETE: api/Productos/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProductos(int id)
        //{
        //    try
        //    {
        //        var producto = await _context.Productos
        //     .Include(p => p.Imagenes)
        //     .FirstOrDefaultAsync(p => p.ProductoId == id);

        //        if (producto == null)
        //        {
        //            return NotFound();
        //        }

        //        // Eliminar imágenes relacionadas al producto
        //        if (producto.Imagenes != null && producto.Imagenes.Any())
        //        {
        //            _context.ImagenesProducto.RemoveRange(producto.Imagenes);
        //        }

        //        // Eliminar el producto
        //        _context.Productos.Remove(producto);
        //        await _context.SaveChangesAsync();

        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error al eliminar el producto con ID {id}: {ex.Message}");
        //        return StatusCode(500, "Error interno al intentar eliminar el producto.");
        //    }
        //}

        //private bool ProductosExists(int id)
        //{
        //    return _context.Productos.Any(e => e.ProductoId == id);
        //}
        //private static readonly string[] EstadosPermitidos = { "Nuevo", "Como nuevo", "Buen estado", "Aceptable" };

    }
}
