using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class UsuariosRepository: IUsuariosRepository
    {
        // Contexto de la base de datos
        private readonly ECommerceContext _context;

        // Contexto con la conexión a la base de datos
        public UsuariosRepository(ECommerceContext context)
        {
            _context = context;
        }




        // Filtra la búsqueda a partir del comando
        // SOLO ACCESIBLE DESDE EL REPOSITORIO
        private async Task<Usuario?> Get(SqlCommand cmd)
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
                return new Usuario
                {
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                    PrimerNombre = reader.GetString(reader.GetOrdinal("PrimerNombre")),
                    SegundoNombre = reader.IsDBNull(reader.GetOrdinal("SegundoNombre")) ? null : reader.GetString(reader.GetOrdinal("SegundoNombre")),
                    PrimerApellido = reader.GetString(reader.GetOrdinal("PrimerApellido")),
                    SegundoApellido = reader.IsDBNull(reader.GetOrdinal("SegundoApellido")) ? null : reader.GetString(reader.GetOrdinal("SegundoApellido")),
                    Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                    Correo = reader.GetString(reader.GetOrdinal("Correo")),
                    Contraseña = reader.GetString(reader.GetOrdinal("Contraseña")),
                };
            }

            return null;
        }




        // Filtro de búsqueda
        public async Task<Usuario?> GetAll()
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios";

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetById(int id)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByFirstName(string firstName)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios
                WHERE PrimerNombre = @FirstName";
            cmd.Parameters.AddWithValue("@FirstName", firstName);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetBySecondName(string secondName)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios
                WHERE SegundoNombre = @SecondName";
            cmd.Parameters.AddWithValue("@SecondName", secondName);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByFirstSurname(string firstSurname)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios
                WHERE PrimerApellido = @FirstSurname";
            cmd.Parameters.AddWithValue("@FirstSurname", firstSurname);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetBySecondSurname(string secondSurname)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios
                WHERE SegundoApellido = @SecondSurname";
            cmd.Parameters.AddWithValue("@SecondSurname", secondSurname);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByTelephone(string telephone)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios
                WHERE Telefono = @Telephone";
            cmd.Parameters.AddWithValue("@Telephone", telephone);

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByEmail(string email)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña, FechaRegistro
                FROM Usuarios
                WHERE Correo = @Email";
            cmd.Parameters.AddWithValue("@Email", email);

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




        // Crea nuevo usuario
        public async Task<int> Create(Usuario usuario)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT IdUsuario, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña
                VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Telefono, @Correo, @Contraseña)";

            cmd.Parameters.AddWithValue("@PrimerNombre", usuario.PrimerNombre);
            cmd.Parameters.AddWithValue("@SegundoNombre", usuario.SegundoNombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", usuario.SegundoApellido);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
            cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

            return await ExecuteNonQuery(cmd);
        }

        // Actualiza usuario
        public async Task<int> Update(Usuario usuario)
        {
            // Crea el comando SQL
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                UPDATE Usuarios
                SET PrimerNombre = @PrimerNombre,
                    SegundoNombre = @SegundoNombre,
                    PrimerApellido = @PrimerApellido,
                    SegundoApellido = @SegundoApellido,
                    Telefono = @Telefono,
                    Correo = @Correo,
                    Contraseña = @Contraseña
                WHERE IdUsuario = @IdUsuario";
            
            cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
            cmd.Parameters.AddWithValue("@PrimerNombre", usuario.PrimerNombre);
            cmd.Parameters.AddWithValue("@SegundoNombre", usuario.SegundoNombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", usuario.SegundoApellido);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
            cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

            return await ExecuteNonQuery(cmd);
        }

        // Elimina usuario
        public async Task<int> Delete(int id)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
            cmd.Parameters.AddWithValue("@IdUsuario", id);

            return await ExecuteNonQuery(cmd);
        }
    }
}
