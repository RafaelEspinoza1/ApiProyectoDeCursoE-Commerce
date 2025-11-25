using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface IVendedorDAO
    {
        Task<Vendedor?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction);
        Task<Vendedor?> GetByIdAsync(int idVendedor, SqlConnection connection, SqlTransaction? transaction);
        Task<int> CreateAsync(VendedorRegisterDTO vendedor, SqlConnection connection, SqlTransaction? transaction);
        Task<int> DeleteAsync(int idVendedor, SqlConnection connection);
    }
}
