using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10]
            {
                2, 1, 3, 7, 8, 10, 4, 6, 5, 9
            };

            ShowNumberArray(numbers);
            Array.Sort(numbers);
            ShowNumberArray(numbers);
            Array.Reverse(numbers);
            ShowNumberArray(numbers);

            Array.Clear(numbers, 0, numbers.Length);
            ShowNumberArray(numbers);

            Console.ReadLine();
        }

        static void ShowNumberArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write($"{num} ");
            }
            Console.Write("\n");
        }
    }
}
