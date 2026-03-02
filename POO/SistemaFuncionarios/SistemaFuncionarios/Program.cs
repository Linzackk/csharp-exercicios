using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Pedro", 2000);
            Funcionario gerente = new Gerente("Jorge", 5000);
            funcionario.MostrarInformacoes();
            gerente.MostrarInformacoes();

            funcionario.AumentarSalario(0.15);
            funcionario.MostrarInformacoes();
        }
    }
}
