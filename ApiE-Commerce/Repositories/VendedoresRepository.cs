using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class VendedoresRepository : IVendedoresRepository
    {
        private readonly ECommerceContext _context;

        public VendedoresRepository(ECommerceContext context)
        {
            _context = context;
        }

        // Método privado para ejecutar consultas que retornan un vendedor
        private async Task<Vendedor?> Get(SqlCommand cmd)
        {
            using var conn = _context.GetConnection();
            await conn.OpenAsync();
            cmd.Connection = conn;

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Vendedor
                {
                    IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                    Ingresos = reader.GetDecimal(reader.GetOrdinal("Ingresos"))
                };
            }
            return null;
        }

        // Obtener todos los vendedores
        public async Task<IEnumerable<Vendedor>> GetAll()
        {
            using var cmd = new SqlCommand("SELECT IdVendedor, IdUsuario, Ingresos FROM Vendedores");
            using var conn = _context.GetConnection();
            await conn.OpenAsync();
            cmd.Connection = conn;

            var vendedores = new List<Vendedor>();
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                vendedores.Add(new Vendedor
                {
                    IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                    Ingresos = reader.GetDecimal(reader.GetOrdinal("Ingresos"))
                });
            }
            return vendedores;
        }

        // Obtener vendedor por Id
        public async Task<Vendedor?> GetById(int id)
        {
            using var cmd = new SqlCommand("SELECT IdVendedor, IdUsuario, Ingresos FROM Vendedores WHERE IdVendedor = @Id");
            cmd.Parameters.AddWithValue("@Id", id);
            return await Get(cmd);
        }

        // Ejecutar comandos que no retornan datos
        private async Task<int> ExecuteNonQuery(SqlCommand cmd)
        {
            using var conn = _context.GetConnection();
            await conn.OpenAsync();
            cmd.Connection = conn;
            return await cmd.ExecuteNonQueryAsync();
        }

        // Crear nuevo vendedor
        public async Task<int> Create(int idUsuario)
        {
            using var cmd = new SqlCommand(@"
                INSERT INTO Vendedores (IdUsuario)
                VALUES (@IdUsuario)");
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            return await ExecuteNonQuery(cmd);
        }

        // Actualizar ingresos
        public async Task<int> UpdateIngresos(int idVendedor, decimal ingresos)
        {
            using var cmd = new SqlCommand(@"
                UPDATE Vendedores
                SET Ingresos = @Ingresos
                WHERE IdVendedor = @IdVendedor");
            cmd.Parameters.AddWithValue("@IdVendedor", idVendedor);
            cmd.Parameters.AddWithValue("@Ingresos", ingresos);
            return await ExecuteNonQuery(cmd);
        }

        // Eliminar vendedor
        public async Task<int> Delete(int id)
        {
            using var cmd = new SqlCommand("DELETE FROM Vendedores WHERE IdVendedor = @IdVendedor");
            cmd.Parameters.AddWithValue("@IdVendedor", id);
            return await ExecuteNonQuery(cmd);
        }
    }
}
