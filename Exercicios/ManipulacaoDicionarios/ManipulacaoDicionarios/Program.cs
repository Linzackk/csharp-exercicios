using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoDicionarios
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

            PercorrerDicionarioParaAlterar(idades, 20);
        }

        static void PercorrerDicionarioParaAlterar(Dictionary<string, int> idades, int idadeMinima)
        {
            foreach (var chave in idades.Keys.ToList())
            {
                if (idades[chave] > idadeMinima)
                {
                    AlterarMenoresDe(idades, chave, idadeMinima);
                }
                Console.WriteLine($"{chave} - {idades[chave]} anos");
            }
        }

        static void AlterarMenoresDe(Dictionary<string, int> idades, string chave, int idadeMinima)
        {
            idades[chave] = idadeMinima;
        }
    }
}
