using ApiProyectoDeCursoE_Commerce.DAO;
using ApiProyectoDeCursoE_Commerce.DAOs;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UsuarioDAO _usuarioDAO;

        private readonly AdminDAO _adminDAO;
        private readonly VendedorDAO _vendedorDAO;
        private readonly CompradorDAO _compradorDAO;

        private readonly RefreshTokenDAO _refreshTokenDAO;

        public AuthRepository(
            UsuarioDAO usuarioDAO,
            AdminDAO adminDAO,
            VendedorDAO vendedorDAO,
            CompradorDAO compradorDAO,
            RefreshTokenDAO refreshTokenDAO)
        {
            _usuarioDAO = usuarioDAO;
            _adminDAO = adminDAO;
            _vendedorDAO = vendedorDAO;
            _compradorDAO = compradorDAO;
            _refreshTokenDAO = refreshTokenDAO;
        }


        // =========================================================================================
        // -----------------------------------------------------------------------------------------
        // =========================================================================================

        public async Task<Usuario?> LoginUser(string correo, string contraseña, SqlConnection connection)
        {
            var usuarioEnDb = await _usuarioDAO.GetByEmailAsync(correo, connection);
            if (usuarioEnDb == null) return null;

            // Hash de la contraseña ingresada
            byte[] passwordIngresadaHash = HashPassword(contraseña);

            // Comparar con la contraseña almacenada
            byte[] hashAlmacenado = Convert.FromBase64String(usuarioEnDb.Contraseña.Trim());
            bool contraseñaCorrecta = CryptographicOperations.FixedTimeEquals(hashAlmacenado, passwordIngresadaHash);

            //Console.WriteLine($"Hash DB  : '{Convert.ToBase64String(hashAlmacenado)}'");
            //Console.WriteLine($"Hash Ing : '{Convert.ToBase64String(passwordIngresadaHash)}'");
            //Console.WriteLine($"Contraseña correcta? {contraseñaCorrecta}");


            if (!contraseñaCorrecta) return null;

            // Validar rol
            string rol = ((RolesEnum)usuarioEnDb.IdRol).ToString();
            bool existe = rol switch
            {
                "Administrador" => await _adminDAO.GetByIdAsync(usuarioEnDb.IdUsuario, connection) != null,
                "Vendedor" => await _vendedorDAO.GetByIdAsync(usuarioEnDb.IdUsuario, connection) != null,
                "Comprador" => await _compradorDAO.GetByIdAsync(usuarioEnDb.IdUsuario, connection) != null,
                _ => false
            };

            return existe ? usuarioEnDb : null;
        }


        public async Task<Usuario?> LoginUserById(int idUsuario, SqlConnection connection)
        {
            var usuarioEnDb = await _usuarioDAO.GetByIdAsync(idUsuario, connection);
            if (usuarioEnDb == null) return null;

            // Validar rol
            string rol = ((RolesEnum)usuarioEnDb.IdRol).ToString();
            bool existe = rol switch
            {
                "Administrador" => await _adminDAO.GetByIdAsync(usuarioEnDb.IdUsuario, connection) != null,
                "Vendedor" => await _vendedorDAO.GetByIdAsync(usuarioEnDb.IdUsuario, connection) != null,
                "Comprador" => await _compradorDAO.GetByIdAsync(usuarioEnDb.IdUsuario, connection) != null,
                _ => false
            };

            return existe ? usuarioEnDb : null;
        }


        // =========================================================================================
        // -----------------------------------------------------------------------------------------
        // =========================================================================================




        // ============================================================
        // USUARIO
        // ============================================================
        public async Task<int> RegisterUser(UsuariosCreateDTO usuario, SqlConnection connection, SqlTransaction? transaction)
        {
            // Crear usuario
            var idUsuario = await _usuarioDAO.CreateAsync(usuario, connection, transaction);

            return idUsuario;
        }


        // ============================================================
        // ADMINISTRADOR
        // ============================================================
        public async Task<bool?> RegisterAdminAsync(AdministradorRegisterDTO admin, SqlConnection connection, SqlTransaction? transaction)
        {
            var filasAfectadas = await _adminDAO.CreateAsync(admin, connection, transaction);
            if (filasAfectadas == 0) return false;

            return true;
        }


        // ============================================================
        // VENDEDOR
        // ============================================================
        public async Task<bool?> RegisterSellerAsync(VendedorRegisterDTO vendedor, SqlConnection connection, SqlTransaction? transaction)
        {
            var filasAfectadas = await _vendedorDAO.CreateAsync(vendedor, connection, transaction);
            if (filasAfectadas == 0) return false;

            return true;
        }


        // ============================================================
        // COMPRADOR
        // ============================================================
        public async Task<bool?> RegisterBuyerAsync(CompradorRegisterDTO comprador, SqlConnection connection, SqlTransaction? transaction)
        {
            var filasAfectadas = await _compradorDAO.CreateAsync(comprador, connection, transaction);
            if (filasAfectadas == 0) return false;

            return true;
        }


        // ============================================================
        // REFRESH TOKEN
        // ============================================================
        public async Task<bool?> CreateRefreshTokenAsync(RefreshTokenCreateDTO refreshToken, SqlConnection connection, SqlTransaction? transaction)
        {
            var filasAfectadas = await _refreshTokenDAO.CreateAsync(refreshToken, connection, transaction);
            if (filasAfectadas == 0) return false;

            return true;
        }


        private byte[] HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                return sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
