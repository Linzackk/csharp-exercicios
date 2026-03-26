using CadastroLoginProtegido.DTOs.Login;
using CadastroLoginProtegido.Services.LoginService;
using Microsoft.AspNetCore.Mvc;

namespace CadastroLoginProtegido.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> FazerLogin([FromBody] LoginInfoDTO infos)
        {
            var token = await _service.ValidarCredenciais(infos);
            return Ok(token);
        }
    }
}
