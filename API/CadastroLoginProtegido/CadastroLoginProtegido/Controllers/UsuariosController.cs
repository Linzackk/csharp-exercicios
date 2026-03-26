using CadastroLoginProtegido.DTOs.Usuario;
using CadastroLoginProtegido.Models;
using CadastroLoginProtegido.Services.UsuarioService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CadastroLoginProtegido.Controllers
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
        [HttpPost]
        public async Task<IActionResult> CriarNovoUsuario(UsuarioCreateDTO novoUsuario)
        {
            var usuario = await _service.CriarUsuario(novoUsuario);
            return CreatedAtAction(nameof(ObterPorId), new { id = usuario.Id }, usuario);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var userIdToken = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdToken != id.ToString())
                return Forbid();

            var usuario = await _service.ObterPorId(id);
            return Ok(usuario);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var usuarios = await _service.ObterTodos();
            return Ok(usuarios);
        }
    }
}
