using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormasGeometricas circulo = new Circulo(3);
            FormasGeometricas quadrado = new Quadrado(5);
            FormasGeometricas triangulo = new Triangulo(5, 9);
            var formas = new FormasGeometricas[3] { circulo, quadrado, triangulo };
            foreach( var forma in formas)
            {
                Console.WriteLine((forma.CalcularArea()));
            }
        }
    }
}
