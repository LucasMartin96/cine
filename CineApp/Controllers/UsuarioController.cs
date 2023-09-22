using CineApp.IServices;
using CineApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CineApp.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosService _usuariosService;

        public UsuarioController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> GetUsuarios()
        {
            return _usuariosService.GetUsuarios();
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetUsuario(int id)
        {
            var result = _usuariosService.GetUsuario(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<Usuario> CreateUsuario([FromBody] Usuario usuario)
        {
            var result = _usuariosService.CreateUsuario(usuario);

            return Created($"{Request.Path}/{result.Id}", result);
        }

        [HttpPut("{id}")]
        public ActionResult<Usuario> UpdateUsuario(int id, [FromBody] Usuario usuario)
        {
            var result = _usuariosService.UpdateUsuario(id, usuario);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
