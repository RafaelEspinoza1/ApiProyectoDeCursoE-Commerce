using ApiProyectoDeCursoE_Commerce.DAO.Interfaces;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.DAO
{
    public class AdminDAO: IAdminDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public AdminDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        private async Task<Administrador?> Get(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction)
        {
            // Llama al SqlExecutor para ejecutar y mapear
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, transaction, reader => new Administrador
            {
                IdAdministrador = reader.GetInt32(reader.GetOrdinal("IdAdministrador")),
                IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"))
            });
        }

        public async Task<Administrador?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdAdministrador, IdUsuario
                FROM Administradores";

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<Administrador?> GetByIdAsync(int idUsuario, SqlConnection connection, SqlTransaction? transaction)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdAdministrador, IdUsuario
                FROM Administradores
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", idUsuario);

            // Llama al método Get para ejecutar y mapear
            return await Get(cmd, connection, transaction);
        }

        public async Task<int> CreateAsync(AdministradorRegisterDTO admin, SqlConnection connection, SqlTransaction? transaction)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Administradores
                (IdUsuario)
                VALUES
                (@IdUsuario)";
            cmd.Parameters.AddWithValue("@IdUsuario", admin.IdUsuario);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction);
        }

        public async Task<int> DeleteAsync(int idAdmin, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Administradores WHERE IdAdministrador = @IdAdministrador";
            cmd.Parameters.AddWithValue("@IdAdministrador", idAdmin);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
