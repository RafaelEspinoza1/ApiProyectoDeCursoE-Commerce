using ApiProyectoDeCursoE_Commerce.DAOs.Interfaces;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class VendedorDAO : IVendedorDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public VendedorDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<Vendedor?> Get(SqlCommand cmd, SqlConnection connection)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, reader => new Vendedor
            {
                IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                NombreNegocio = reader.IsDBNull(reader.GetOrdinal("NombreNegocio")) ? null : reader.GetString(reader.GetOrdinal("NombreNegocio")),
                LogoNegocio = reader.IsDBNull(reader.GetOrdinal("LogoNegocio")) ? null : reader.GetString(reader.GetOrdinal("LogoNegocio")),
                DescripcionNegocio = reader.IsDBNull(reader.GetOrdinal("DescripcionNegocio")) ? null : reader.GetString(reader.GetOrdinal("DescripcionNegocio")),
                EsContribuyente = reader.GetBoolean(reader.GetOrdinal("EsContribuyente"))
            });
        }

        public async Task<Vendedor?> GetAllAsync(SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, NombreNegocio, LogoNegocio, DescripcionNegocio, EsContribuyente
                FROM Vendedores";

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection);
        }

        public async Task<Vendedor?> GetByIdAsync(int idUsuario, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, NombreNegocio, LogoNegocio, DescripcionNegocio, EsContribuyente
                FROM Vendedores
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", idUsuario);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection);
        }

        public async Task<int> CreateAsync(VendedorRegisterDTO vendedor, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand(@"
                INSERT INTO Vendedores (IdUsuario, NombreNegocio, LogoNegocio, DescripcionNegocio, EsContribuyente)
                VALUES (@IdUsuario, @NombreNegocio, @LogoNegocio, @DescripcionNegocio, @EsContribuyente)");

            cmd.Parameters.AddWithValue("@IdUsuario", vendedor.IdUsuario);
            cmd.Parameters.AddWithValue("@NombreNegocio", vendedor.NombreNegocio);
            cmd.Parameters.AddWithValue("@LogoNegocio", vendedor.LogoNegocio ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DescripcionNegocio", vendedor.DescripcionNegocio ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@EsContribuyente", vendedor.EsContribuyente);

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

