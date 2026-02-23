using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    /*
     * Criar e iniciar um array de numeros int
     * Funcao tem que retornar da soma de todos os numeros
     * extra: ver o tamanho do array
     * retornar -1 se for vazio
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = ReadIntInput("Tamanho Array");
            int[] array = CreateArray(arrayLenght);

            if (SumArray(array, out int sum)) 
            {
                Console.WriteLine($"Soma total do Array: {sum}");
            }
            else
            {
                Console.WriteLine("Não é possivel somar um Array Vazio.");
            }
            Console.ReadLine();
        }

        static int ReadIntInput(string message = "")
        {
            Console.WriteLine($"Insira um numero para {message}");
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool SumArray(int[] array, out int total)
        {
            total = 0;

            if (array.Length <= 0)
            {
                return false;
            }

            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return true;
        }
        static int[] CreateArray(int lenght )
        {
            int[] numberArray = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                numberArray[i] = i + 1;
            }
            return numberArray;
        }

    }
}
