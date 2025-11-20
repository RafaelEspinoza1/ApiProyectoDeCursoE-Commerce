using ApiProyectoDeCursoE_Commerce.Models;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IVendedoresRepository
    {
        // Obtener todos los vendedores
        Task<IEnumerable<Vendedor>> GetAll();

        // Obtener vendedor por Id
        Task<Vendedor?> GetById(int id);

        // Crear nuevo vendedor con solo IdUsuario
        Task<int> Create(int idUsuario);

        // Actualizar ingresos del vendedor
        Task<int> UpdateIngresos(int idVendedor, decimal ingresos);

        // Eliminar vendedor
        Task<int> Delete(int id);
    }
}
