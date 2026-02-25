using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        /*
         * Loop que vai de um a X
         * Multiplos de 3 = Fizz
         * Multiplos de 5 = Buzz
         * Multiploes de ambos = FizzBuzz
        */ 
        static void Main(string[] args)
        {
            Console.WriteLine("Insira até que numero você quer verificar: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int times))
            {
                for (int i = 1; i <= times; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Input Inválido");
            }
        }
    }
}
