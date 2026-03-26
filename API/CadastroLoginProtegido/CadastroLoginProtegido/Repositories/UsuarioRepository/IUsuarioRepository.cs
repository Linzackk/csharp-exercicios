using CadastroLoginProtegido.Models;

namespace CadastroLoginProtegido.Repositories.UsuarioRepository
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> ObterPorId(int id);
        Task<IReadOnlyCollection<Usuario>> ObterTodos();
        Task CriarUsuario(Usuario usuario);
    }
}
