using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface ICompradorDAO
    {
        Task<Comprador?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction);
        Task<Comprador?> GetByIdAsync(int idComprador, SqlConnection connection, SqlTransaction? transaction);
        Task<int> CreateAsync(CompradorRegisterDTO comprador, SqlConnection connection, SqlTransaction? transaction);
        Task<int> DeleteAsync(int idComprador, SqlConnection connection);
    }
}
