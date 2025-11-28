using ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface IVendedorDAO
    {
        Task<Vendedor?> GetAllAsync(SqlConnection connection);
        Task<Vendedor?> GetByIdAsync(int idVendedor, SqlConnection connection);
        Task<int> CreateAsync(VendedorRegisterDTO vendedor, SqlConnection connection, SqlTransaction? transaction);
        Task<int> DeleteAsync(int idVendedor, SqlConnection connection);
    }
}
