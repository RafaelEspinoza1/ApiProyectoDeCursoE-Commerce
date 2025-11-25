using ApiProyectoDeCursoE_Commerce.DTOs.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface IRefreshTokenDAO
    {
        Task<RefreshToken?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction);
        Task<RefreshToken?> GetByIdAsync(int idUsuario, SqlConnection connection, SqlTransaction? transaction);
        Task<RefreshToken?> GetAllActiveAsync(SqlConnection connection, SqlTransaction? transaction);
        Task<RefreshToken?> GetAllRevokedAsync(SqlConnection connection, SqlTransaction? transaction);
        Task<int> CreateAsync(RefreshTokenCreateDTO refreshToken, SqlConnection connection, SqlTransaction? transaction);
        Task<int> DeleteAsync(int idUsuario, SqlConnection connection);
    }
}
