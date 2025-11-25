using ApiProyectoDeCursoE_Commerce.DAOs.Interfaces;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class RefreshTokenDAO: IRefreshTokenDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public RefreshTokenDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<RefreshToken?> Get(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, transaction, reader => new RefreshToken
            {
                IdRefreshToken = reader.GetInt32(reader.GetOrdinal("IdRefreshToken")),
                IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                Token = reader.GetGuid(reader.GetOrdinal("Token")),
                FechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                FechaExpiracion = reader.GetDateTime(reader.GetOrdinal("FechaExpiracion")),
                Revoked = reader.GetBoolean(reader.GetOrdinal("Revoked"))
            });
        }

        public async Task<RefreshToken?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdRefreshToken, IdUsuario, Token, FechaCreacion, FechaExpiracion, Revoked
                FROM RefreshToken";

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<RefreshToken?> GetAllActiveAsync(SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdRefreshToken, IdUsuario, Token, FechaCreacion, FechaExpiracion, Revoked
                FROM RefreshToken
                WHERE Token = 0";

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<RefreshToken?> GetAllRevokedAsync(SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdRefreshToken, IdUsuario, Token, FechaCreacion, FechaExpiracion, Revoked
                FROM RefreshToken
                WHERE Token = 1";

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<RefreshToken?> GetByIdAsync(int idUsuario, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdRefreshToken, IdUsuario, Token, FechaCreacion, FechaExpiracion, Revoked
                FROM RefreshToken
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", idUsuario);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<int> CreateAsync(RefreshTokenCreateDTO refreshToken, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO RefreshToken
                (IdUsuario, Token, FechaCreacion, FechaExpiracion, Revoked)
                VALUES (@IdUsuario, @Token, @FechaCreacion, @FechaExpiracion, @Revoked)";

            cmd.Parameters.AddWithValue("@IdUsuario", refreshToken.IdUsuario);
            cmd.Parameters.AddWithValue("@Token", refreshToken.Token);
            cmd.Parameters.AddWithValue("@FechaCreacion", refreshToken.FechaCreacion);
            cmd.Parameters.AddWithValue("@FechaExpiracion", refreshToken.FechaExpiracion);
            cmd.Parameters.AddWithValue("@Revoked", refreshToken.Revoked);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idUsuario, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM RefreshToken WHERE idUsuario = @IdUsuario";
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
