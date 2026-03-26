using BCrypt.Models;
using BCrypt.Net;
using BCrypt.Repositories;

namespace BCrypt.Services
{
    public class LoginServices
    {
        private readonly LoginRepository _repository;
        public LoginServices(LoginRepository repository)
        {
            _repository = repository;
        }
        public void CriarLogin(LoginCreateDTO novoLogin)
        {
            var hashSenha = BCrypt.Net.BCrypt.HashPassword(novoLogin.Senha);
            var login = new Login(
                novoLogin.Email,
                hashSenha
            );
            _repository.CriarNovoLogin(login);
        }
        public IReadOnlyCollection<Login> ListarTodos()
        {
            return _repository.ListarUsuarios();
        }
        public bool FazerLogin(string senha, string email)
        {
            var login = _repository.ObterPorId(email);
            if (login == null)
                return false;

            if (login.Email != email)
                return false;

            return BCrypt.Net.BCrypt.Verify(senha, login.Senha);
        }
    }
}
