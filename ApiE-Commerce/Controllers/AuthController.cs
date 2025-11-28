using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Repositories;
using ApiProyectoDeCursoE_Commerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(
        AuthService authService)
    {
        _authService = authService;
    }


    // ============================================================
    // INICIO DE SESIÓN
    // ============================================================
    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO login)
    {
        try
        {
            if (login == null)
                return BadRequest("Datos inválidos");

            var response = await _authService.LoginAsync(login);

            if (response == null)
                return Unauthorized("Usuario o contraseña incorrectos.");

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





    // ============================================================
    // REGISTRO
    // ============================================================
    [AllowAnonymous]
    [HttpPost("register/admin")]
    public async Task<ActionResult<AuthResponseDTO>> RegisterAuthAdminAsync([FromBody] AdministradorCreateDTO admin)
    {
        try
        {
            var response = await _authService.RegisterAdminAsync(admin);
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
    [HttpPost("register/buyer")]
    public async Task<ActionResult<AuthResponseDTO>> RegisterAuthBuyerAsync([FromBody] CompradorCreateDTO comprador)
    {
        try
        {
            var response = await _authService.RegisterBuyerAsync(comprador);
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

    [HttpPost("register/seller")]
    public async Task<ActionResult<AuthResponseDTO>> RegisterAuthSellerAsync([FromBody] VendedorCreateDTO vendedor)
    {
        try
        {
            var response = await _authService.RegisterSellerAsync(vendedor);
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

