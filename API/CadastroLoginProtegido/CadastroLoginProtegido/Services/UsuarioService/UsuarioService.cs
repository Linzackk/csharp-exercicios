using CadastroLoginProtegido.DTOs.Usuario;
using CadastroLoginProtegido.Models;
using CadastroLoginProtegido.Repositories.LoginRepository;
using CadastroLoginProtegido.Repositories.UsuarioRepository;

namespace CadastroLoginProtegido.Services.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly ILoginRepository _loginRepository;
        public UsuarioService(IUsuarioRepository repository, ILoginRepository loginRepository)
        {
            _repository = repository;
            _loginRepository = loginRepository;
        }
        private string CriarSenha(Usuario usuario)
        {
            var senha = usuario.DataNascimento.ToString().Replace("/", "");
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
        public async Task<UsuarioResponseDTO> CriarUsuario(UsuarioCreateDTO novoUsuario)
        {
            if (await _loginRepository.BuscarLoginPorEmail(novoUsuario.Email) != null)
                throw new ArgumentException("Email já cadastrado.");

            Usuario usuario = new Usuario(
                novoUsuario.Nome,
                novoUsuario.DataNascimento,
                novoUsuario.Email,
                novoUsuario.Cargo
            );
            await _repository.CriarUsuario(usuario);

            Login login = new Login(
                usuario.Id,
                usuario.Email,
                CriarSenha(usuario)
            );
            await _loginRepository.CriarLogin(login);

            return await TransformarUsuarioEmResponse(usuario);
        }
        public async Task<UsuarioResponseDTO> ObterPorId(int id)
        {
            var usuario = await _repository.ObterPorId(id);
            if (usuario == null)
                throw new ArgumentException("Usuário não existente");
            return await TransformarUsuarioEmResponse(usuario);
        }
        public async Task<IReadOnlyCollection<UsuarioResponseDTO>> ObterTodos()
        {
            var usuarios = await _repository.ObterTodos();
            List < UsuarioResponseDTO > response = new();
            foreach(var usuario in usuarios)
            {
                response.Add(await TransformarUsuarioEmResponse(usuario));
            }
            return response;
        }

        private async Task<UsuarioResponseDTO> TransformarUsuarioEmResponse(Usuario usuario)
        {
            UsuarioResponseDTO response = new UsuarioResponseDTO();

            response.Id = usuario.Id;
            response.Nome = usuario.Nome;
            response.DataNascimento = usuario.DataNascimento;
            response.Email = usuario.Email;
            response.Cargo = usuario.Cargo.ToString();

            return response;
        }


    }
}
