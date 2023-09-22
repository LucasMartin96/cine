using CineApp.IData;
using CineApp.IServices;
using CineApp.Models;

namespace CineApp.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosSingletonDAO _usuariosSingletonDAO;

        public UsuariosService(IUsuariosSingletonDAO usuariosSingletonDAO)
        {
            _usuariosSingletonDAO = usuariosSingletonDAO;
        }

        public Usuario CreateUsuario(Usuario usuario)
        {
            return _usuariosSingletonDAO.CreateUsuario(usuario);
        }

        public Usuario? GetUsuario(int id)
        {
            return _usuariosSingletonDAO.GetUsuario(id);
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuariosSingletonDAO.GetUsuarios();
        }

        public Usuario? UpdateUsuario(int id, Usuario usuario)
        {
            return _usuariosSingletonDAO.UpdateUsuario(id, usuario);
        }
    }
}
