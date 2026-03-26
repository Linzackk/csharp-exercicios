namespace CadastroLoginProtegido.Models
{
    public enum Cargos
    {
        Admin,
        Usuario,
    }
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateOnly DataNascimento { get; private set; }
        public string Email { get; private set; }
        public Cargos Cargo { get; private set; }

        public Usuario(string nome, DateOnly dataNascimento, string email, Cargos cargo)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome não pode estar vazio.");

            if (dataNascimento.CompareTo(DateOnly.FromDateTime(DateTime.Now)) > 0)
                throw new ArgumentException("Data de nascimento não pode ser no futuro.");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email não pode estar vazio.");

            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Cargo = cargo;
        }

        public void DefinirId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID deve ser maior que 0.");
            Id = id;
        }
    }
}
