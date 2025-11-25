using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Executor
{
    public interface ISqlExecutor
    {
        Task<T?> ExecuteReaderAsync<T>(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction, Func<SqlDataReader, T> map);
        Task<int> ExecuteNonQueryAsync(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction);
    }
}
