using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Funcionario
    {
        private int id;
        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID precisa ser maior que 0.");
                id = value;
            }
        }

        private string nome;
        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Nome deve possuir um valor");

                if (value.Length <= 3)
                    throw new ArgumentException("Nome deve ter pelo menos 3 caracteres");

                nome = value;
            }
        }

        private string cargo;
        public string Cargo
        {
            get => cargo;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Cargo deve possuir um valor.");

                if (value != "Desenvolvedor" && value != "Gerente" && value != "Estagiario")
                    throw new ArgumentException("Cargo deve ser 'Desenvolvedor', 'Gerente' ou 'Estagiario'");

                cargo = value;
            }
        }

        private List<Ponto> pontos;
        public IReadOnlyList<Ponto> Pontos 
        { 
            get => pontos; 
        }

        public Funcionario(int id, string nome, string cargo, List<Ponto> pontos)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            this.pontos = pontos ?? new List<Ponto>();
        }

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
        }

        public void AlterarCargo(string novoCargo)
        {
            Cargo = novoCargo;
        }

        public void AdicionarPonto(Ponto novoPonto)
        {
            this.pontos.Add(novoPonto);
        }
    }
}
