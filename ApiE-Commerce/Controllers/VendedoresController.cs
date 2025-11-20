using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedoresDTOs;
using ApiProyectoDeCursoE_Commerce.Guards;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIProyectoDeCursoE_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : ControllerBase
    {
        private readonly VendedoresRepository _vendedoresRepository;

        public VendedoresController(VendedoresRepository vendedoresRepository)
        {
            _vendedoresRepository = vendedoresRepository;
        }

        // GET: api/Vendedores
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendedor>>> GetVendedores()
        {
            var vendedores = await _vendedoresRepository.GetAll();
            if (vendedores == null) return NotFound();
            return Ok(vendedores);
        }

        // GET: api/Vendedores/{id}
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador, RolesEnum.Vendedor }
        })]
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendedor>> GetVendedorById(int id)
        {
            var vendedor = await _vendedoresRepository.GetById(id);
            if (vendedor == null) return NotFound();
            return vendedor;
        }

        // PUT: api/Vendedores/{id}
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador, RolesEnum.Vendedor }
        })]
        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarIngresosVendedor(int id, VendedoresUpdateDTO dto)
        {
            var vendedorExistente = await _vendedoresRepository.GetById(id);
            if (vendedorExistente == null) return NotFound();

            var filasAfectadas = await _vendedoresRepository.UpdateIngresos(id, dto.Ingresos);

            return NoContent();
        }

        // DELETE: api/Vendedores/{id}
        [Authorize]
        [TypeFilter(typeof(AuthGuard), Arguments = new object[] {
            new RolesEnum[] { RolesEnum.Administrador }
        })]
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarVendedor(int id)
        {
            var filasAfectadas = await _vendedoresRepository.Delete(id);
            
            return NoContent();
        }
    }
}
