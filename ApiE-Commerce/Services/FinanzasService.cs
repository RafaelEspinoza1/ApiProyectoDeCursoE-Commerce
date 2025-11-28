using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.DAOs;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.AdministradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.CompradorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.RefreshTokenDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Auth.VendedorDTOs;
using ApiProyectoDeCursoE_Commerce.DTOs.Finance;
using ApiProyectoDeCursoE_Commerce.Models.Auth;
using ApiProyectoDeCursoE_Commerce.Models.ECommerce;
using ApiProyectoDeCursoE_Commerce.Models.Finance;
using ApiProyectoDeCursoE_Commerce.Repositories;

namespace ApiProyectoDeCursoE_Commerce.Services
{
    public class FinanzasService
    {
        private readonly ECommerceContext _context;

        private readonly CuentaDAO _cuentaDAO;
        private readonly ComprobanteContableDAO _comprobanteContableDAO;

        public FinanzasService(
            ECommerceContext context,
            CuentaDAO cuentaDAO,
            ComprobanteContableDAO comprobanteContableDAO)
        {
            _context = context;
            _cuentaDAO = cuentaDAO;
            _comprobanteContableDAO = comprobanteContableDAO;
        }


        // ============================================================
        // CUENTAS
        // ============================================================
        public async Task<List<Cuenta>> ObtenerCuentas()
        {
            using var connection = _context.GetConnection();
            await connection.OpenAsync();

            return await _cuentaDAO.GetAllAsync(connection);
        }

        public async Task<int> CrearCuenta(CuentaCreateDTO cuenta)
        {
            using var connection = _context.GetConnection();
            await connection.OpenAsync();
            //using var transaction = connection.BeginTransaction();

            return await _cuentaDAO.CreateAsync(cuenta, connection, transaction: null);
        }


        // ============================================================
        // COMPROBANTES
        // ============================================================
        public async Task<List<ComprobanteContable>> ObtenerComprobantesContables()
        {
            using var connection = _context.GetConnection();
            await connection.OpenAsync();

            return await _comprobanteContableDAO.GetAllAsync(connection);
        }

        public async Task<int> CrearComprobanteContable(ComprobanteContableCreateDTO comprobanteContable)
        {
            using var connection = _context.GetConnection();
            await connection.OpenAsync();
            //using var transaction = connection.BeginTransaction();

            return await _comprobanteContableDAO.CreateAsync(comprobanteContable, connection, transaction: null);
        }
    }
}
