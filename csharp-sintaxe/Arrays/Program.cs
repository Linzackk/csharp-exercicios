using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Insira um Numero: ");
                string numberInput = Console.ReadLine();

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} - ");
            }

            Console.ReadLine();
        }
    }
}
