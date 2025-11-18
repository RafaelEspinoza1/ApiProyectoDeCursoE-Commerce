using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedoresDTOs;
using ApiProyectoDeCursoE_Commerce.Models;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IVendedoresRepository
    {
        // Comandos de filtro de búsqueda
        Task<Vendedor?> GetAll();
        Task<Vendedor?> GetById(int id);
        Task<Vendedor?> GetByBusinessName(string businessName);
        Task<Vendedor?> GetIfIsContributor(bool isContributor);

        // Comandos de inserción, actualización o eliminación
        // Devuelven el número de filas afectadas
        Task<int> Create(UsuariosCreateDTO usuario);
        Task<int> Update(VendedoresUpdateDTO vendedor, int id);
        Task<int> Delete(int id);
    }
}
