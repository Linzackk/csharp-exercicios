using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProjetos
{
    enum StatusTarefa
    {
        Pendente = 0,
        EmAndamento = 1,
        Concluida = 2,
    }

    enum PrioridadeTarefa
    {
        Baixa = 0,
        Media = 1,
        Alta = 2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario("Isaac", "user@email.com");
            var gerente = new Gerente("Isaac", "gerente@email.com");
            var dev = new Desenvolvedor("Isaac", "dev@email.com");
            var tester = new Testador("Isaac", "tester@email.com");

            var users = new List<Usuario>() { usuario, gerente, dev, tester };

            foreach (var user in users)
            {
                Console.WriteLine(user);
                var tarefa = new Tarefa("Title", "Descricao muito bem detalhada", StatusTarefa.EmAndamento, PrioridadeTarefa.Baixa);
                tarefa.MostrarResumo();
                tarefa.AlterarStatus(StatusTarefa.Concluida, user);
                tarefa.AlterarResponsavel(usuario, user);
                tarefa.AlterarPrioridade(PrioridadeTarefa.Alta, user);
                tarefa.MostrarResumo();
            }
        }
    }
}

