using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.DAOs;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using ApiProyectoDeCursoE_Commerce.Repositories;
using NetTopologySuite.IO;
using System.Data.SqlClient;

namespace ApiProyectoDeCursoE_Commerce.Services
{
    public class AuthService : IAuthService
    {
        private readonly ECommerceContext _context;

        private readonly UsuarioDAO _usuarioDAO;
        private readonly RefreshTokenDAO _refreshTokenDAO;

        private readonly AuthRepository _authRepository;
        private readonly JwtService _jwtService;

        public AuthService(
            ECommerceContext context,
            UsuarioDAO usuarioDAO,
            RefreshTokenDAO refreshTokenDAO,
            AuthRepository authRepository,
            JwtService jwtService)
        {
            _context = context;
            _usuarioDAO = usuarioDAO;
            _refreshTokenDAO = refreshTokenDAO;
            _authRepository = authRepository;
            _jwtService = jwtService;
        }


        // ============================================================
        // LOGIN GENERAL (JWT + Refresh + Correo/Contraseña)
        // ============================================================
        public async Task<AuthResponseDTO?> LoginAsync(LoginDTO login)
        {
            using var connection = _context.GetConnection();
            await connection.OpenAsync();

            Usuario? user;

            // ============================================================
            // 0. LOGIN RÁPIDO CON JWT VÁLIDO
            // ============================================================
            if (!string.IsNullOrWhiteSpace(login.Token))
            {
                var principal = _jwtService.ValidateToken(login.Token);

                if (principal != null)
                {
                    var idUsuarioClaim = principal.FindFirst("id")?.Value;

                    if (int.TryParse(idUsuarioClaim, out int tokenId))
                    {
                        user = await _authRepository.LoginUserById(tokenId, connection);

                        if (user != null)
                        {
                            return new AuthResponseDTO
                            {
                                IdUsuario = user.IdUsuario,
                                PrimerNombre = user.PrimerNombre,
                                PrimerApellido = user.PrimerApellido,
                                Correo = user.Correo,
                                Telefono = Convert.ToInt32(user.Telefono),
                                Token = login.Token,
                                RefreshToken = ""
                            };
                        }
                    }
                }
            }

            // ============================================================
            // 1. LOGIN PERSISTENTE CON REFRESH TOKEN
            // ============================================================
            if (!string.IsNullOrWhiteSpace(login.RefreshToken))
            {
                if (!Guid.TryParse(login.RefreshToken, out Guid refreshGuid))
                    return null;

                user = await _authRepository.LoginUserById(login.IdUsuario, connection);

                if (user == null)
                    return null;

                var refreshToken = await _refreshTokenDAO.GetActiveAsync(login.IdUsuario, connection);

                if (refreshToken == null || refreshToken.Revoked)
                    return null;

                if (refreshToken.FechaExpiracion < DateTime.UtcNow)
                {
                    refreshToken.Revoked = true;
                    await _refreshTokenDAO.UpdateAsync(refreshToken, connection);
                    return null;
                }

                // Renovar Refresh Token
                refreshToken.FechaExpiracion = DateTime.UtcNow.AddDays(7);
                await _refreshTokenDAO.UpdateAsync(refreshToken, connection);

                var jwt = _jwtService.GenerateToken(user);

                return new AuthResponseDTO
                {
                    IdUsuario = user.IdUsuario,
                    PrimerNombre = user.PrimerNombre,
                    PrimerApellido = user.PrimerApellido,
                    Correo = user.Correo,
                    Telefono = Convert.ToInt32(user.Telefono),
                    Token = jwt,
                    RefreshToken = refreshToken.Token.ToString()
                };
            }

            // ============================================================
            // 2. LOGIN NORMAL (Correo + Contraseña)
            // ============================================================
            if (string.IsNullOrWhiteSpace(login.Correo) || string.IsNullOrWhiteSpace(login.Contraseña))
                return null;

            user = await _authRepository.LoginUser(login.Correo, login.Contraseña, connection);

            if (user == null)
                return null;

            // ============================================================
            // 3. MANEJO DEL REFRESH TOKEN
            // ============================================================
            var existingToken = await _refreshTokenDAO.GetActiveAsync(user.IdUsuario, connection);

            if (existingToken != null && (existingToken.FechaExpiracion < DateTime.UtcNow || existingToken.Revoked))
            {
                existingToken.Revoked = true;
                await _refreshTokenDAO.UpdateAsync(existingToken, connection);
                existingToken = null;
            }

            if (existingToken == null)
            {
                var newRefresh = new RefreshTokenCreateDTO
                {
                    IdUsuario = user.IdUsuario,
                    Token = Guid.NewGuid(),
                    FechaCreacion = DateTime.UtcNow,
                    FechaExpiracion = DateTime.UtcNow.AddDays(7),
                    Revoked = false
                };

                await _refreshTokenDAO.CreateAsync(newRefresh, connection, null);
                existingToken = await _refreshTokenDAO.GetActiveAsync(newRefresh.IdUsuario, connection);
            }
            else
            {
                existingToken.FechaExpiracion = DateTime.UtcNow.AddDays(7);
                await _refreshTokenDAO.UpdateAsync(existingToken, connection);
            }

            // ============================================================
            // 4. GENERAR JWT Y RESPUESTA
            // ============================================================
            var jwtNormal = _jwtService.GenerateToken(user);

            return new AuthResponseDTO
            {
                IdUsuario = user.IdUsuario,
                PrimerNombre = user.PrimerNombre,
                PrimerApellido = user.PrimerApellido,
                Correo = user.Correo,
                Telefono = Convert.ToInt32(user.Telefono),
                Token = jwtNormal,
                RefreshToken = existingToken.Token.ToString()
            };
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

            int registeredUserId = 0;
            var refreshToken = new RefreshTokenCreateDTO
            {
                IdUsuario = registeredUserId,
                Token = Guid.NewGuid(),
                FechaCreacion = DateTime.UtcNow,
                FechaExpiracion = DateTime.UtcNow.AddDays(7),
                Revoked = false
            };

            try
            {
                // Registrar usuario
                registeredUserId = await _authRepository.RegisterUser(new UsuariosCreateDTO
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

                if (registeredUserId == 0)
                    throw new InvalidOperationException("Ha ocurrido un error al tratar de crear el usuario.");
                

                // Registrar administrador
                var registeredAdmin = await _authRepository.RegisterAdminAsync(new AdministradorRegisterDTO
                {
                    IdUsuario = registeredUserId
                }, connection, transaction);

                if (registeredAdmin == null)
                    throw new Exception("No pudo crearse el administrador.");

                refreshToken.IdUsuario = registeredUserId;
                var createdRefreshToken = await _authRepository.CreateRefreshTokenAsync(refreshToken, connection, transaction);

                if (createdRefreshToken == null)
                    throw new Exception("No pudo crearse el refresh token.");

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }

            var registeredUser = await _usuarioDAO.GetByIdAsync(registeredUserId, connection);

            if (registeredUser == null)
            {
                throw new Exception("El usuario no se encuentra registrado.");
            }

            var jwt = _jwtService.GenerateToken(registeredUser);
            return new AuthResponseDTO
            {
                IdUsuario = registeredUser.IdUsuario,
                Token = jwt,
                PrimerNombre = registeredUser.PrimerNombre,
                PrimerApellido = registeredUser.PrimerApellido,
                Correo = registeredUser.Correo,
                Telefono = Convert.ToInt32(registeredUser.Telefono),
                RefreshToken = refreshToken.Token.ToString()
            };
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

            int registeredUserId = 0;
            var refreshToken = new RefreshTokenCreateDTO
            {
                IdUsuario = registeredUserId,
                Token = Guid.NewGuid(),
                FechaCreacion = DateTime.UtcNow,
                FechaExpiracion = DateTime.UtcNow.AddDays(7),
                Revoked = false
            };

            try
            {
                // Registrar usuario
                registeredUserId = await _authRepository.RegisterUser(new UsuariosCreateDTO
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

                if (registeredUserId == 0)
                    throw new InvalidOperationException("Ha ocurrido un error al tratar de crear el usuario.");

                var registeredSeller = await _authRepository.RegisterSellerAsync(new VendedorRegisterDTO
                {
                    IdUsuario = registeredUserId,
                    NombreNegocio = vendedor.NombreNegocio!,
                    LogoNegocio = vendedor.LogoNegocio,
                    DescripcionNegocio = vendedor.DescripcionNegocio,
                    EsContribuyente = vendedor.EsContribuyente
                }, connection, transaction);

                if (registeredSeller == null)
                    throw new Exception("No pudo crearse el vendedor.");

                refreshToken.IdUsuario = registeredUserId;
                var createdRefreshToken = await _authRepository.CreateRefreshTokenAsync(refreshToken, connection, transaction);

                if (createdRefreshToken == null)
                    throw new Exception("No pudo crearse el refresh token.");

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }

            var registeredUser = await _usuarioDAO.GetByIdAsync(registeredUserId, connection);

            if (registeredUser == null)
            {
                throw new Exception("El usuario no se encuentra registrado.");
            }

            var jwt = _jwtService.GenerateToken(registeredUser);
            return new AuthResponseDTO
            {
                IdUsuario = registeredUser.IdUsuario,
                Token = jwt,
                PrimerNombre = registeredUser.PrimerNombre,
                PrimerApellido = registeredUser.PrimerApellido,
                Correo = registeredUser.Correo,
                Telefono = Convert.ToInt32(registeredUser.Telefono),
                RefreshToken = refreshToken.Token.ToString()
            };
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

            int registeredUserId = 0;

            var refreshToken = new RefreshTokenCreateDTO
            {
                IdUsuario = registeredUserId,
                Token = Guid.NewGuid(),
                FechaCreacion = DateTime.UtcNow,
                FechaExpiracion = DateTime.UtcNow.AddDays(7),
                Revoked = false
            };

            try
            {
                registeredUserId = await _authRepository.RegisterUser(new UsuariosCreateDTO
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

                if (registeredUserId == 0)
                    throw new InvalidOperationException("Ha ocurrido un error al tratar de crear el usuario.");

                var registeredBuyer = await _authRepository.RegisterBuyerAsync(new CompradorRegisterDTO
                {
                    IdUsuario = registeredUserId
                }, connection, transaction);

                if (registeredBuyer == null)
                    throw new Exception("No pudo crearse el comprador.");

                refreshToken.IdUsuario = registeredUserId;
                var createdRefreshToken = await _authRepository.CreateRefreshTokenAsync(refreshToken, connection, transaction);

                if (createdRefreshToken == null)
                    throw new Exception("No pudo crearse el refresh token.");

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }

            var registeredUser = await _usuarioDAO.GetByIdAsync(registeredUserId, connection);

            if (registeredUser == null)
            {
                throw new Exception("El usuario no se encuentra registrado.");
            }

            var jwt = _jwtService.GenerateToken(registeredUser);
            return new AuthResponseDTO
            {
                IdUsuario = registeredUser.IdUsuario,
                Token = jwt,
                PrimerNombre = registeredUser.PrimerNombre,
                PrimerApellido = registeredUser.PrimerApellido,
                Correo = registeredUser.Correo,
                Telefono = Convert.ToInt32(registeredUser.Telefono),
                RefreshToken = refreshToken.Token.ToString()
            };
        }

    }
}
