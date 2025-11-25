using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken?> GetActiveToken(int idUsuario, Guid token);
        Task<RefreshToken?> GetActiveTokenByUser(int idUsuario);
        Task<int> Create(RefreshToken token, SqlConnection connection, SqlTransaction? transaction);
        Task<int> Update(RefreshToken token);
    }
}
