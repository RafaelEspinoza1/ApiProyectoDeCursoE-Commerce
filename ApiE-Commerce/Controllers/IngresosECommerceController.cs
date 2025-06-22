using ApiProyectoDeCursoE_Commerce.Data;
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
        private readonly ECommerceContext _context;

        public IngresosECommerceController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: api/IngresosECommerces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngresosECommerce>>> GetIngresosECommerce()
        {
            return await _context.IngresosECommerce.ToListAsync();
        }

        // GET: api/IngresosECommerces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IngresosECommerce>> GetIngresosECommerce(int id)
        {
            var ingresosECommerce = await _context.IngresosECommerce.FindAsync(id);

            if (ingresosECommerce == null)
            {
                return NotFound();
            }

            return ingresosECommerce;
        }

        // PUT: api/IngresosECommerces/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngresosECommerce(int id, IngresosECommerce ingresosECommerce)
        {
            if (id != ingresosECommerce.IngresoId)
            {
                return BadRequest();
            }

            _context.Entry(ingresosECommerce).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngresosECommerceExists(id))
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

        // POST: api/IngresosECommerces
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IngresosECommerce>> PostIngresosECommerce(IngresosECommerce ingresosECommerce)
        {
            _context.IngresosECommerce.Add(ingresosECommerce);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIngresosECommerce), new { id = ingresosECommerce.IngresoId }, ingresosECommerce);
        }

        // DELETE: api/IngresosECommerces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngresosECommerce(int id)
        {
            var ingresosECommerce = await _context.IngresosECommerce.FindAsync(id);
            if (ingresosECommerce == null)
            {
                return NotFound();
            }

            _context.IngresosECommerce.Remove(ingresosECommerce);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IngresosECommerceExists(int id)
        {
            return _context.IngresosECommerce.Any(e => e.IngresoId == id);
        }
    }
}
