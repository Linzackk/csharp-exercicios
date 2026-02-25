using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu Nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Insira a sua Idade: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("\nOlá " + name + " Você tem " + age + " anos");

            if (age >= 20) {
                Console.WriteLine("     Ta ficando velho ein...");
            }
            else
            {
                Console.WriteLine("     Ta novo ainda...");
            }

        }
    }
}
