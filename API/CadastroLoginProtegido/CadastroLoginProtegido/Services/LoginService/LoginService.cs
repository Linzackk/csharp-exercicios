using CadastroLoginProtegido.DTOs.Login;
using CadastroLoginProtegido.Repositories.LoginRepository;
using CadastroLoginProtegido.Repositories.UsuarioRepository;
using CadastroLoginProtegido.Services.TokenService;

namespace CadastroLoginProtegido.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ITokenService _tokenService;
        public LoginService(ILoginRepository repository, IUsuarioRepository UsuarioRepository, ITokenService tokenService)
        {
            _repository = repository;
            _usuarioRepository = UsuarioRepository;
            _tokenService = tokenService;
        }
        public async Task<string> ValidarCredenciais(LoginInfoDTO loginInfo)
        {
            var login = await _repository.BuscarLoginPorEmail(loginInfo.Email);
            if (login == null)
            {
                BCrypt.Net.BCrypt.Verify("Senha Falsa", "Outra senha falsa");
                throw new ArgumentException("Credenciais Inválidas.");
            }
            if (!BCrypt.Net.BCrypt.Verify(loginInfo.Senha, login.Password))
                throw new ArgumentException("Credenciais Inválidas");

            var usuario = await _usuarioRepository.ObterPorId(login.Id);
            var token = await _tokenService.GerarToken(usuario);
            return token;
        }
    }
}
