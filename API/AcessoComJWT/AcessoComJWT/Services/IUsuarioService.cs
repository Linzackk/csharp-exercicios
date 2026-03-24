using AcessoComJWT.Models;

namespace AcessoComJWT.Services
{
    public interface IUsuarioService
    {
        public UsuarioResponseDTO AdicionarUsuario(UsuarioCreateDTO usuario);
        public UsuarioResponseDTO ObterUsuario(int id);
        public IReadOnlyCollection<UsuarioResponseDTO> ListarUsuarios();
        public string FazerLogin(LoginRequestDTO login);
    }
}
