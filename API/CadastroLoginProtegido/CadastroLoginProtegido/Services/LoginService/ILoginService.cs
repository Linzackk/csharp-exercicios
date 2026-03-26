using CadastroLoginProtegido.DTOs.Login;

namespace CadastroLoginProtegido.Services.LoginService
{
    public interface ILoginService
    {
        Task<string> ValidarCredenciais(LoginInfoDTO loginInfo);
    }
}
