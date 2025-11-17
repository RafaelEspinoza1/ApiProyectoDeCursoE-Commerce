using ApiProyectoDeCursoE_Commerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace ApiProyectoDeCursoE_Commerce.Data
{
    public class ECommerceContext : DbContext
    {
        private readonly string _connectionString;

        public ECommerceContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}