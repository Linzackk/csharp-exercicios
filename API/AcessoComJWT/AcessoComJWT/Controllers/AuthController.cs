using AcessoComJWT.Models;
using AcessoComJWT.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcessoComJWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioService _service;
        public AuthController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Logar([FromBody] LoginRequestDTO login)
        {
            try
            {
                var token = _service.FazerLogin(login);
                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
