using ApiProyectoDeCursoE_Commerce.DAOs;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.ProductoDTOs;
using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProyectoDeCursoE_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public ProductoDAO _productoDAO;

        public ECommerceContext _context;

        public ProductoController(ProductoDAO productoDAO, ECommerceContext context)
        {
            _productoDAO = productoDAO;
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("get")]
        public async Task<IActionResult> GetProductos()
        {
            try
            {
                using var connection = _context.GetConnection();
                await connection.OpenAsync();

                var response = await _productoDAO.GetAllAsync(connection);

                if (response == null || response.Count == 0)
                    return NotFound("No se encontró ningún producto registrado.");

                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("create")]
        public async Task<IActionResult> CreateProducto([FromBody] ProductoCreateDTO producto)
        {
            try
            {
                using var connection = _context.GetConnection();
                await connection.OpenAsync();

                if (producto == null)
                    return BadRequest("Datos inválidos");

                var response = await _productoDAO.CreateAsync(producto, connection, transaction: null);

                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
