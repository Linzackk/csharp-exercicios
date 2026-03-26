using CadastroLoginProtegido.Models;

namespace CadastroLoginProtegido.Repositories.UsuarioRepository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();
        private static int ultimoId = 0;
        public async Task CriarUsuario(Usuario usuario)
        {
            usuario.DefinirId(++ultimoId);
            _usuarios.Add(usuario);
        }
        public async Task<Usuario?> ObterPorId(int id)
        {
            return _usuarios.Find(user => user.Id == id);
        }
        public async Task<IReadOnlyCollection<Usuario>> ObterTodos()
        {
            return _usuarios.ToList();
        }
    }
}
