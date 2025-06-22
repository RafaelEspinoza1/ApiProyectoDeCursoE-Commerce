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
    public class ImagenProductosController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public ImagenProductosController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: api/ImagenProductoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImagenProducto>>> GetImagenesProducto()
        {
            return await _context.ImagenesProducto.ToListAsync();
        }

        // GET: api/ImagenProductoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImagenProducto>> GetImagenProducto(int id)
        {
            var imagenProducto = await _context.ImagenesProducto.FindAsync(id);

            if (imagenProducto == null)
            {
                return NotFound();
            }

            return imagenProducto;
        }

        // PUT: api/ImagenProductoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImagenProducto(int id, ImagenProducto imagenProducto)
        {
            if (id != imagenProducto.ImagenId)
            {
                return BadRequest();
            }

            _context.Entry(imagenProducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagenProductoExists(id))
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

        // POST: api/ImagenProductoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ImagenProducto>> PostImagenProducto(ImagenProducto imagenProducto)
        {
            _context.ImagenesProducto.Add(imagenProducto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetImagenProducto), new { id = imagenProducto.ImagenId }, imagenProducto);
        }

        // DELETE: api/ImagenProductoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImagenProducto(int id)
        {
            var imagenProducto = await _context.ImagenesProducto.FindAsync(id);
            if (imagenProducto == null)
            {
                return NotFound();
            }

            _context.ImagenesProducto.Remove(imagenProducto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ImagenProductoExists(int id)
        {
            return _context.ImagenesProducto.Any(e => e.ImagenId == id);
        }
    }
}
