using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;

            Console.WriteLine(Multiplicar(a, b));
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}
