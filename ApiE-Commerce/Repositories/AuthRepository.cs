using ApiProyectoDeCursoE_Commerce.Data;
using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;
using ApiProyectoDeCursoE_Commerce.Models.Enums;
using ApiProyectoDeCursoE_Commerce.Repositories.Interfaces;
using System.Linq;

namespace ApiProyectoDeCursoE_Commerce.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UsuariosRepository _usuariosRepository;
        private readonly VendedoresRepository _vendedoresRepository;
        private readonly CompradoresRepository _compradoresRepository;
        private readonly AdministradoresRepository _administradoresRepository;

        public AuthRepository(
            UsuariosRepository usuariosRepository,
            VendedoresRepository vendedoresRepository,
            CompradoresRepository compradoresRepository,
            AdministradoresRepository administradoresRepository)
        {
            _usuariosRepository = usuariosRepository;
            _vendedoresRepository = vendedoresRepository;
            _compradoresRepository = compradoresRepository;
            _administradoresRepository = administradoresRepository;
        }

        public async Task<Usuario?> RegisterUser(UsuariosCreateDTO usuario)
        {
            // Verificar si el correo ya existe
            var usuarioEnDb = await _usuariosRepository.GetByEmail(usuario.Correo);
            if (usuarioEnDb != null) return null;

            // Crear usuario
            int filasAfectadas = await _usuariosRepository.Create(usuario);
            if (filasAfectadas == 0) return null;

            // Obtener IdUsuario generado
            var usuarioCreado = await _usuariosRepository.GetByEmail(usuario.Correo);
            if (usuarioCreado == null) return null;

            // Crear rol
            string rol = ((RolesEnum)usuario.IdRol).ToString();
            bool creadoCorrectamente = true;
            int filasAfectadasRol = 0;

            switch (rol)
            {
                case "Administradores":
                    filasAfectadasRol = await _administradoresRepository.Create(usuarioCreado.IdUsuario);
                    break;
                case "Vendedor":
                    // Solo enviar IdUsuario al repositorio de vendedores
                    filasAfectadasRol = await _vendedoresRepository.Create(usuarioCreado.IdUsuario);
                    break;
                case "Comprador":
                    filasAfectadasRol = await _compradoresRepository.Create(usuarioCreado.IdUsuario);
                    break;
                default:
                    creadoCorrectamente = false;
                    break;
            }

            if (!creadoCorrectamente) return null;

            return usuarioCreado;
        }

        private byte[] HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                return sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<Usuario?> LoginUser(string correo, string contraseña)
        {
            var usuarioEnDb = await _usuariosRepository.GetByEmail(correo);
            if (usuarioEnDb == null) return null;

            // Hash de la contraseña ingresada
            byte[] passwordIngresadaHash = HashPassword(contraseña);

            // Comparar con la contraseña almacenada
            bool contraseñaCorrecta = usuarioEnDb.Contraseña.SequenceEqual(passwordIngresadaHash);
            if (!contraseñaCorrecta) return null;

            // Validar rol
            string rol = ((RolesEnum)usuarioEnDb.IdRol).ToString();
            bool existe = rol switch
            {
                "Administradores" => await _administradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
                "Vendedor" => await _vendedoresRepository.GetById(usuarioEnDb.IdUsuario) != null,
                "Comprador" => await _compradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
                _ => false
            };

            return existe ? usuarioEnDb : null;
        }


        public async Task<Usuario?> LoginUserById(int idUsuario)
        {
            var usuarioEnDb = await _usuariosRepository.GetById(idUsuario);
            if (usuarioEnDb == null) return null;

            string rol = ((RolesEnum)usuarioEnDb.IdRol).ToString();
            bool existe = rol switch
            {
                "Administradores" => await _administradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
                "Vendedor" => await _vendedoresRepository.GetById(usuarioEnDb.IdUsuario) != null,
                "Comprador" => await _compradoresRepository.GetByIdUsuario(usuarioEnDb.IdUsuario) != null,
                _ => false
            };

            return existe ? usuarioEnDb : null;
        }
    }
}
