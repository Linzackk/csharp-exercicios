using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDicionarios
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
                { "Jao", 15 }
            };

            MostrarIdades(idades);
        }

        static void MostrarIdades(Dictionary<string, int> idades)
        {
            foreach (KeyValuePair<string, int> infos in idades)
            {
                Console.WriteLine($"{infos.Key}: {infos.Value} anos");
            }
            Console.WriteLine();
        }
    }
}
