using CineApp.Models;

namespace CineApp.IData
{
    public interface IUsuariosSingletonDAO
    {
        Usuario? GetUsuario(int id);
        List<Usuario> GetUsuarios();
        Usuario CreateUsuario(Usuario usuario);
        Usuario? UpdateUsuario(int id, Usuario usuario);
        List<Usuario> GetUsuariosV2();
    }
}
