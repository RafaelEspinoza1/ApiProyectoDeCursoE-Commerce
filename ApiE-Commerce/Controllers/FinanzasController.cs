using ApiProyectoDeCursoE_Commerce.DAOs;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.Finance;
using ApiProyectoDeCursoE_Commerce.DTOs.TransaccionDTOs;
using ApiProyectoDeCursoE_Commerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProyectoDeCursoE_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanzasController : Controller
    {
        public FinanzasService _finanzasService;

        public FinanzasController(FinanzasService finanzasService)
        {
            _finanzasService = finanzasService;
        }

        /*[AllowAnonymous]
        [HttpPost("get")]
        public async Task<IActionResult> GetTransacciones()
        {
            try
            {
                var response = await _finanzasService.();

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
        }*/

        [AllowAnonymous]
        [HttpPost("create")]
        public async Task<IActionResult> CreateCuenta([FromBody] CuentaCreateDTO transaccion)
        {
            try
            {
                if (transaccion == null)
                    return BadRequest("Datos inválidos");

                var response = await _finanzasService.CrearCuenta(transaccion);

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
