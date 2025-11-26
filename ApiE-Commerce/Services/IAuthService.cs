using ApiProyectoDeCursoE_Commerce.DTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;

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
