using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public string LinguagemProgramacao { get; }
        public Desenvolvedor(string nome, decimal salario, string linguagemProgramacao)
            : base(nome, salario)
        {
            this.LinguagemProgramacao = linguagemProgramacao;
        }

        public override void Trabalhar()
        {
            Console.WriteLine($"{this.Nome} está desenvolvendo em {this.LinguagemProgramacao}.");
        }
    }
}
