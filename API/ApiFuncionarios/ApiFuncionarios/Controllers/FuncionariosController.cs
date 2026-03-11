using ApiFuncionarios.Exceptions;
using ApiFuncionarios.Services;
using ApiFuncionarios.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncionarios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionariosController : Controller
    {
        private FuncionarioService _service;
        public FuncionariosController(FuncionarioService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                var data =_service.ObterTodos();
                return Ok(data);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var data = _service.ObterPorId(id);
                return Ok(data);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CriarNovoFuncionario([FromBody] Funcionario funcionario)
        {
            try
            {
                _service.CriarNovo(funcionario);
                return CreatedAtAction(nameof(ObterPorId), new { id = funcionario.Id }, funcionario);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarFuncionario(int id, [FromBody] Funcionario funcionario)
        {
            try
            {
                _service.Atualizar(funcionario, id);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarFuncionario(int id)
        {
            try
            {
                _service.Deletar(id);
                return NoContent();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

