using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2]
            {
                1, 2
            };

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                listNumbers.Add(i);
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write($"{listNumbers[i]} ");
            }

            Console.ReadLine();
        }
    }
}
