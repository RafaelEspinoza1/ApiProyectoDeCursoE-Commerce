using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        // Comandos de autenticación
        //Task<Usuario?> LoginUser(string correo, string password);
        Task<Usuario?> LoginUserById(int idUsuario);

        Task<int> RegisterUser(UsuariosCreateDTO usuario, SqlConnection connection, SqlTransaction? transaction);
        Task<bool?> RegisterAdminAsync(AdministradorRegisterDTO admin, SqlConnection connection, SqlTransaction? transaction);
        Task<bool?> RegisterSellerAsync(VendedorRegisterDTO vendedor, SqlConnection connection, SqlTransaction? transaction);
        Task<bool?> RegisterBuyerAsync(CompradorRegisterDTO comprador, SqlConnection connection, SqlTransaction? transaction);

        Task<bool?> CreateRefreshTokenAsync(RefreshTokenCreateDTO refreshToken, SqlConnection connection, SqlTransaction? transaction);
    }
}
