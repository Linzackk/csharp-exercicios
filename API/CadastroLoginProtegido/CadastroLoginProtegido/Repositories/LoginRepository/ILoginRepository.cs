using CadastroLoginProtegido.Models;

namespace CadastroLoginProtegido.Repositories.LoginRepository
{
    public interface ILoginRepository
    {
        Task<Login?> BuscarLoginPorEmail(string email);
        Task CriarLogin(Login login);
    }
}
