using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class CompradoresRepository : ICompradoresRepository
    {
        // Contexto de la base de datos
        private readonly ECommerceContext _context;

        // Contexto con la conexión a la base de datos
        public CompradoresRepository(ECommerceContext context)
        {
            _context = context;
        }




        // Filtra la búsqueda a partir del comando
        // SOLO ACCESIBLE DESDE EL REPOSITORIO
        private async Task<Comprador?> Get(SqlCommand cmd)
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
                return new Comprador
                {
                    IdComprador = reader.GetInt32(reader.GetOrdinal("IdComprador")),
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"))
                };
            }

            return null;
        }




        // Filtro de búsqueda
        public async Task<Comprador?> GetAll()
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdComprador, IdUsuario
                FROM Compradores";

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Comprador?> GetByIdComprador(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdComprador, IdUsuario
                FROM Compradores
                WHERE IdComprador = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Comprador?> GetByIdUsuario(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdComprador, IdUsuario
                FROM Compradores
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




        // Crea nuevo comprador
        public async Task<int> Create(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Compradores
                (IdUsuario)
                VALUES
                (@IdUsuario)";
            cmd.Parameters.AddWithValue("@IdUsuario", id);

            return await ExecuteNonQuery(cmd);
        }

        // Elimina comprador
        public async Task<int> Delete(int id)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Compradores WHERE IdComprador = @IdComprador";
            cmd.Parameters.AddWithValue("@IdComprador", id);

            return await ExecuteNonQuery(cmd);
        }
    }
}

