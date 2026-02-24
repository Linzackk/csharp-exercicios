using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarCapacidadeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int>(10) { 1, 2, 3, 4, 5 };

            MostrarInformacoesLista(numeros);

            numeros.Clear();

            MostrarInformacoesLista(numeros);

            numeros.TrimExcess();

            MostrarInformacoesLista(numeros);
        }
        static void MostrarInformacoesLista(List<int> lista)
        {
            Console.WriteLine(
                $"Count: {lista.Count}\n" +
                $"Capacity: {lista.Capacity}"
                );
        }
    }
}
