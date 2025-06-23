using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.ImagenProductoDTOS;
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
    public class ImagenProductosController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public ImagenProductosController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: api/ImagenProductoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImagenProductoReadDTO>>> GetImagenesProducto()
        {
            return await _context.ImagenesProducto
                .Select(img => new ImagenProductoReadDTO
                {
                    ImagenId = img.ImagenId,
                    ImagenUrl = img.ImagenUrl,
                    ProductoId = img.ProductoId
                })
                .ToListAsync();
        }

        // GET: api/ImagenProductoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImagenProductoReadDTO>> GetImagenProducto(int id)
        {
            var img = await _context.ImagenesProducto.FindAsync(id);

            if (img == null)
                return NotFound();

            return new ImagenProductoReadDTO
            {
                ImagenId = img.ImagenId,
                ImagenUrl = img.ImagenUrl,
                ProductoId = img.ProductoId
            };
        }

        // PUT: api/ImagenProductoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImagenProducto(int id, ImagenProductoUpdateDTO dto)
        {
            var imagen = await _context.ImagenesProducto.FindAsync(id);

            if (imagen == null)
                return NotFound();

            imagen.ImagenUrl = dto.ImagenUrl;
            if (!Regex.IsMatch(dto.ImagenUrl, @"\.(jpg|jpeg|png|gif)$", RegexOptions.IgnoreCase))
            {
                return BadRequest("La URL debe ser de una imagen válida (.jpg, .png, .jpeg, o .gif).");
            }
            if (imagen.ImagenUrl == dto.ImagenUrl)
            {
                return BadRequest("La URL de la imagen es igual a la actual.");
            }



            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/ImagenProductoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ImagenProductoReadDTO>> PostImagenProducto(ImagenProductoCreateDTO dto)
        {
            var productoExiste = await _context.Productos.AnyAsync(p => p.ProductoId == dto.ProductoId);
            if (!productoExiste)
                return BadRequest("El producto especificado no existe.");
            if (!Regex.IsMatch(dto.ImagenUrl, @"\.(jpg|jpeg|png|gif)$", RegexOptions.IgnoreCase))
            {
                return BadRequest("La URL debe ser de una imagen válida (.jpg, .png, .jpeg o .gif).");
            }
            bool urlDuplicada = await _context.ImagenesProducto
                    .AnyAsync(i => i.ProductoId == dto.ProductoId && i.ImagenUrl == dto.ImagenUrl);

            if (urlDuplicada)
            {
                return BadRequest("Ya existe esta imagen para el producto.");
            }


            var nuevaImagen = new ImagenProducto
            {
                ImagenUrl = dto.ImagenUrl,
                ProductoId = dto.ProductoId
            };

            _context.ImagenesProducto.Add(nuevaImagen);
            await _context.SaveChangesAsync();

            var readDTO = new ImagenProductoReadDTO
            {
                ImagenId = nuevaImagen.ImagenId,
                ImagenUrl = nuevaImagen.ImagenUrl,
                ProductoId = nuevaImagen.ProductoId
            };

            return CreatedAtAction(nameof(GetImagenProducto), new { id = nuevaImagen.ImagenId }, readDTO);

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
        // GET: api/ImagenProductos/PorProducto/3
        [HttpGet("PorProducto/{productoId}")]
        public async Task<ActionResult<IEnumerable<ImagenProductoReadDTO>>> GetImagenesPorProducto(int productoId)
        {
            var imagenes = await _context.ImagenesProducto
                .Where(i => i.ProductoId == productoId)
                .Select(i => new ImagenProductoReadDTO
                {
                    ImagenId = i.ImagenId,
                    ImagenUrl = i.ImagenUrl,
                    ProductoId = i.ProductoId
                })
                .ToListAsync();

            if (imagenes == null || !imagenes.Any())
                return NotFound("Este producto no tiene imágenes asociadas.");

            return imagenes;
        }


        private bool ImagenProductoExists(int id)
        {
            return _context.ImagenesProducto.Any(e => e.ImagenId == id);
        }
    }
}
