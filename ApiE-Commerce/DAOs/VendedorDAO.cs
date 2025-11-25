using ApiProyectoDeCursoE_Commerce.DAOs.Interfaces;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class VendedorDAO: IVendedorDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public VendedorDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<Vendedor?> Get(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, transaction, reader => new Vendedor
            {
                IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                Ingresos = reader.GetDecimal(reader.GetOrdinal("Ingresos"))
            });
        }

        public async Task<Vendedor?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, Ingresos
                FROM Vendedores";

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<Vendedor?> GetByIdAsync(int idUsuario, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, Ingresos
                FROM Vendedores
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", idUsuario);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<int> CreateAsync(VendedorRegisterDTO vendedor, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand(@"
                INSERT INTO Vendedores (IdUsuario, Ingresos)
                VALUES (@IdUsuario, @Ingresos)");

            cmd.Parameters.AddWithValue("@IdUsuario", vendedor.IdUsuario);
            cmd.Parameters.AddWithValue("@Ingresos", vendedor.Ingresos);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idVendedor, SqlConnection connection)
        {
            using var cmd = new SqlCommand("DELETE FROM Vendedores WHERE IdVendedor = @IdVendedor");
            cmd.Parameters.AddWithValue("@IdVendedor", idVendedor);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
