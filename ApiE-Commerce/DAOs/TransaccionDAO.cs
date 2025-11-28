using ApiProyectoDeCursoE_Commerce.DTOs.Auth.ProductoDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.TransaccionDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class TransaccionDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public TransaccionDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<Transaccion?> Get(SqlCommand cmd, SqlConnection connection)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, reader => new Transaccion
            {
                IdTransaccion = reader.GetInt32(reader.GetOrdinal("IdTransaccion")),
                IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto")),
                IdComprador = reader.GetInt32(reader.GetOrdinal("IdComprador")),
                IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                IdEstadoTransaccion = reader.GetInt32(reader.GetOrdinal("IdEstadoTransaccion")),
                IdMetodoDePago = reader.GetInt32(reader.GetOrdinal("IdMetodoDePago")),
                PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PrecioUnitario")),
                UnidadesCompradas = reader.GetInt32(reader.GetOrdinal("UnidadesCompradas")),
                PrecioEnvio = reader.GetDecimal(reader.GetOrdinal("PrecioEnvio")),
                Descuento = reader.GetDecimal(reader.GetOrdinal("Descuento")),
                PrecioTotal = reader.GetDecimal(reader.GetOrdinal("PrecioTotal")),
                CostoUnitario = reader.GetDecimal(reader.GetOrdinal("CostoUnitario"))
            });
        }

        public async Task<List<Transaccion>> GetAllAsync(SqlConnection connection)
        {
            using var cmd = new SqlCommand(@"
                SELECT
                IdTransaccion, IdProducto, IdComprador, IdVendedor, IdEstadoTransaccion, IdMetodoDePago,
                PrecioUnitario, UnidadesCompradas, PrecioEnvio, Descuento, PrecioTotal, CostoUnitario
                FROM Transacciones", connection);

            var transacciones = new List<Transaccion>();

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                transacciones.Add(new Transaccion
                {
                    IdTransaccion = reader.GetInt32(reader.GetOrdinal("IdTransaccion")),
                    IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto")),
                    IdComprador = reader.GetInt32(reader.GetOrdinal("IdComprador")),
                    IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    IdEstadoTransaccion = reader.GetInt32(reader.GetOrdinal("IdEstadoTransaccion")),
                    IdMetodoDePago = reader.GetInt32(reader.GetOrdinal("IdMetodoDePago")),
                    PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PrecioUnitario")),
                    UnidadesCompradas = reader.GetInt32(reader.GetOrdinal("UnidadesCompradas")),
                    PrecioEnvio = reader.GetDecimal(reader.GetOrdinal("PrecioEnvio")),
                    Descuento = reader.GetDecimal(reader.GetOrdinal("Descuento")),
                    PrecioTotal = reader.GetDecimal(reader.GetOrdinal("PrecioTotal")),
                    CostoUnitario = reader.GetDecimal(reader.GetOrdinal("CostoUnitario"))
                });
            }

            return transacciones;
        }


        public async Task<Transaccion?> GetByIdAsync(int idProducto, SqlConnection connection)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdTransaccion, IdProducto, IdComprador, IdVendedor, IdEstadoTransaccion, IdMetodoDePago,
                PrecioUnitario, UnidadesCompradas, PrecioEnvio, Descuento, PrecioTotal, CostoUnitario
                FROM Transacciones
                WHERE IdProducto = @Id";
            cmd.Parameters.AddWithValue("@Id", idProducto);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection);
        }

        public async Task<int> CreateAsync(TransaccionCreateDTO transaccion, SqlConnection connection, SqlTransaction? transaction)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Productos
                (IdProducto, IdComprador, IdVendedor, IdEstadoTransaccion, IdMetodoDePago,
                PrecioUnitario, UnidadesCompradas, PrecioEnvio, Descuento, PrecioTotal, CostoUnitario)
                VALUES
                (@IdProducto, @IdComprador, @IdVendedor, @IdEstadoTransaccion, @IdMetodoDePago,
                @PrecioUnitario, @UnidadesCompradas, @PrecioEnvio, @Descuento, @PrecioTotal, @CostoUnitario)";
            cmd.Parameters.AddWithValue("@IdVendedor", transaccion.IdProducto);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idProducto, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Transacciones WHERE IdProducto = @IdProducto";
            cmd.Parameters.AddWithValue("@IdProducto", idProducto);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
