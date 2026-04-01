using Integracao.Data;
using Integracao.Models;
using Integracao.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Integracao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioService _service;
        public UsuariosController(UsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CriarNovoUsuario([FromBody] Usuario novoUsuario)
        {
            _service.AdicionarUsuario(novoUsuario);
            return CreatedAtAction(nameof(ObterPorId), new { Id = novoUsuario.Id }, novoUsuario);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var usuario = _service.ObterPorId(id);
                return Ok(usuario);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizarUsuario([FromBody] UsuarioUpdateDTO infos, int id)
        {
            try
            {
                _service.AtualizarUsuario(infos, id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            try
            {
                _service.DeletarUsuario(id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
