using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly ECommerceContext _context;
        private readonly SqlExecutor _sqlExecutor;

        public RefreshTokenRepository(ECommerceContext context, SqlExecutor sqlExecutor)
        {
            _context = context;
            _sqlExecutor = sqlExecutor;
        }

        // -------------------------------------------
        // MÉTODO PRIVADO PARA MAPEAR UN SOLO REGISTRO
        // -------------------------------------------
        private async Task<RefreshToken?> Get(SqlCommand cmd)
        {
            using var conn = _context.GetConnection();
            await conn.OpenAsync();

            cmd.Connection = conn;

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new RefreshToken
                {
                    IdRefreshToken = reader.GetInt32(reader.GetOrdinal("IdRefreshToken")),
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                    Token = reader.GetGuid(reader.GetOrdinal("Token")),
                    FechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                    FechaExpiracion = reader.GetDateTime(reader.GetOrdinal("FechaExpiracion")),
                    Revoked = reader.GetBoolean(reader.GetOrdinal("Revoked"))
                };
            }

            return null;
        }

        // -------------------------------------------
        // MÉTODO PRIVADO PARA INSERT / UPDATE / DELETE
        // -------------------------------------------
        private async Task<int> ExecuteNonQuery(SqlCommand cmd)
        {
            using var conn = _context.GetConnection();
            await conn.OpenAsync();

            cmd.Connection = conn;
            return await cmd.ExecuteNonQueryAsync();
        }

        // -------------------------------------------
        // OBTENER REFRESH TOKEN ACTIVO
        // -------------------------------------------
        public async Task<RefreshToken?> GetActiveToken(int idUsuario, Guid token)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT IdRefreshToken, IdUsuario, Token, FechaCreacion, FechaExpiracion, Revoked
                FROM RefreshToken
                WHERE IdUsuario = @IdUsuario
                AND Token = @Token
                AND Revoked = 0";

            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            cmd.Parameters.Add("@Token", System.Data.SqlDbType.UniqueIdentifier).Value = token;


            return await Get(cmd);
        }

        public async Task<RefreshToken?> GetActiveTokenByUser(int idUsuario)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT TOP 1 IdRefreshToken, IdUsuario, Token, FechaCreacion, FechaExpiracion, Revoked
                FROM RefreshToken
                WHERE IdUsuario = @IdUsuario AND Revoked = 0
                ORDER BY FechaCreacion DESC";
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

            return await Get(cmd);
        }

        // -------------------------------------------
        // CREAR NUEVO REFRESH TOKEN
        // -------------------------------------------
        public async Task<int> Create(RefreshToken token, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO RefreshToken (IdUsuario, Token, FechaCreacion, FechaExpiracion)
                VALUES (@IdUsuario, @Token, @FechaCreacion, @FechaExpiracion)";

            cmd.Parameters.AddWithValue("@IdUsuario", token.IdUsuario);
            cmd.Parameters.AddWithValue("@Token", token.Token);
            cmd.Parameters.AddWithValue("@FechaCreacion", token.FechaCreacion);
            cmd.Parameters.AddWithValue("@FechaExpiracion", token.FechaExpiracion);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        // -------------------------------------------
        // ACTUALIZAR REFRESH TOKEN
        // (renovar expiración o revocar)
        // -------------------------------------------
        public async Task<int> Update(RefreshToken token)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                UPDATE RefreshToken
                SET FechaExpiracion = @FechaExpiracion,
                    Revoked = @Revoked
                WHERE IdRefreshToken = @IdRefreshToken";

            cmd.Parameters.AddWithValue("@FechaExpiracion", token.FechaExpiracion);
            cmd.Parameters.AddWithValue("@Revoked", token.Revoked);
            cmd.Parameters.AddWithValue("@IdRefreshToken", token.IdRefreshToken);

            return await ExecuteNonQuery(cmd);
        }
    }
}

