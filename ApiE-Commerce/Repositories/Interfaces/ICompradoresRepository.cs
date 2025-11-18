using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface ICompradoresRepository
    {
        // Comandos de filtro de búsqueda
        Task<Comprador?> GetAll();
        Task<Comprador?> GetByIdComprador(int id);
        Task<Comprador?> GetByIdUsuario(int id);

        // Comandos de inserción, actualización o eliminación
        // Devuelven el número de filas afectadas
        Task<int> Create(int id);
        Task<int> Delete(int id);
    }
}
