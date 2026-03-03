using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoAdicionandoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int>() { 10, 20, 30};
            Console.WriteLine($"Tamanho: {numeros.Capacity}");
            numeros.Add(40);
            numeros.Add(50);
            Console.WriteLine($"Tamanho: {numeros.Capacity}");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
