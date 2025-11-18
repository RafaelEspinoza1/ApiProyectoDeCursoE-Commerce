using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
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
    public class AdministradorController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public AdministradorController(ECommerceContext context)
        {
            _context = context;
        }

        //// GET: api/Administradors
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<AdministradorReadDTO>>> GetAdministrador([FromHeader(Name = "admin-password")] string password)
        //{
        //    if (password != "12345678")
        //        return Unauthorized("Contraseña incorrecta.");

        //    return await _context.Administrador
        //        .Select(a => new AdministradorReadDTO
        //        {
        //            AdministradorId = a.AdministradorId,
        //            Nombre = a.Nombre,
        //            Apellido = a.Apellido,
        //            Correo = a.Correo,
        //            Contraseña = a.Contraseña
        //        }).ToListAsync();
        //}

        //// GET: api/Administradors/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<AdministradorReadDTO>> GetAdministrador(int id, [FromHeader(Name = "admin-password")] string password)
        //{
        //    if (password != "12345678")
        //        return Unauthorized("Contraseña incorrecta.");
        //    var administrador = await _context.Administrador.FindAsync(id);

        //    if (administrador == null)
        //    {
        //        return NotFound();
        //    }

        //    return new AdministradorReadDTO
        //    {
        //        AdministradorId = administrador.AdministradorId,
        //        Nombre = administrador.Nombre,
        //        Apellido = administrador.Apellido,
        //        Correo = administrador.Correo,
        //        Contraseña = administrador.Contraseña
        //    };
        //}

        //// PUT: api/Administradors/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAdministrador(int id, [FromHeader(Name = "admin-password")] string password, AdministradorUpdateDTO dto)
        //{
        //    if (password != "12345678")
        //        return Unauthorized("Contraseña incorrecta.");

        //    var admin = await _context.Administrador.FindAsync(id);
        //    if (admin == null)
        //        return NotFound();

        //    admin.Nombre = dto.Nombre;
        //    admin.Apellido = dto.Apellido;
        //    admin.Correo = dto.Correo;
        //    admin.Contraseña = dto.Contraseña;

        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //// POST: api/Administradors
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<AdministradorReadDTO>> PostAdministrador([FromHeader(Name = "admin-password")] string password, AdministradorCreateDTO dto)
        //{
        //    if (password != "12345678")
        //        return Unauthorized("Contraseña incorrecta.");

        //    var nuevo = new Administrador
        //    {
        //        Nombre = dto.Nombre,
        //        Apellido = dto.Apellido,
        //        Correo = dto.Correo,
        //        Contraseña = dto.Contraseña
        //    };

        //    _context.Administrador.Add(nuevo);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetAdministrador), new { id = nuevo.AdministradorId }, new AdministradorReadDTO
        //    {
        //        AdministradorId = nuevo.AdministradorId,
        //        Nombre = nuevo.Nombre,
        //        Apellido = nuevo.Apellido,
        //        Correo = nuevo.Correo,
        //        Contraseña = nuevo.Contraseña
        //    });
        //}

        //// DELETE: api/Administradors/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAdministrador(int id, [FromHeader(Name = "admin-password")] string password)
        //{
        //    if (password != "12345678")
        //        return Unauthorized("Contraseña incorrecta.");

        //    var administrador = await _context.Administrador.FindAsync(id);
        //    if (administrador == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Administrador.Remove(administrador);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AdministradorExists(int id)
        //{
        //    return _context.Administrador.Any(e => e.AdministradorId == id);
        //}
    }
}
