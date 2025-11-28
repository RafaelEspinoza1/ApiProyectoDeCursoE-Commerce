using ApiProyectoDeCursoE_Commerce.DTOs.Auth.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        // Comandos de autenticación
        Task<Usuario?> LoginUser(string correo, string password, SqlConnection connection);
        Task<Usuario?> LoginUserById(int idUsuario, SqlConnection connection);

        Task<int> RegisterUser(UsuariosCreateDTO usuario, SqlConnection connection, SqlTransaction? transaction);
        Task<bool?> RegisterAdminAsync(AdministradorRegisterDTO admin, SqlConnection connection, SqlTransaction? transaction);
        Task<bool?> RegisterSellerAsync(VendedorRegisterDTO vendedor, SqlConnection connection, SqlTransaction? transaction);
        Task<bool?> RegisterBuyerAsync(CompradorRegisterDTO comprador, SqlConnection connection, SqlTransaction? transaction);

        Task<bool?> CreateRefreshTokenAsync(RefreshTokenCreateDTO refreshToken, SqlConnection connection, SqlTransaction? transaction);
    }
}
