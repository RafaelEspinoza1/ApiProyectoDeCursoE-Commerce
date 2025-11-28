using ApiProyectoDeCursoE_Commerce.DTOs.Auth.ProductoDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Finance;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using ApiProyectoDeCursoE_Commerce.Models.Finance;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class ComprobanteContableDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public ComprobanteContableDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<ComprobanteContable?> Get(SqlCommand cmd, SqlConnection connection)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, reader => new ComprobanteContable
            {
                IdComprobante = reader.GetInt32(reader.GetOrdinal("IdComprobante")),
                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                Tipo = reader.GetString(reader.GetOrdinal("Tipo")),
                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion"))
            ? null
            : reader.GetString(reader.GetOrdinal("Descripcion")),
                IdVendedor = reader.IsDBNull(reader.GetOrdinal("IdVendedor"))
            ? null
            : reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                EsComprobantePlataforma = reader.GetBoolean(reader.GetOrdinal("EsComprobantePlataforma"))
            });
        }

        public async Task<List<ComprobanteContable>> GetAllAsync(SqlConnection connection)
        {
            using var cmd = new SqlCommand(@"
                SELECT
                IdComprobante, Fecha, Tipo, Descripcion, IdVendedor, EsComprobantePlataforma
                FROM ComprobantesContables", connection);

            var cuentas = new List<ComprobanteContable>();

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                cuentas.Add(new ComprobanteContable
                {
                    IdComprobante = reader.GetInt32(reader.GetOrdinal("IdComprobante")),
                    Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                    Tipo = reader.GetString(reader.GetOrdinal("Tipo")),
                    Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion"))
            ? null
            : reader.GetString(reader.GetOrdinal("Descripcion")),
                    IdVendedor = reader.IsDBNull(reader.GetOrdinal("IdVendedor"))
            ? null
            : reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    EsComprobantePlataforma = reader.GetBoolean(reader.GetOrdinal("EsComprobantePlataforma"))
                });
            }

            return cuentas;
        }


        public async Task<ComprobanteContable?> GetByIdAsync(int idVendedor, SqlConnection connection)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdComprobante, Fecha, Tipo, Descripcion, IdVendedor, EsComprobantePlataforma
                FROM ComprobantesContables
                WHERE IdVendedor = @Id";
            cmd.Parameters.AddWithValue("@Id", idVendedor);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection);
        }

        public async Task<int> CreateAsync(ComprobanteContableCreateDTO comprobanteContable, SqlConnection connection, SqlTransaction? transaction)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO ComprobantesContables
                (Tipo, Descripcion, IdVendedor, EsComprobantePlataforma)
                VALUES
                (@Tipo, @Descripcion, @IdVendedor, @EsComprobantePlataforma)";
            cmd.Parameters.AddWithValue("@Tipo", comprobanteContable.Tipo);
            cmd.Parameters.AddWithValue("@Descripcion", comprobanteContable.Descripcion);
            cmd.Parameters.AddWithValue("@IdVendedor", comprobanteContable.IdVendedor);
            cmd.Parameters.AddWithValue("@EsComprobantePlataforma", comprobanteContable.EsComprobantePlataforma);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idVendedor, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM ComprobantesContables WHERE IdVendedor = @IdVendedor";
            cmd.Parameters.AddWithValue("@IdVendedor", idVendedor);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}