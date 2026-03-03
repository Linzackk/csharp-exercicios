using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionaisNomeados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result1 = CalcularDesconto(500);
            double result2 = CalcularDesconto(desconto: 0.25, preco: 1000);

            Console.WriteLine($"{result1} - {result2}");
        }
        static double CalcularDesconto(double preco, double desconto = 0.10)
        {
            return preco * desconto;
        }
    }
}
