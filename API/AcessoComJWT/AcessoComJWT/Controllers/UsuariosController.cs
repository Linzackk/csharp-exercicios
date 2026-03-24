using AcessoComJWT.Models;
using AcessoComJWT.Services;
using AcessoComJWT.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AcessoComJWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _service;
        public UsuariosController(IUsuarioService service)
        {
            _service = service;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CriarNovoUsuario([FromBody] UsuarioCreateDTO novoUsuario)
        {
            try
            {
                var user = _service.AdicionarUsuario(novoUsuario);
                return CreatedAtAction(nameof(ObterUsuarioPorId), new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult ObterUsuarioPorId(int id)
        {
            var userIdToken = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            Console.WriteLine(userIdToken);
            Console.WriteLine(id.ToString());
            Console.WriteLine(userIdToken != id.ToString());
            if (userIdToken != id.ToString())
                return Forbid();

            try
            {
                var user = _service.ObterUsuario(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult ObterTodosUsuarios()
        {
            try
            {
                var users = _service.ListarUsuarios();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
