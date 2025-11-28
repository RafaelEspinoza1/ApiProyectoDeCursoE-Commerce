using ApiProyectoDeCursoE_Commerce.DTOs.Auth;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs;

namespace ApiProyectoDeCursoE_Commerce.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDTO?> LoginAsync(LoginDTO login);

        Task<AuthResponseDTO?> RegisterAdminAsync(AdministradorCreateDTO admin);
        Task<AuthResponseDTO?> RegisterSellerAsync(VendedorCreateDTO vendedor);
        Task<AuthResponseDTO?> RegisterBuyerAsync(CompradorCreateDTO comprador);
    }
}
