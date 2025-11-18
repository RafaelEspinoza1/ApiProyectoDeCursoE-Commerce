using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.IngresosECommerceDTOs;
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
    public class IngresosECommerceController : ControllerBase
    {
        //private readonly ECommerceContext _context;

        //public IngresosECommerceController(ECommerceContext context)
        //{
        //    _context = context;
        //}

        //// GET: api/IngresosECommerces
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<IngresosECommerceReadDTO>>> GetIngresosECommerce()
        //{
        //                    return await _context.IngresosECommerce
        //         .Include(i => i.Usuario)
        //         .Select(i => new IngresosECommerceReadDTO
        //         {
        //             IngresoId = i.IngresoId,
        //             Cantidad = i.Cantidad,
        //             Tipo = i.Tipo,
        //             Fecha = i.Fecha,
        //             UsuarioId = i.UsuarioId,
        //             NombreUsuario = i.Usuario.Nombre,
        //             ApellidoUsuario = i.Usuario.Apellido
        //         })
        //         .ToListAsync();
        //}

        //// GET: api/IngresosECommerces/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<IngresosECommerceReadDTO>> GetIngresosECommerce(int id)
        //{
        //    var ingreso = await _context.IngresosECommerce
        //     .Include(i => i.Usuario)
        //     .FirstOrDefaultAsync(i => i.IngresoId == id);
        //        if (ingreso == null)
        //            return NotFound();

        //    return new IngresosECommerceReadDTO
        //    {
        //        IngresoId = ingreso.IngresoId,
        //        Cantidad = ingreso.Cantidad,
        //        Tipo = ingreso.Tipo,
        //        Fecha = ingreso.Fecha,
        //        UsuarioId = ingreso.UsuarioId,
        //        NombreUsuario = ingreso.Usuario.Nombre,
        //        ApellidoUsuario = ingreso.Usuario.Apellido
        //    };
        //}

        //// PUT: api/IngresosECommerces/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutIngresosECommerce(int id, IngresosECommerceUpdateDTO dto)
        //{
        //    var ingreso = await _context.IngresosECommerce.FindAsync(id);
        //    if (ingreso == null)
        //        return NotFound();

        //    ingreso.Cantidad = dto.Cantidad;
        //    ingreso.Tipo = dto.Tipo;
        //    ingreso.Fecha = DateTime.Now;

        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        //// POST: api/IngresosECommerces
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<IngresosECommerceReadDTO>> PostIngresosECommerce(IngresosECommerceCreateDTO dto)
        //{
        //    var usuarioExiste = await _context.Usuarios.AnyAsync(u => u.UsuarioId == dto.UsuarioId);
        //    if (!usuarioExiste)
        //        return BadRequest("El usuario no existe.");

        //    var nuevoIngreso = new Ingreso
        //    {
        //        Cantidad = dto.Cantidad,
        //        Tipo = dto.Tipo,
        //        Fecha = DateTime.Now,
        //        UsuarioId = dto.UsuarioId
        //    };

        //    _context.IngresosECommerce.Add(nuevoIngreso);
        //    await _context.SaveChangesAsync();

        //    await _context.Entry(nuevoIngreso).Reference(i => i.Usuario).LoadAsync();

        //    return CreatedAtAction(nameof(GetIngresosECommerce), new { id = nuevoIngreso.IngresoId }, new IngresosECommerceReadDTO
        //    {
        //        IngresoId = nuevoIngreso.IngresoId,
        //        Cantidad = nuevoIngreso.Cantidad,
        //        Tipo = nuevoIngreso.Tipo,
        //        Fecha = nuevoIngreso.Fecha,
        //        UsuarioId = nuevoIngreso.UsuarioId,
        //        NombreUsuario = nuevoIngreso.Usuario.Nombre,
        //        ApellidoUsuario = nuevoIngreso.Usuario.Apellido
        //    });
        //}

        //// DELETE: api/IngresosECommerces/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteIngresosECommerce(int id)
        //{
        //    var ingresosECommerce = await _context.IngresosECommerce.FindAsync(id);
        //    if (ingresosECommerce == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.IngresosECommerce.Remove(ingresosECommerce);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool IngresosECommerceExists(int id)
        //{
        //    return _context.IngresosECommerce.Any(e => e.IngresoId == id);
        //}
    }
}
