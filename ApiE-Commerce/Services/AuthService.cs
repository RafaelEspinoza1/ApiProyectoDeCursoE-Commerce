using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Repositories;
using System.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Services
{
    public class AuthService : IAuthService
    {
        private readonly ECommerceContext _context;

        private readonly AuthRepository _authRepository;
        private readonly RefreshTokenRepository _refreshRepository;
        private readonly JwtService _jwtService;

        public AuthService(
            ECommerceContext context,
            AuthRepository authRepository,
            RefreshTokenRepository resfreshRepository,
            JwtService jwtService)
        {
            _context = context;
            _authRepository = authRepository;
            _refreshRepository = resfreshRepository;
            _jwtService = jwtService;
        }

        // ============================================================
        // ADMINISTRADOR
        // ============================================================
        public async Task<AuthResponseDTO?> RegisterAdminAsync(AdministradorCreateDTO admin)
        {
            if (admin.IdRol != 1)
                throw new ArgumentException("El rol proporcionado no corresponde a la ruta especificada.");

            using var connection = _context.GetConnection();
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();

            try
            {
                // Registrar usuario
                var registeredUser = await _authRepository.RegisterUser(new UsuariosCreateDTO
                {
                    IdRol = admin.IdRol,
                    PrimerNombre = admin.PrimerNombre,
                    SegundoNombre = admin.SegundoNombre,
                    PrimerApellido = admin.PrimerApellido,
                    SegundoApellido = admin.SegundoApellido,
                    Telefono = admin.Telefono,
                    Correo = admin.Correo,
                    Contraseña = admin.Contraseña
                }, connection, transaction);

                if (registeredUser == null)
                    throw new InvalidOperationException("El correo ya está siendo utilizado.");

                // Registrar administrador
                var registeredAdmin = await _authRepository.RegisterAdminAsync(new AdministradorRegisterDTO
                {
                    IdUsuario = registeredUser.IdUsuario
                }, connection, transaction);

                if (registeredAdmin == null)
                    throw new Exception("No pudo crearse el administrador.");

                // Crear refresh token dentro de la transacción
                var refresh = new RefreshToken
                {
                    IdUsuario = registeredUser.IdUsuario,
                    Token = Guid.NewGuid(),
                    FechaCreacion = DateTime.UtcNow,
                    FechaExpiracion = DateTime.UtcNow.AddDays(7),
                    Revoked = false
                };
                await _refreshRepository.Create(refresh, connection, transaction);

                transaction.Commit();

                var jwt = _jwtService.GenerateToken(registeredUser);
                return new AuthResponseDTO
                {
                    IdUsuario = registeredUser.IdUsuario,
                    JwtToken = jwt,
                    RefreshToken = refresh.Token.ToString()
                };
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        // ============================================================
        // VENDEDOR
        // ============================================================
        public async Task<AuthResponseDTO?> RegisterSellerAsync(VendedorCreateDTO vendedor)
        {
            if (vendedor.IdRol != 2)
                throw new ArgumentException("El rol proporcionado no corresponde a la ruta especificada.");

            using var connection = _context.GetConnection();
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();
            
            try
            {
                var registeredUser = await _authRepository.RegisterUser(new UsuariosCreateDTO
                {
                    IdRol = vendedor.IdRol,
                    PrimerNombre = vendedor.PrimerNombre,
                    SegundoNombre = vendedor.SegundoNombre,
                    PrimerApellido = vendedor.PrimerApellido,
                    SegundoApellido = vendedor.SegundoApellido,
                    Telefono = vendedor.Telefono,
                    Correo = vendedor.Correo,
                    Contraseña = vendedor.Contraseña
                }, connection, transaction);

                if (registeredUser == null)
                    throw new InvalidOperationException("El correo ya está siendo utilizado.");

                var registeredSeller = await _authRepository.RegisterSellerAsync(new VendedorRegisterDTO
                {
                    IdUsuario = registeredUser.IdUsuario,
                    Ingresos = vendedor.Ingresos
                }, connection, transaction);

                if (registeredSeller == null)
                    throw new Exception("No pudo crearse el vendedor.");

                var refresh = new RefreshToken
                {
                    IdUsuario = registeredUser.IdUsuario,
                    Token = Guid.NewGuid(),
                    FechaCreacion = DateTime.UtcNow,
                    FechaExpiracion = DateTime.UtcNow.AddDays(7),
                    Revoked = false
                };
                await _refreshRepository.Create(refresh, connection, transaction);

                transaction.Commit();

                var jwt = _jwtService.GenerateToken(registeredUser);
                return new AuthResponseDTO
                {
                    IdUsuario = registeredUser.IdUsuario,
                    JwtToken = jwt,
                    RefreshToken = refresh.Token.ToString()
                };
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        // ============================================================
        // COMPRADOR
        // ============================================================
        public async Task<AuthResponseDTO?> RegisterBuyerAsync(CompradorCreateDTO comprador)
        {
            if (comprador.IdRol != 3)
                throw new ArgumentException("El rol proporcionado no corresponde a la ruta especificada.");

            using var connection = _context.GetConnection();
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();

            try
            {
                var registeredUser = await _authRepository.RegisterUser(new UsuariosCreateDTO
                {
                    IdRol = comprador.IdRol,
                    PrimerNombre = comprador.PrimerNombre,
                    SegundoNombre = comprador.SegundoNombre,
                    PrimerApellido = comprador.PrimerApellido,
                    SegundoApellido = comprador.SegundoApellido,
                    Telefono = comprador.Telefono,
                    Correo = comprador.Correo,
                    Contraseña = comprador.Contraseña
                }, connection, transaction);

                if (registeredUser == null)
                    throw new InvalidOperationException("El correo ya está siendo utilizado.");

                var registeredBuyer = await _authRepository.RegisterBuyerAsync(new CompradorRegisterDTO
                {
                    IdUsuario = registeredUser.IdUsuario
                }, connection, transaction);

                if (registeredBuyer == null)
                    throw new Exception("No pudo crearse el comprador.");

                var refresh = new RefreshToken
                {
                    IdUsuario = registeredUser.IdUsuario,
                    Token = Guid.NewGuid(),
                    FechaCreacion = DateTime.UtcNow,
                    FechaExpiracion = DateTime.UtcNow.AddDays(7),
                    Revoked = false
                };
                await _refreshRepository.Create(refresh, connection, transaction);

                transaction.Commit();

                var jwt = _jwtService.GenerateToken(registeredUser);
                return new AuthResponseDTO
                {
                    IdUsuario = registeredUser.IdUsuario,
                    JwtToken = jwt,
                    RefreshToken = refresh.Token.ToString()
                };
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

    }
}
