using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class ProductoDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public ProductoDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<Producto?> Get(SqlCommand cmd, SqlConnection connection)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, reader => new Producto
            {
                IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto")),
                IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                IdCategoria = reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                IdEstadoProducto = reader.GetInt32(reader.GetOrdinal("IdEstadoProducto")
            });
        }
    }
}
