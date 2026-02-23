using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            int idade2 = 16;

            IfElse(idade);
            IfElse(idade2);

            SwitchCase(idade);
            SwitchCase(idade2);

            OperadorTernario(idade);
        }

        static void IfElse(int idade)
        {
            if (idade >= 18)
            {
                Console.WriteLine("Maior de Idade");
            }
            else
            {
                Console.WriteLine("Menor de Idade");
            }
        }

        static void OperadorTernario(int idade)
        {
            Console.WriteLine(idade >= 18 ? "Maior" : "Menor");
        }

        static void SwitchCase(int idade)
        {
            switch (idade)
            {
                case 18:
                    Console.WriteLine("Tem 18 anos.");
                    break;
                case 20:
                    Console.WriteLine("Tem 20 anos.");
                    break;
                default:
                    Console.WriteLine("Outro valor");
                    break;
            }
        }
    }
}
