using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace ApiProyectoDeCursoE_Commerce.DAOs.Interfaces
{
    public interface IUsuarioDAO
    {
        Task<Usuario?> Get(SqlCommand cmd, SqlConnection connection);
        Task<Usuario?> GetAllAsync(SqlConnection connection);
        Task<Usuario?> GetByIdAsync(int idUsuario, SqlConnection connection);
        Task<Usuario?> GetByFirstNameAsync(string firstName, SqlConnection connection);
        Task<Usuario?> GetBySecondNameAsync(string secondName, SqlConnection connection);
        Task<Usuario?> GetByFirstSurnameAsync(string firstSurname, SqlConnection connection);
        Task<Usuario?> GetBySecondSurnameAsync(string secondSurname, SqlConnection connection);
        Task<Usuario?> GetByTelephoneAsync(string telephone, SqlConnection connection);
        Task<Usuario?> GetByEmailAsync(string email, SqlConnection connection);

        Task<int> CreateAsync(UsuariosCreateDTO usuario, SqlConnection connection, SqlTransaction? transaction);
        Task<int> UpdateAsync(int idUsuario, UsuariosUpdateDTO usuario, SqlConnection connection);
        Task<int> DeleteAsync(int idUsuario, SqlConnection connection);
    }
}
