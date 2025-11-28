using ApiProyectoDeCursoE_Commerce.DAOs.Interfaces;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.Data.SqlClient;
using NuGet.Common;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ApiProyectoDeCursoE_Commerce.DAOs
{
    public class UsuarioDAO: IUsuarioDAO
    {
        private readonly SqlExecutor _sqlExecutor;

        public UsuarioDAO(SqlExecutor sqlExecutor)
        {
            _sqlExecutor = sqlExecutor;
        }

        public async Task<Usuario?> Get(SqlCommand cmd, SqlConnection connection)
        {
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, reader => new Usuario
            {
                IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                IdRol = reader.GetInt32(reader.GetOrdinal("IdRol")),
                Correo = reader.GetString(reader.GetOrdinal("Correo")),
                PrimerNombre = reader.GetString(reader.GetOrdinal("PrimerNombre")),
                SegundoNombre = reader.GetString(reader.GetOrdinal("SegundoNombre")),
                PrimerApellido = reader.GetString(reader.GetOrdinal("PrimerApellido")),
                SegundoApellido = reader.GetString(reader.GetOrdinal("SegundoApellido")),
                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                Contraseña = reader.GetString(reader.GetOrdinal("Contraseña"))
            });
        }

        public async Task<Usuario?> GetAllAsync(SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios";

            return await Get(cmd, connection);
        }

        public async Task<Usuario?> GetByIdAsync(int idUsuario, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", idUsuario);

            return await Get(cmd, connection);
        }

        public async Task<Usuario?> GetByFirstNameAsync(string primerNombre, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE PrimerNombre = @primerNombre";

            cmd.Parameters.AddWithValue("@primerNombre", primerNombre);

            return await Get(cmd, connection);
        }

        public async Task<Usuario?> GetBySecondNameAsync(string segundoNombre, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE SegundoNombre = @segundoNombre";

            cmd.Parameters.AddWithValue("@segundoNombre", segundoNombre);

            return await Get(cmd, connection);
        }

        public async Task<Usuario?> GetByFirstSurnameAsync(string primerApellido, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE PrimerApellido = @primerApellido";

            cmd.Parameters.AddWithValue("@primerApellido", primerApellido);

            return await Get(cmd, connection);
        }

        public async Task<Usuario?> GetBySecondSurnameAsync(string segundoApellido, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE SegundoApellido = @segundoApellido";

            cmd.Parameters.AddWithValue("@segundoApellido", segundoApellido);

            return await Get(cmd, connection);
        }

        public async Task<Usuario?> GetByTelephoneAsync(string telefono, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE Telefono = @telefono";

            cmd.Parameters.AddWithValue("@telefono", telefono);

            return await Get(cmd, connection);
        }

        public async Task<Usuario?> GetByEmailAsync(string correo, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE Correo = @correo";

            cmd.Parameters.AddWithValue("@correo", correo);

            return await Get(cmd, connection);
        }


        public async Task<int> CreateAsync(UsuariosCreateDTO usuario, SqlConnection connection, SqlTransaction? transaction)
        {
            try
            {
                using var cmd = new SqlCommand();
                cmd.CommandText = @"
                    INSERT INTO Usuarios
                    (IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, Correo, Contraseña)
                    OUTPUT INSERTED.IdUsuario
                    VALUES
                    (@IdRol, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Telefono, @Correo, @Contraseña)";

                cmd.Connection = connection;
                if (transaction != null)
                    cmd.Transaction = transaction;

                cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
                cmd.Parameters.AddWithValue("@PrimerNombre", usuario.PrimerNombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", (object?)usuario.SegundoNombre ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", (object?)usuario.SegundoApellido ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);

                byte[] hashedPassword;
                using (var sha = SHA256.Create())
                {
                    hashedPassword = sha.ComputeHash(Encoding.UTF8.GetBytes(usuario.Contraseña));
                }
                string hashedPasswordBase64 = Convert.ToBase64String(hashedPassword);
                cmd.Parameters.AddWithValue("@Contraseña", hashedPasswordBase64);

                var result = await cmd.ExecuteScalarAsync();
                if (result == null)
                    return 0;

                return Convert.ToInt32(result);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                // Violación de UNIQUE constraint
                throw new InvalidOperationException("El correo ya está siendo utilizado.");
            }
        }


        public async Task<int> UpdateAsync(int idUsuario, UsuariosUpdateDTO usuario, SqlConnection connection)
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

            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
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

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }

        public async Task<int> DeleteAsync(int idUsuario, SqlConnection connection)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd, connection, transaction: null);
        }
    }
}
