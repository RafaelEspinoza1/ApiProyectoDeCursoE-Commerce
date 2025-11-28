using ApiProyectoDeCursoE_Commerce.DTOs.Auth.ProductoDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Finance;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using ApiProyectoDeCursoE_Commerce.Models.Finance;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class CuentaDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public CuentaDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<Cuenta?> Get(SqlCommand cmd, SqlConnection connection)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, reader => new Cuenta
            {
                IdCuenta = reader.GetInt32(reader.GetOrdinal("IdCuenta")),
                IdTipoCuenta = reader.GetInt32(reader.GetOrdinal("IdTipoCuenta")),
                IdVendedor = reader.IsDBNull(reader.GetOrdinal("IdVendedor")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                EsCuentaPlataforma = reader.GetBoolean(reader.GetOrdinal("EsCuentaPlataforma")),
                NombreCuenta = reader.GetString(reader.GetOrdinal("NombreCuenta")),
                CodigoCuenta = reader.GetString(reader.GetOrdinal("CodigoCuenta")),
                EsAfectable = reader.GetBoolean(reader.GetOrdinal("EsAfectable")),
                EsCuentaDeSistema = reader.GetBoolean(reader.GetOrdinal("EsCuentaDeSistema")),
                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion")),
                SaldoActual = reader.GetDecimal(reader.GetOrdinal("SaldoActual"))
            });
        }

        public async Task<List<Cuenta>> GetAllAsync(SqlConnection connection)
        {
            using var cmd = new SqlCommand(@"
                SELECT
                IdCuenta, IdTipoCuenta, IdVendedor, EsCuentaPlataforma, NombreCuenta, CodigoCuenta,
                EsAfectable, EsCuentaDeSistema, Descripcion, SaldoActual
                FROM Cuentas", connection);

            var cuentas = new List<Cuenta>();

            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                cuentas.Add(new Cuenta
                {
                    IdCuenta = reader.GetInt32(reader.GetOrdinal("IdCuenta")),
                    IdTipoCuenta = reader.GetInt32(reader.GetOrdinal("IdTipoCuenta")),
                    IdVendedor = reader.IsDBNull(reader.GetOrdinal("IdVendedor"))
            ? (int?)null
            : reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    EsCuentaPlataforma = reader.GetBoolean(reader.GetOrdinal("EsCuentaPlataforma")),
                    NombreCuenta = reader.GetString(reader.GetOrdinal("NombreCuenta")),
                    CodigoCuenta = reader.GetString(reader.GetOrdinal("CodigoCuenta")),
                    EsAfectable = reader.GetBoolean(reader.GetOrdinal("EsAfectable")),
                    EsCuentaDeSistema = reader.GetBoolean(reader.GetOrdinal("EsCuentaDeSistema")),
                    Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion"))
            ? null
            : reader.GetString(reader.GetOrdinal("Descripcion")),
                    SaldoActual = reader.GetDecimal(reader.GetOrdinal("SaldoActual"))
                });
            }

            return cuentas;
        }


        public async Task<Cuenta?> GetByIdAsync(int idVendedor, SqlConnection connection)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdCuenta, IdTipoCuenta, IdVendedor, EsCuentaPlataforma, NombreCuenta, CodigoCuenta,
                EsAfectable, EsCuentaDeSistema, Descripcion, SaldoActual
                FROM Cuentas
                WHERE IdVendedor = @Id";
            cmd.Parameters.AddWithValue("@Id", idVendedor);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection);
        }

        public async Task<int> CreateAsync(CuentaCreateDTO cuenta, SqlConnection connection, SqlTransaction? transaction)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Cuentas
                (IdTipoCuenta, IdVendedor, EsCuentaPlataforma, NombreCuenta, CodigoCuenta,
                EsAfectable, EsCuentaDeSistema, Descripcion, SaldoActual)
                VALUES
                (@IdTipoCuenta, @IdVendedor, @EsCuentaPlataforma, @NombreCuenta, @CodigoCuenta,
                @EsAfectable, @EsCuentaDeSistema, @Descripcion, @SaldoActual)";
            cmd.Parameters.AddWithValue("@IdTipoCuenta", cuenta.IdTipoCuenta);
            cmd.Parameters.AddWithValue("@IdVendedor", cuenta.IdVendedor);
            cmd.Parameters.AddWithValue("@EsCuentaPlataforma", cuenta.EsCuentaPlataforma);
            cmd.Parameters.AddWithValue("@NombreCuenta", cuenta.NombreCuenta);
            cmd.Parameters.AddWithValue("@CodigoCuenta", cuenta.CodigoCuenta);
            cmd.Parameters.AddWithValue("@EsAfectable", cuenta.EsAfectable);
            cmd.Parameters.AddWithValue("@EsCuentaDeSistema", cuenta.EsCuentaDeSistema);
            cmd.Parameters.AddWithValue("@Descripcion", cuenta.Descripcion);
            cmd.Parameters.AddWithValue("@SaldoActual", cuenta.SaldoActual);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idVendedor, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cuentas WHERE IdVendedor = @IdVendedor";
            cmd.Parameters.AddWithValue("@IdVendedor", idVendedor);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
