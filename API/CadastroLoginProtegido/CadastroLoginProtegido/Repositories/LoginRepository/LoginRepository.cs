using CadastroLoginProtegido.Models;

namespace CadastroLoginProtegido.Repositories.LoginRepository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly List<Login> _login = new List<Login>();

        public async Task CriarLogin(Login login)
        {
            _login.Add(login);
        }
        public async Task<Login?> BuscarLoginPorEmail(string email)
        {
            return _login.Find(login => login.Email == email);
        }
    }
}
