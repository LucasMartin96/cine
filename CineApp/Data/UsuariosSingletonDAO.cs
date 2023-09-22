using CineApp.IData;
using CineApp.Models;

namespace CineApp.Data
{
    public class UsuariosSingletonDAO : IUsuariosSingletonDAO
    {
        private Dictionary<int, Usuario> _usuariosData;

        public UsuariosSingletonDAO()
        {
            _usuariosData = new Dictionary<int, Usuario>
            {
                { 1, new Usuario { Id = 1, FirstName = "Lucas", LastName = "Martin", Age = 27, Email = "lmartin@gmail.com" } },
                { 2, new Usuario { Id = 2, FirstName = "Lautaro", LastName = "Lopez", Age = 21, Email = "llopez@gmail.com" } },
                { 3, new Usuario { Id = 3, FirstName = "Cristian", LastName = "Angelini", Age = 26, Email = "cangelini@gmail.com" } },
                { 4, new Usuario { Id = 4, FirstName = "Axel", LastName = "Bossio", Age = 26, Email = "abossio@gmail.com" } },
                { 5, new Usuario { Id = 5, FirstName = "Gonzalo", LastName = "Tortosa", Age = 27, Email = "gtortosa@gmail.com" } },
                { 6, new Usuario { Id = 6, FirstName = "Gaston", LastName = "Brobjerg", Age = 27, Email = "gbrobjerg@gmail.com" } },
                { 7, new Usuario { Id = 7, FirstName = "Facundo", LastName = "Martin", Age = 33, Email = "fmartin@gmail.com" } }
            };
        }

        public Usuario CreateUsuario(Usuario usuario)
        {
            // Tomamos el ultimo indice del diccionario mas 1
            var lastIndex = _usuariosData.Keys.Last() + 1;
            // Le ponemos el ID al usuario
            usuario.Id = lastIndex;
            // Guardamos el usuario en memoria
            _usuariosData[lastIndex] = usuario;
            return usuario;
        }

        public Usuario? GetUsuario(int id)
        {
            // Chequeamos si el usuario existe en memoria
            if(!_usuariosData.ContainsKey(id))
                return null; 
            return _usuariosData[id];
        }

        public List<Usuario> GetUsuarios()
        {
            var result = new List<Usuario>();
            foreach(var key in _usuariosData.Keys)
            {
                result.Add(_usuariosData[key]);
            }
            return result;
        }

        public List<Usuario> GetUsuariosV2()
        {
            // Modo de pasar un diccionario a una lista con LINQ
            return _usuariosData.Select(item => item.Value).ToList() ;
        }

        public Usuario UpdateUsuario(int id, Usuario usuario)
        {
            if (!_usuariosData.ContainsKey(id))
                return null;
            _usuariosData[id] = usuario;
            return _usuariosData[id];
        }
    }
}
