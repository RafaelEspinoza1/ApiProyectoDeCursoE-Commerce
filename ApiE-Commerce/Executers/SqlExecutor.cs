using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ApiProyectoDeCursoE_Commerce.Executor
{
    public class SqlExecutor: ISqlExecutor
    {
        // Contexto de la base de datos
        private readonly ECommerceContext _context;

        // Contexto con la conexión a la base de datos
        public SqlExecutor(ECommerceContext context)
        {
            _context = context;
        }

        // Ejecuta comandos que retornan un solo objeto
        public async Task<T?> ExecuteReaderAsync<T>(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction, Func<SqlDataReader, T> map)
        {
            cmd.Connection = connection;

            if (transaction != null)
                cmd.Transaction = transaction;

            using var reader = await cmd.ExecuteReaderAsync();

            // Lee el primer registro
            if (await reader.ReadAsync())
            {
                // Mapea el registro a un objeto del tipo T
                return map(reader);
            }

            return default;
        }

        // Ejecuta comandos que no retornan datos
        public async Task<int> ExecuteNonQueryAsync(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction)
        {
            cmd.Connection = connection;

            if (transaction != null)
                cmd.Transaction = transaction;

            return await cmd.ExecuteNonQueryAsync();
        }
    }
}
