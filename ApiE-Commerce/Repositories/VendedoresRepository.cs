using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedoresDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class VendedoresRepository: IVendedoresRepository
    {
        // Contexto de la base de datos
        private readonly ECommerceContext _context;

        // Contexto con la conexión a la base de datos
        public VendedoresRepository(ECommerceContext context)
        {
            _context = context;
        }




        // Filtra la búsqueda a partir del comando
        // SOLO ACCESIBLE DESDE EL REPOSITORIO
        private async Task<Vendedor?> Get(SqlCommand cmd)
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
                return new Vendedor
                {
                    IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                    NombreNegocio = reader.GetString(reader.GetOrdinal("NombreNegocio")),
                    DescripcionNegocio = reader.GetString(reader.GetOrdinal("DescripcionNegocio")),
                    LogoNegocio = reader.GetString(reader.GetOrdinal("LogoNegocio")),
                    EsContribuyente = reader.GetBoolean(reader.GetOrdinal("EsContribuyente")),
                };
            }

            return null;
        }




        // Filtro de búsqueda
        public async Task<Vendedor?> GetAll()
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, NombreNegocio, DescripcionNegocio, LogoNegocio, EsContribuyente
                FROM Vendedores";

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Vendedor?> GetById(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, NombreNegocio, DescripcionNegocio, LogoNegocio, EsContribuyente
                FROM Usuarios
                WHERE IdVendedor = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Vendedor?> GetByBusinessName(string businessName)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, NombreNegocio, DescripcionNegocio, LogoNefocio EsContribuyente
                FROM Vendedores
                WHERE NombreNegocio = @BusinessName";
            cmd.Parameters.AddWithValue("@BusinessName", businessName);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Vendedor?> GetIfIsContributor(bool isContributor)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdVendedor, IdUsuario, NombreNegocio, DescripcionNegocio, LogoNefocio EsContribuyente
                FROM Vendedores
                WHERE EsContribuyente = @IsContributor";
            cmd.Parameters.AddWithValue("@IsContributor", isContributor);

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




        // Crea nuevo vendedor
        public async Task<int> Create(UsuariosCreateDTO usuario)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Vendedores
                (IdUsuario, NombreNegocio, DescripcionNegocio, LogoNegocio, EsContribuyente)
                VALUES
                (@IdUsuario, @NombreNegocio, @DescripcionNegocio, @LogoNegocio, @EsContribuyente)";
            cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
            cmd.Parameters.AddWithValue("@NombreNegocio", usuario.NombreNegocio);
            cmd.Parameters.AddWithValue("@DescripcionNegocio", usuario.DescripcionNegocio);
            cmd.Parameters.AddWithValue("@LogoNegocio", usuario.LogoNegocio);
            cmd.Parameters.AddWithValue("@EsContribuyente", usuario.EsContribuyente);

            return await ExecuteNonQuery(cmd);
        }

        // Actualiza vendedor
        public async Task<int> Update(VendedoresUpdateDTO vendedor, int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                UPDATE Vendedores
                SET
                IdUsuario = @IdUsuario,
                NombreNegocio = @NombreNegocio,
                DescripcionNegocio = @DescripcionNegocio,
                LogoNegocio = @LogoNegocio,
                EsContribuyente = @EsContribuyente
                WHERE IdVendedor = @IdVendedor";

            cmd.Parameters.AddWithValue("@IdVendedor", vendedor.IdVendedor);
            cmd.Parameters.AddWithValue("@IdUsuario", vendedor.IdUsuario);
            cmd.Parameters.AddWithValue("@NombreNegocio", vendedor.NombreNegocio);
            cmd.Parameters.AddWithValue("@DescripcionNegocio", vendedor.DescripcionNegocio);
            cmd.Parameters.AddWithValue("@LogoNegocio", vendedor.LogoNegocio);
            cmd.Parameters.AddWithValue("@EsContribuyente", vendedor.EsContribuyente);

            return await ExecuteNonQuery(cmd);
        }

        // Elimina vendedor
        public async Task<int> Delete(int id)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Vendedires WHERE IdVendedor = @IdVendedor";
            cmd.Parameters.AddWithValue("@IdVendedor", id);

            return await ExecuteNonQuery(cmd);
        }
    }
}
