using AcessoComJWT.Models;
using AcessoComJWT.Utils;

namespace AcessoComJWT.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        
        private readonly List<Usuario> _context = new List<Usuario>()
        {
            new Usuario(1, "admin", RolesUsuario.Admin, "admin@admin.com", "admin123"),
            new Usuario(2, "comum", RolesUsuario.User, "comum@comum.com", "comum123")
        };
        private static int ultimoId = 2;
        public void AdicionarUsuario(Usuario usuario)
        {
            usuario.DefinirId(++ultimoId);
            _context.Add(usuario);
            Console.WriteLine(usuario.Id); 
        }

        public Usuario? ObterUsuario(int id)
        {
            return _context.Find(usuario => usuario.Id == id);
        }

        public IReadOnlyCollection<Usuario> ListarUsuarios()
        {
            return _context.ToList();
        }

        public Usuario? ValidarCredenciais(string email, string senha)
        {
            return _context.Find(usuario => usuario.Email == email && usuario.Senha == senha);
        }
    }
}
