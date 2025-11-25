using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface IUsuarioDAO
    {
        Task<Usuario?> Get(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetByIdAsync(int idUsuario, SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetByFirstNameAsync(string firstName, SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetBySecondNameAsync(string secondName, SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetByFirstSurnameAsync(string firstSurname, SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetBySecondSurnameAsync(string secondSurname, SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetByTelephoneAsync(string telephone, SqlConnection connection, SqlTransaction? transaction);
        Task<Usuario?> GetByEmailAsync(string email, SqlConnection connection, SqlTransaction? transaction);

        Task<int> CreateAsync(UsuariosCreateDTO usuario, SqlConnection connection, SqlTransaction? transaction);
        Task<int> UpdateAsync(int idUsuario, UsuariosUpdateDTO usuario, SqlConnection connection);
        Task<int> DeleteAsync(int idUsuario, SqlConnection connection);
    }
}
