namespace CadastroLoginProtegido.Models
{
    public class Login
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Login(int id, string email, string password)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email não pode estar vazio");

            if (password.Length <= 6)
                throw new ArgumentException("Senha deve ter pelo menos 6 caracteres");

            Id = id;
            Email = email;
            Password = password;
        }
        public void DefinirId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID deve ser maior que 0.");
            Id = id;
        }
    }
}
