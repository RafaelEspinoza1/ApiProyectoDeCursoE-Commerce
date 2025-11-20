using ApiProyectoDeCursoE_Commerce.Models;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken?> GetActiveToken(int idUsuario, Guid token);
        Task<RefreshToken?> GetActiveTokenByUser(int idUsuario);
        Task<int> Create(RefreshToken token);
        Task<int> Update(RefreshToken token);
    }
}
