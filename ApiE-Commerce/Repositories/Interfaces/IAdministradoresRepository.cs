using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IAdministradoresRepository
    {
        // Comandos de filtro de búsqueda
        Task<Administrador?> GetAll();
        Task<Administrador?> GetByIdAdministrador(int id);
        Task<Administrador?> GetByIdUsuario(int id);

        // Comandos de inserción, actualización o eliminación
        // Devuelven el número de filas afectadas
        Task<int> Create(UsuariosCreateDTO usuario);
        Task<int> Delete(int id);
    }
}
