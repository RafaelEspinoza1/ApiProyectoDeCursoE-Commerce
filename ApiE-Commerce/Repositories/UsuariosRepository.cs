using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
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

            cmd.Connection = conn;

            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return new Usuario
                {
                    IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                    IdRol = reader.GetInt32(reader.GetOrdinal("IdRol")),
                    PrimerNombre = reader.GetString(reader.GetOrdinal("PrimerNombre")),
                    SegundoNombre = reader.IsDBNull(reader.GetOrdinal("SegundoNombre")) ? null : reader.GetString(reader.GetOrdinal("SegundoNombre")),
                    PrimerApellido = reader.GetString(reader.GetOrdinal("PrimerApellido")),
                    SegundoApellido = reader.IsDBNull(reader.GetOrdinal("SegundoApellido")) ? null : reader.GetString(reader.GetOrdinal("SegundoApellido")),
                    Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                    Correo = reader.GetString(reader.GetOrdinal("Correo")),
                    Contraseña = reader.IsDBNull(reader.GetOrdinal("Contraseña"))
                        ? Array.Empty<byte>()
                        : (byte[])reader["Contraseña"]
                        };
            }

            return null;
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetAll()
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios";

            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetById(int id)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE IdUsuario = @Id";

            cmd.Parameters.AddWithValue("@Id", id);
            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByFirstName(string firstName)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE PrimerNombre = @FirstName";

            cmd.Parameters.AddWithValue("@FirstName", firstName);
            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetBySecondName(string secondName)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE SegundoNombre = @SecondName";

            cmd.Parameters.AddWithValue("@SecondName", secondName);
            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByFirstSurname(string firstSurname)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE PrimerApellido = @FirstSurname";

            cmd.Parameters.AddWithValue("@FirstSurname", firstSurname);
            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetBySecondSurname(string secondSurname)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE SegundoApellido = @SecondSurname";

            cmd.Parameters.AddWithValue("@SecondSurname", secondSurname);
            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByTelephone(string telephone)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE Telefono = @Telephone";

            cmd.Parameters.AddWithValue("@Telephone", telephone);
            return await Get(cmd);
        }

        // Filtro de búsqueda
        public async Task<Usuario?> GetByEmail(string email)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
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

            cmd.Connection = conn;

            return await cmd.ExecuteNonQueryAsync();
        }

        // Crea nuevo usuario
        public async Task<int> Create(UsuariosCreateDTO usuario)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                INSERT INTO Usuarios
                (IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña)
                VALUES
                (@IdRol, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Telefono, @Correo, @Contraseña)";

            cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
            cmd.Parameters.AddWithValue("@PrimerNombre", usuario.PrimerNombre);
            cmd.Parameters.AddWithValue("@SegundoNombre", usuario.SegundoNombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", usuario.SegundoApellido);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
            byte[] hashedPassword;
            using (var sha = SHA256.Create())
            {
                hashedPassword = sha.ComputeHash(Encoding.UTF8.GetBytes(usuario.Contraseña));
            }
            cmd.Parameters.AddWithValue("@Contraseña", hashedPassword);

            return await ExecuteNonQuery(cmd);
        }

        // Actualiza usuario
        public async Task<int> Update(UsuariosUpdateDTO usuario, int id)
        {
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

            cmd.Parameters.AddWithValue("@IdUsuario", id);
            cmd.Parameters.AddWithValue("@PrimerNombre", usuario.PrimerNombre);
            cmd.Parameters.AddWithValue("@SegundoNombre", usuario.SegundoNombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", usuario.SegundoApellido);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
            byte[] hashedPassword;
            using (var sha = SHA256.Create())
            {
                hashedPassword = sha.ComputeHash(Encoding.UTF8.GetBytes(usuario.Contraseña));
            }
            cmd.Parameters.AddWithValue("@Contraseña", hashedPassword);

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


