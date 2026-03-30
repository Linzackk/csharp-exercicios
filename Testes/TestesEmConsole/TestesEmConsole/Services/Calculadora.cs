using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteServices.Services
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Divisão por zero não é permitida.");
            return a / b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
