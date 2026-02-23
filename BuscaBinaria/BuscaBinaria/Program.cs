using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando array de 10");
            int[] array10 = GerarArray(10);
            Console.WriteLine("Criando array de 100");
            int[] array100 = GerarArray(100);
            Console.WriteLine("Criando array de 1000");
            int[] array1000 = GerarArray(1000);
            Console.WriteLine("Criando array de 1000000");
            int[] array1000000 = GerarArray(1000000);

            MedirTempoBuscaBinaria(array10, 8);
            MedirTempoBuscaBinaria(array10, 8);
            MedirTempoBuscaBinaria(array100, 8);
            MedirTempoBuscaBinaria(array1000, 8);
            MedirTempoBuscaBinaria(array1000000, 8);
        }

        static void MedirTempoBuscaBinaria(int[] array, int numAlvo)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int indexAlvo = BuscaBinaria(array, numAlvo);
            stopwatch.Stop();
            long ticks = stopwatch.ElapsedTicks;

            // No .NET 7 ou superior, você pode converter para microssegundos
            double micro = (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1_000_000;
            Console.WriteLine($"O Número está na posição: {indexAlvo}\n\t{array[indexAlvo]}");
            Console.WriteLine($"Essa busca demorou: {micro}ms");
        }

        static int[] GerarArray(int tamanho)
        {
            int[] array = new int[tamanho];

            for (int i = 0;  i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }

        static int BuscaBinaria(int[] array, int numeroAlvo)
        {
            bool encontrado = false;
            int menor = 0;
            int maior = array.Length;
            int media = 0;
            while (!encontrado)
            {
                media = (menor + maior) / 2;
                if (array[media] == numeroAlvo) { encontrado = true; }
                if (array[media] < numeroAlvo)
                {
                    menor = media;
                }
                else
                {
                    maior = media;
                }
            }
            return media;
        }
    }
}
