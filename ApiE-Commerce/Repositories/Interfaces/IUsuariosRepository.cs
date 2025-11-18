using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IUsuariosRepository
    {
        // Comandos de filtro de búsqueda
        Task<Usuario?> GetAll();
        Task<Usuario?> GetById(int id);
        Task<Usuario?> GetByFirstName(string firstName);
        Task<Usuario?> GetBySecondName(string secondName);
        Task<Usuario?> GetByFirstSurname(string firstSurname);
        Task<Usuario?> GetBySecondSurname(string secondSurname);
        Task<Usuario?> GetByTelephone(string telephone);
        Task<Usuario?> GetByEmail(string email);

        // Comandos de inserción, actualización o eliminación
        // Devuelven el número de filas afectadas
        Task<int> Create(UsuariosCreateDTO usuario);
        Task<int> Update(UsuariosUpdateDTO usuario, int id);
        Task<int> Delete(int id);

        // Comandos de autenticación
        Task<Usuario?> RegisterUser(UsuariosCreateDTO usuario);
        Task<Usuario?> LoginUser(int id, string password);
    }
}
