using ApiProyectoDeCursoE_Commerce.DTOs.UsuariosDTOs;
using ApiProyectoDeCursoE_Commerce.Models;

namespace ApiProyectoDeCursoE_Commerce.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        // Comandos de autenticación
        Task<Usuario?> LoginUser(string correo, string password);
        Task<Usuario?> LoginUserById(int idUsuario);
        Task<Usuario?> RegisterUser(UsuariosCreateDTO usuario);   
    }
}
