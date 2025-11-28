using ApiProyectoDeCursoE_Commerce.DTOs.Auth.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.ProductoDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
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
                IdEstadoProducto = reader.GetInt32(reader.GetOrdinal("IdEstadoProducto")),
                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                Precio = reader.GetDecimal(reader.GetOrdinal("Precio")),
                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                StockDisponible = reader.GetInt32(reader.GetOrdinal("StockDisponible"))
            });
        }

        public async Task<List<Producto>> GetAllAsync(SqlConnection connection)
        {
            using var cmd = new SqlCommand(@"
                SELECT
                IdProducto, IdVendedor, IdCategoria, IdEstadoProducto, Nombre, Precio, Descripcion, StockDisponible
                FROM Productos", connection);

            var productos = new List<Producto>();

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                productos.Add(new Producto
                {
                    IdProducto = reader.IsDBNull(reader.GetOrdinal("IdProducto")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdProducto")),
                    IdVendedor = reader.IsDBNull(reader.GetOrdinal("IdVendedor")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    IdCategoria = reader.IsDBNull(reader.GetOrdinal("IdCategoria")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                    IdEstadoProducto = reader.IsDBNull(reader.GetOrdinal("IdEstadoProducto")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdEstadoProducto")),
                    Nombre = reader.IsDBNull(reader.GetOrdinal("Nombre")) ? string.Empty : reader.GetString(reader.GetOrdinal("Nombre")),
                    Precio = reader.IsDBNull(reader.GetOrdinal("Precio")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Precio")),
                    Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? string.Empty : reader.GetString(reader.GetOrdinal("Descripcion")),
                    StockDisponible = reader.IsDBNull(reader.GetOrdinal("StockDisponible")) ? 0 : reader.GetInt32(reader.GetOrdinal("StockDisponible"))
                });
            }

            return productos;
        }


        public async Task<Producto?> GetByIdAsync(int idVendedor, SqlConnection connection)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdProducto, IdVendedor, IdCategoria, IdEstadoProducto, Nombre, Precio, Descripcion, StockDisponible
                FROM Productos
                WHERE IdVendedor = @Id";
            cmd.Parameters.AddWithValue("@Id", idVendedor);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection);
        }

        public async Task<int> CreateAsync(ProductoCreateDTO producto, SqlConnection connection, SqlTransaction? transaction)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Productos
                (IdVendedor, IdCategoria, IdEstadoProducto, Nombre, Precio, Descripcion, StockDisponible)
                VALUES
                (@IdVendedor, @IdCategoria, @IdEstadoProducto, @Nombre, @Precio, @Descripcion, @StockDisponible)";
            cmd.Parameters.AddWithValue("@IdVendedor", producto.IdVendedor);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idVendedor, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Productos WHERE IdVendedor = @IdVendedor";
            cmd.Parameters.AddWithValue("@IdAdministrador", idVendedor);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
