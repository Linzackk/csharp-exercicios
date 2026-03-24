using AcessoComJWT.Models;
using AcessoComJWT.Repository;
using AcessoComJWT.Utils;

namespace AcessoComJWT.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly TokenService _tokenService;
        public UsuarioService(IUsuarioRepository repository, TokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }

        public UsuarioResponseDTO AdicionarUsuario(UsuarioCreateDTO usuario)
        {
            Usuario novoUsuario = new Usuario(
                usuario.Nome, usuario.Role, usuario.Email, "123"
            );

            _repository.AdicionarUsuario(novoUsuario);
            return CriarResponseDTO(novoUsuario);
        }


        public UsuarioResponseDTO ObterUsuario(int id)
        {
            var usuario = _repository.ObterUsuario(id);
            if (usuario == null)
                throw new ArgumentException("Usuário Não encontrado.");

            return CriarResponseDTO(usuario);
        }

        public IReadOnlyCollection<UsuarioResponseDTO> ListarUsuarios()
        {
            var usuarios = _repository.ListarUsuarios();
            if (usuarios.Count == 0)
                return new List<UsuarioResponseDTO>().ToList();

            var response = new List<UsuarioResponseDTO>();
            foreach(var user in usuarios)
            {
                response.Add(CriarResponseDTO(user));
            }
            return response;
        }

        private UsuarioResponseDTO CriarResponseDTO(Usuario usuario)
        {
            var response = new UsuarioResponseDTO();

            response.Id = usuario.Id;
            response.Nome = usuario.Nome;
            response.Role = usuario.Role.ToString();
            response.Email = usuario.Email;

            return response;
        }

        public string FazerLogin(LoginRequestDTO login)
        {
            var response = _repository.ValidarCredenciais(login.Email, login.Senha);
            if (response == null)
                throw new ArgumentException("Credenciais Inválidas.");

            var token = _tokenService.GerarToken(response);
            return token;
        }
    }
}
