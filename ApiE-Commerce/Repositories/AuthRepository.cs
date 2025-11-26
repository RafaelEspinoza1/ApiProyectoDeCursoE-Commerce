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

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UsuarioDAO _usuarioDAO;

        private readonly AdminDAO _adminDAO;
        private readonly VendedorDAO _vendedorDAO;
        private readonly CompradorDAO _compradorDAO;

        private readonly RefreshTokenDAO _refreshTokenDAO;

        private readonly UsuariosRepository _usuariosRepository;
        private readonly VendedoresRepository _vendedoresRepository;
        private readonly CompradoresRepository _compradoresRepository;
        private readonly AdministradoresRepository _administradoresRepository;

        public AuthRepository(
            UsuarioDAO usuarioDAO,
            AdminDAO adminDAO,
            VendedorDAO vendedorDAO,
            CompradorDAO compradorDAO,
            RefreshTokenDAO refreshTokenDAO,
            UsuariosRepository usuariosRepository,
            VendedoresRepository vendedoresRepository,
            CompradoresRepository compradoresRepository,
            AdministradoresRepository administradoresRepository)
        {
            _usuarioDAO = usuarioDAO;
            _adminDAO = adminDAO;
            _vendedorDAO = vendedorDAO;
            _compradorDAO = compradorDAO;
            _refreshTokenDAO = refreshTokenDAO;
            _usuariosRepository = usuariosRepository;
            _vendedoresRepository = vendedoresRepository;
            _compradoresRepository = compradoresRepository;
            _administradoresRepository = administradoresRepository;
        }


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
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                return sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        //public async Task<Usuario?> LoginUser(string correo, string contraseña)
        //{
        //    var usuarioEnDb = await _usuariosRepository.GetByEmail(correo);
        //    if (usuarioEnDb == null) return null;

        //    // Hash de la contraseña ingresada
        //    byte[] passwordIngresadaHash = HashPassword(contraseña);

        //    // Comparar con la contraseña almacenada
        //    bool contraseñaCorrecta = usuarioEnDb.Contraseña.SequenceEqual(passwordIngresadaHash);
        //    if (!contraseñaCorrecta) return null;

        //    // Validar rol
        //    string rol = ((RolesEnum)usuarioEnDb.IdRol).ToString();
        //    bool existe = rol switch
        //    {
        //        "Administrador" => await _administradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
        //        "Vendedor" => await _vendedoresRepository.GetById(usuarioEnDb.IdUsuario) != null,
        //        "Comprador" => await _compradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
        //        _ => false
        //    };

        //    return existe ? usuarioEnDb : null;
        //}


        public async Task<Usuario?> LoginUserById(int idUsuario)
        {
            var usuarioEnDb = await _usuariosRepository.GetById(idUsuario);
            if (usuarioEnDb == null) return null;

            string rol = ((RolesEnum)usuarioEnDb.IdRol).ToString();
            bool existe = rol switch
            {
                "Administrador" => await _administradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
                "Vendedor" => await _vendedoresRepository.GetById(usuarioEnDb.IdUsuario) != null,
                "Comprador" => await _compradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
                _ => false
            };

            return existe ? usuarioEnDb : null;
        }
    }
}
