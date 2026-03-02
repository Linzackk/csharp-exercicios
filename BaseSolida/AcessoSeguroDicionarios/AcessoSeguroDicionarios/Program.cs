using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoSeguroDicionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var idades = new Dictionary<string, int>()
            {
                { "Isaac", 20 },
                { "Carol", 19 },
                { "Maria", 35 },
                { "Jao", 15 },
            };

            ProcurarPorMaria(idades);
            idades.Remove("Maria");
            ProcurarPorMaria(idades);
        }
        
        static void ProcurarPorMaria(Dictionary<string, int> idades)
        {
            if (idades.TryGetValue("Maria", out int value))
            {
                Console.WriteLine($"Maria tem {value} anos\n");
            }
            else
            {
                Console.WriteLine("Maria não foi encontrada.\n");
            }
        }
    }
}
