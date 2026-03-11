namespace ApiFuncionarios.Models
{
    public class Funcionario
    {
        private int id;
        public int Id { get => id; }

        private string nome;
        public string Nome { get => nome; }

        private string cargo;
        public string Cargo { get => cargo; }

        private decimal salario;
        public decimal Salario { get => salario; }

        public Funcionario(string nome, string cargo , decimal salario)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException("Nome deve possuir um valor.");

            this.nome = nome;

            if (string.IsNullOrEmpty(cargo))
                throw new ArgumentNullException("Cargo deve possuir um valor.");

            this.cargo = cargo;

            if (salario <= 700)
                throw new ArgumentException("Salário deve maior que 700");

            this.salario = salario;
        }

        public void DefinirId(int novoId)
        {
            this.id = novoId;
        }

        public void AlterarNome(string novoNome)
        {
            if (string.IsNullOrEmpty(novoNome))
                throw new ArgumentNullException("Nome deve possuir um valor.");

            this.nome = novoNome;
        }

        public void AlterarCargo(string novoCargo)
        {
            if (string.IsNullOrEmpty(novoCargo))
                throw new ArgumentNullException("Cargo deve possuir um valor.");

            this.cargo = novoCargo;
        }

        public void AlterarSalario(decimal novoSalario)
        {
            if (novoSalario <= 700)
                throw new ArgumentException("Salário deve maior que 700");

            this.salario = novoSalario;
        }
    }
}
