using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTamanhoDefinido
{
    internal class Program
    {
        /* Pegar dois inteiros (num e tamanho)
         * Criar um array de int com o tamanho inserido
         * fazer um loop e inserir o index do loop * num no array
         * mostrar array final
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o tamanho do array: ");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = num * (i + 1);
            }

            foreach (int showNum in array)
            {
                Console.WriteLine($"{showNum} ");
            }
            Console.ReadLine();
        }
    }
}
