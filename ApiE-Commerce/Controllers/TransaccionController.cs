using ApiProyectoDeCursoE_Commerce.DAOs;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.ProductoDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.TransaccionDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProyectoDeCursoE_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionController : Controller
    {
        public TransaccionDAO _transaccionDAO;

        public ECommerceContext _context;

        public TransaccionController(TransaccionDAO transaccionDAO, ECommerceContext context)
        {
            _transaccionDAO = transaccionDAO;
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("get")]
        public async Task<IActionResult> GetTransacciones()
        {
            try
            {
                using var connection = _context.GetConnection();
                await connection.OpenAsync();

                var response = await _transaccionDAO.GetAllAsync(connection);

                if (response == null || response.Count == 0)
                    return NotFound("No se encontró ninguna transacción registrada.");

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
        public async Task<IActionResult> CreateTransacciones([FromBody] TransaccionCreateDTO transaccion)
        {
            try
            {
                using var connection = _context.GetConnection();
                await connection.OpenAsync();

                if (transaccion == null)
                    return BadRequest("Datos inválidos");

                var response = await _transaccionDAO.CreateAsync(transaccion, connection, transaction: null);

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
