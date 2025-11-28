using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface ICompradorDAO
    {
        Task<Comprador?> GetAllAsync(SqlConnection connection);
        Task<Comprador?> GetByIdAsync(int idComprador, SqlConnection connection);
        Task<int> CreateAsync(CompradorRegisterDTO comprador, SqlConnection connection, SqlTransaction? transaction);
        Task<int> DeleteAsync(int idComprador, SqlConnection connection);
    }
}
