using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class AdministradoresRepository
    {
        // Contexto de la base de datos
        private readonly ECommerceContext _context;

        // Contexto con la conexión a la base de datos
        public AdministradoresRepository(ECommerceContext context)
        {
            _context = context;
        }




        // Filtra la búsqueda a partir del comando
        // SOLO ACCESIBLE DESDE EL REPOSITORIO
        private async Task<Administrador?> Get(SqlCommand cmd)
        {
            using var conn = _context.GetConnection();
            await conn.OpenAsync();

            // Asigna la conexión al comando
            cmd.Connection = conn;

            // Ejecuta el comando
            using var reader = await cmd.ExecuteReaderAsync();

            // Si hay resultados, crea el objeto Usuario
            if (await reader.ReadAsync())
            {
                return new Administrador
                {
                    IdAdministrador = reader.GetInt32(reader.GetOrdinal("IdAdministrador")),
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"))
                };
            }

            return null;
        }




        // Filtro de búsqueda
        public async Task<Administrador?> GetAll()
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdAdministrador, IdUsuario
                FROM Administradores";

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Administrador?> GetByIdAdministrador(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdAdministrador, IdUsuario
                FROM Administradores
                WHERE IdAdministrador = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Administrador?> GetByIdUsuario(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdAdministrador, IdUsuario
                FROM Administradores
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            return await Get(cmd);
        }




        // Ejecuta comandos que no retornan datos
        // SOLO ACCESIBLE DESDE EL REPOSITORIO
        private async Task<int> ExecuteNonQuery(SqlCommand cmd)
        {
            using var conn = _context.GetConnection();
            await conn.OpenAsync();

            // Asigna la conexión al comando
            cmd.Connection = conn;

            // Ejecuta el comando y devuelve el número de filas afectadas
            return await cmd.ExecuteNonQueryAsync();
        }




        // Crea nuevo administrador
        public async Task<int> Create(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Administradores
                (IdUsuario)
                VALUES
                (@IdUsuario)";
            cmd.Parameters.AddWithValue("@IdUsuario", id);

            return await ExecuteNonQuery(cmd);
        }

        // Elimina administrador
        public async Task<int> Delete(int id)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Administradores WHERE IdAdministrador = @IdAdministrador";
            cmd.Parameters.AddWithValue("@IdAdministrador", id);

            return await ExecuteNonQuery(cmd);
        }
    }
}
