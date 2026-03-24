using AcessoComJWT.Utils;

namespace AcessoComJWT.Models
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public RolesUsuario Role { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string nome, RolesUsuario role, string email, string senha)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome não pode ser vazio.");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email não pode ser vazio.");

            if (string.IsNullOrEmpty(senha))
                throw new ArgumentException("Senha não pode ser vazio.");

            Nome = nome;
            Role = role;
            Email = email;
            Senha = senha;
        }

        public Usuario(int id, string nome, RolesUsuario role, string email, string senha)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome não pode ser vazio.");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email não pode ser vazio.");

            if (string.IsNullOrEmpty(senha))
                throw new ArgumentException("Senha não pode ser vazio.");

            Id = id;
            Nome = nome;
            Role = role;
            Email = email;
            Senha = senha;
        }

        public void DefinirId(int novoId)
        {
            Id = novoId;
        }
    }
}
