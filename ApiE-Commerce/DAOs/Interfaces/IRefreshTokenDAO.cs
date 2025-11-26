using ApiProyectoDeCursoE_Commerce.DTOs.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface IRefreshTokenDAO
    {
        Task<RefreshToken?> GetAllAsync(SqlConnection connection);
        Task<RefreshToken?> GetByIdAsync(int idUsuario, SqlConnection connection);
        Task<RefreshToken?> GetAllActiveAsync(SqlConnection connection);
        Task<RefreshToken?> GetAllRevokedAsync(SqlConnection connection);

        Task<int> CreateAsync(RefreshTokenCreateDTO refreshToken, SqlConnection connection, SqlTransaction? transaction);
        Task<int> UpdateAsync(RefreshToken refreshToken, SqlConnection connection);
        Task<int> DeleteAsync(int idUsuario, SqlConnection connection);
    }
}
