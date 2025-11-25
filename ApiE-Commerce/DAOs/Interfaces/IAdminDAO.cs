using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAO.Interfaces
{
    public interface IAdminDAO
    {
        Task<Administrador?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction);
        Task<Administrador?> GetByIdAsync(int idAdmin, SqlConnection connection, SqlTransaction? transaction);
        Task<int> CreateAsync(AdministradorRegisterDTO admin, SqlConnection connection, SqlTransaction? transaction);
        Task<int> DeleteAsync(int idAdmin, SqlConnection connection);
    }
}
