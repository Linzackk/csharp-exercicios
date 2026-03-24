using AcessoComJWT.Models;

namespace AcessoComJWT.Repository
{
    public interface IUsuarioRepository
    {
        public void AdicionarUsuario(Usuario usuario);
        public IReadOnlyCollection<Usuario> ListarUsuarios();
        public Usuario? ObterUsuario(int id);
        public Usuario? ValidarCredenciais(string email, string senha);
    }
}
