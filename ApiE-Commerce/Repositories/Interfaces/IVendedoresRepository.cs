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
        Task<int> Create(Vendedor vendedor);
        Task<int> Update(Vendedor vendedor);
        Task<int> Delete(int id);
    }
}
