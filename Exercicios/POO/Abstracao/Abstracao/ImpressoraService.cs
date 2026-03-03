using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class ImpressoraService  : IEnviarRelatorio
    {
        public void EnviarRelatorio(Relatorio relatorio)
        {
            Console.WriteLine("Imprimindo Relatório...");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine(
                $"Relatório Impresso.\n" +
                $"Relatório: {relatorio.Nome}\n" +
                $"Destinatario: {relatorio.Responsavel.Nome}\n"
            );
        }
    }
}
