using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gerente = new Gerente("Pedro", 10520.32M, 7);
            var dev = new Desenvolvedor("Isaac", 3500, "C#");
            var estagiario = new Estagiario("Isaac 2", 1590, "UNIP");
            Funcionario[] funcionarios = new Funcionario[3]
            {
                gerente, dev, estagiario
            };
            foreach (var funcionario in funcionarios)
            {
                funcionario.Trabalhar();
            }
            gerente.AprovarFerias(dev);
            estagiario.Estudar();
            
        }
    }
}
