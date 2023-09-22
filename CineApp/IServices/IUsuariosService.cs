using CineApp.Models;

namespace CineApp.IServices
{
    public interface IUsuariosService
    {
        Usuario? GetUsuario(int id);
        List<Usuario> GetUsuarios();
        Usuario CreateUsuario(Usuario usuario);
        Usuario? UpdateUsuario(int id, Usuario usuario);
    }
}
