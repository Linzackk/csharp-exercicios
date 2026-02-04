using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Program
    {
        /*
         * Perguntar ao usuario quantas vezes quer mostrar a tabela
         * Mostrar a tabela X vezes com Loop
         */ 
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um Numero: ");
            string numberInput = Console.ReadLine();

            if (int.TryParse(numberInput, out int number))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} * {1:00} = {2}", number, i, number * i);
                }
            }
            else
            {
                Console.WriteLine("Inválido, tente novamente");
            }
        }
    }
}
