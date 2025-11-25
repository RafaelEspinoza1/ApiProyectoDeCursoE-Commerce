using ApiProyectoDeCursoE_Commerce.DAOs.Interfaces;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class CompradorDAO: ICompradorDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public CompradorDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<Comprador?> Get(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, transaction, reader => new Comprador
            {
                IdComprador = reader.GetInt32(reader.GetOrdinal("IdComprador")),
                IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"))
            });
        }

        public async Task<Comprador?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdComprador, IdUsuario
                FROM Compradores";

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<Comprador?> GetByIdAsync(int idUsuario, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdComprador, IdUsuario
                FROM Compradores
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", idUsuario);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<int> CreateAsync(CompradorRegisterDTO comprador, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Compradores (IdUsuario)
                VALUES (@IdUsuario)";

            cmd.Parameters.AddWithValue("@IdUsuario", comprador.IdUsuario);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idComprador, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Administradores WHERE IdAdministrador = @IdComprador";
            cmd.Parameters.AddWithValue("@IdComprador", idComprador);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
