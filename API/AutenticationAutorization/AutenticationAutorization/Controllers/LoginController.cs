using AutenticationAutorization.Models;
using AutenticationAutorization.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutenticationAutorization.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly TokenService _tokenService;
        public LoginController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost]
        public IActionResult Logar([FromBody] Login login)
        {
            bool sucesso = ValidarLogin(login);
            if (!sucesso)
                return Unauthorized();

            var token = _tokenService.GerarToken("1", login.Username, "Admin");
            return Ok( new { token });
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public IActionResult ValidarAutorizacao()
        {
            return Ok("Autorização feita com sucesso.");
        }

        private bool ValidarLogin(Login login)
        {
            string usuarioCorreto = "admin";
            string senhaCorreta = "admin";

            if (login == null)
                return false;

            if (login.Username != usuarioCorreto)
                return false;

            if (login.Password != senhaCorreta)
                return false;

            return true;
        }
    }
}
