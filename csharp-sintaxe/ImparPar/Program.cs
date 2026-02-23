using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    /* Criar duas listas de int, um para par outro para impar
     * Fazer um loop de 0 - 20
     * Adicionar o numero a sua lista correta
     * Mostrar a lista dos pares e impares separados
     */
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                    pares.Add(i);
                else
                    impares.Add(i);
            }
            ShowList(pares, "numeros pares");
            ShowList(impares, "numeros impares");

            Console.ReadLine();
        }
        static void ShowList(List<int> list, string message)
        {
            Console.WriteLine(message.ToUpper());
            foreach (int number in list)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
        }
    }
}
