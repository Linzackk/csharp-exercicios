using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class WhatsappService : IEnviarRelatorio
    {
        public void EnviarRelatorio(Relatorio relatorio)
        {
            Console.WriteLine("Enviando Relatório Por WhatsApp...");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine(
                $"Relatório Enviado.\n" +
                $"Relatório: {relatorio.Nome}\n" +
                $"Destinatario: {relatorio.Responsavel.Nome}\n" +
                $"Email do Destinatário: {relatorio.Responsavel.NumTelefone}"
                );
        }
    }
}
