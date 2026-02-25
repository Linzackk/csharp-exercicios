using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = 2;

            double da = 8.1D;
            double db = 9.2D;

            var result1 = Calculadora.Multiplicar(a, b);
            var result2 = Calculadora.Multiplicar(da, db);
            var result3 = Calculadora.Multiplicar(a, b, c);

            Console.WriteLine($"Resultados: \n{result1}\n{result2}\n{result3}");
        }
    }

    class Calculadora
    {
        static public int Multiplicar(int a, int b) { return a * b; }
        static public int Multiplicar(int a, int b, int c) { return a * b * c; }
        static public double Multiplicar(double a, double b) { return a * b; }
    }
}
