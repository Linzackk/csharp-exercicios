using CadastroLoginProtegido.Models;

namespace CadastroLoginProtegido.Services.TokenService
{
    public interface ITokenService
    {
        public Task<string> GerarToken(Usuario usuario);
    }
}
