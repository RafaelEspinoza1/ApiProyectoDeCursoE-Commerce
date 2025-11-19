using ApiProyectoDeCursoE_Commerce.Configuration;
using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using NuGet.Protocol.Core.Types;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        // Contexto de la base de datos
        private readonly ECommerceContext _context;

        // Repositorios
        private readonly UsuariosRepository _usuariosRepository;
        private readonly VendedoresRepository _vendedoresRepository;
        private readonly CompradoresRepository _compradoresRepository;
        private readonly AdministradoresRepository _administradoresRepository;

        // Constructor
        public AuthRepository(
            ECommerceContext context,
            UsuariosRepository usuariosRepository,
            VendedoresRepository vendedoresRepository,
            CompradoresRepository compradoresRepository,
            AdministradoresRepository administradoresRepository)
        {
            _context = context;
            _usuariosRepository = usuariosRepository;
            _vendedoresRepository = vendedoresRepository;
            _compradoresRepository = compradoresRepository;
            _administradoresRepository = administradoresRepository;
        }

        // Registra usuario
        public async Task<Usuario?> RegisterUser(UsuariosCreateDTO usuario)
        {
            var usuarioEnDb = await _usuariosRepository.GetByEmail(usuario.Correo);
            
            if (usuarioEnDb != null)
            {
                return null;
            }

            // Obtener el rol del usuario
            string rol = ((RolesEnum)usuario.IdRol).ToString();

            // Crear el usuario según su rol
            int filasAfectadasRol = 0;
            bool creadoCorrectamente = true;

            switch (rol)
            {
                case "Administradores":
                    filasAfectadasRol = await _administradoresRepository.Create(usuario.IdUsuario);
                    break;
                case "Vendedor":
                    filasAfectadasRol = await _vendedoresRepository.Create(usuario, usuario.IdUsuario);
                    break;
                case "Comprador":
                    filasAfectadasRol = await _compradoresRepository.Create(usuario.IdUsuario);
                    break;
                default:
                    creadoCorrectamente = false;
                    break;
            }

            // Si se creó correctamente el rol, crear el usuario
            if (creadoCorrectamente)
            {
                int filasAfectadas = await _usuariosRepository.Create(usuario);

                if (filasAfectadas > 0)
                {
                    return await _usuariosRepository.GetByEmail(usuario.Correo);
                }
            }

            return null;
        }

        // Inicia sesión y verifica la contraseña
        public async Task<Usuario?> LoginUser(string correo, string contraseña, string rol)
        {
            // Obtener el usuario por correo y verificar si existe
            var usuarioEnDb = await _usuariosRepository.GetByEmail(correo);
            bool existe = true;

            // Si no existe el usuario principal no hay rol definido
            if (usuarioEnDb == null)
            {
                return null;
            }

            // Verificar si existe el usuario con respecto a su rol
            switch (rol)
            {
                case "Administradores":
                    var administrador = await _administradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario);
                    if (administrador == null) { existe = false; }
                    break;
                case "Vendedor":
                    var vendedor = await _vendedoresRepository.GetById(usuarioEnDb.IdUsuario);
                    if (vendedor == null) { existe = false; }
                    break;
                case "Comprador":
                    var comprador = await _compradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario);
                    if (comprador == null) { existe = false; }
                    break;
                default:
                    existe = false;
                    break;
            }

            // Verificar si la contraseña es correcta
            if (existe)
            {
                if (usuarioEnDb != null)
                {
                    if (usuarioEnDb.Contraseña == contraseña)
                    {
                        return usuarioEnDb;
                    }
                }
            }
            return null;
        }
    }
}
