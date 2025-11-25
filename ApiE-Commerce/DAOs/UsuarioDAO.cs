using ApiProyectoDeCursoE_Commerce.DAOs.Interfaces;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Executor;
using ApiProyectoDeCursoE_Commerce.Models;
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

        public async Task<Usuario?> Get(SqlCommand cmd, SqlConnection connection, SqlTransaction? transaction)
        {
            return await _sqlExecutor.ExecuteReaderAsync(cmd, connection, transaction, reader => new Usuario
            {
                IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario")),
                IdRol = reader.GetInt32(reader.GetOrdinal("IdRol")),
                Correo = reader.GetString(reader.GetOrdinal("Correo")),
                PrimerNombre = reader.GetString(reader.GetOrdinal("PrimerNombre")),
                SegundoNombre = reader.GetString(reader.GetOrdinal("SegundoNombre")),
                PrimerApellido = reader.GetString(reader.GetOrdinal("PrimerApellido")),
                SegundoApellido = reader.GetString(reader.GetOrdinal("SegundoApellido")),
                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                Contraseña = (byte[])reader["Contraseña"]
            });
        }

        public async Task<Usuario?> GetAllAsync(SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios";

            return await Get(cmd, connection, transaction);
        }

        public async Task<Usuario?> GetByIdAsync(int idUsuario, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE IdUsuario = @Id";
            cmd.Parameters.AddWithValue("@Id", idUsuario);

            return await Get(cmd, connection, transaction);
        }

        public async Task<Usuario?> GetByFirstNameAsync(string primerNombre, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE PrimerNombre = @primerNombre";

            cmd.Parameters.AddWithValue("@primerNombre", primerNombre);

            return await Get(cmd, connection, transaction);
        }

        public async Task<Usuario?> GetBySecondNameAsync(string segundoNombre, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE SegundoNombre = @segundoNombre";

            cmd.Parameters.AddWithValue("@segundoNombre", segundoNombre);

            return await Get(cmd, connection, transaction);
        }

        public async Task<Usuario?> GetByFirstSurnameAsync(string primerApellido, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE PrimerApellido = @primerApellido";

            cmd.Parameters.AddWithValue("@primerApellido", primerApellido);

            return await Get(cmd, connection, transaction);
        }

        public async Task<Usuario?> GetBySecondSurnameAsync(string segundoApellido, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE SegundoApellido = @segundoApellido";

            cmd.Parameters.AddWithValue("@segundoApellido", segundoApellido);

            return await Get(cmd, connection, transaction);
        }

        public async Task<Usuario?> GetByTelephoneAsync(string telefono, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE Telefono = @telefono";

            cmd.Parameters.AddWithValue("@telefono", telefono);

            return await Get(cmd, connection, transaction);
        }

        public async Task<Usuario?> GetByEmailAsync(string correo, SqlConnection connection, SqlTransaction? transaction)
        {
            using var cmd = new SqlCommand();
            cmd.CommandText = @"
                SELECT
                    IdUsuario, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                    Telefono, Correo, Contraseña
                FROM Usuarios
                WHERE Correo = @correo";

            cmd.Parameters.AddWithValue("@correo", correo);

            return await Get(cmd, connection, transaction);
        }


        public async Task<int> CreateAsync(UsuariosCreateDTO usuario, SqlConnection connection, SqlTransaction? transaction)
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

            return await _sqlExecutor.ExecuteNonQueryAsync(cmd,connection, transaction);
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
