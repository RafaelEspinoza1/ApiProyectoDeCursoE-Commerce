﻿using ApiProyectoDeCursoE_Commerce.Data;
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

        // GET: api/Administradors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrador>>> GetAdministrador()
        {
            return await _context.Administrador.ToListAsync();
        }

        // GET: api/Administradors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Administrador>> GetAdministrador(int id)
        {
            var administrador = await _context.Administrador.FindAsync(id);

            if (administrador == null)
            {
                return NotFound();
            }

            return administrador;
        }

        // PUT: api/Administradors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministrador(int id, Administrador administrador)
        {
            if (id != administrador.AdministradorId)
            {
                return BadRequest();
            }

            _context.Entry(administrador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Administradors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Administrador>> PostAdministrador(Administrador administrador)
        {
            _context.Administrador.Add(administrador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdministrador", new { id = administrador.AdministradorId }, administrador);
        }

        // DELETE: api/Administradors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdministrador(int id)
        {
            var administrador = await _context.Administrador.FindAsync(id);
            if (administrador == null)
            {
                return NotFound();
            }

            _context.Administrador.Remove(administrador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdministradorExists(int id)
        {
            return _context.Administrador.Any(e => e.AdministradorId == id);
        }
    }
}
