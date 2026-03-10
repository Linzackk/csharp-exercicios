using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Gerente : Funcionario
    {
        public int TamanhoTime { get; }
        public Gerente(string nome, decimal salario, int tamanhoTime):
            base (nome, salario)
        {
            TamanhoTime = tamanhoTime;
        }

        public void AprovarFerias(Funcionario funcionario)
        {
            Console.WriteLine($"{this.Nome} aprovou ferias de {funcionario.Nome}");
        }

        public override void Trabalhar()
        {
            Console.WriteLine($"{this.Nome} está gerenciando.");
        }
    }
}
