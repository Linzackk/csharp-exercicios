using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; }
        public decimal Salario { get; }

        public Funcionario(string nome, decimal salario)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome Inválido.");
            this.Nome = nome;

            if (salario < 600)
                throw new ArgumentException("Salário Inválido.");
            this.Salario = salario;
        }

        public abstract void Trabalhar();
    }
}
