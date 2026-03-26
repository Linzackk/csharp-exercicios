using BCrypt.Models;
using BCrypt.Services;
using Microsoft.AspNetCore.Mvc;

namespace BCrypt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginServices _service;
        public LoginController(LoginServices service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult CriarNovoLogin([FromBody] LoginCreateDTO login)
        {
            _service.CriarLogin(login);
            return Ok("Criado.");
        }
        [HttpPost("Logar")]
        public IActionResult FazerLogin([FromBody] LoginCreateDTO infos)
        {
            var login = _service.FazerLogin(infos.Senha, infos.Email);
            if (login)
                return Ok("Logado.");
            else
                return BadRequest("Credenciais Inválidas.");
        }
        [HttpGet]
        public IActionResult ObterTodos()
        {
            return Ok(_service.ListarTodos());
        }
    }
}
