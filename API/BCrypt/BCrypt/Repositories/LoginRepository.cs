using BCrypt.Models;

namespace BCrypt.Repositories
{
    public class LoginRepository
    {
        private readonly List<Login> _usuarios = new List<Login>();
        private static int id = 0;
        
        public void CriarNovoLogin(Login login)
        {
            login.Id = ++id;
            _usuarios.Add(login);
        }
        public IReadOnlyCollection<Login> ListarUsuarios()
        {
            return _usuarios.ToList();
        }
        public Login? ObterPorId(string email)
        {
            return _usuarios.Find(login => login.Email == email);
        }
    }
}
