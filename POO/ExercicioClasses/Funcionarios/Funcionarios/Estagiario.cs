using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Estagiario : Funcionario
    {
        public string Faculdade { get; }
        public Estagiario(string nome, decimal salario, string faculdade) 
            : base(nome, salario)
        {
            this.Faculdade = faculdade;
        }

        public override void Trabalhar()
        {
            Console.WriteLine($"{this.Nome} está trabalhando (tentando).");
        }

        public void Estudar()
        {
            Console.WriteLine($"{this.Nome} está estudando em {this.Faculdade}.");
        }

    }
}
