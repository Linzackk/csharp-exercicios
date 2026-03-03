using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeProdutos
{
    public static class OutputService
    {
        public static void MostrarErro(Exception error)
        {
            Console.WriteLine($"Erro: {error.Message}");
        }
    }
}
