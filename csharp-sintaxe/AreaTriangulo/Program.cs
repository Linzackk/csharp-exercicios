using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    internal class Program
    {
        /* Pedir altura e largura do triangulo
         * Funcao pra calcular a area
         */
        static void Main(string[] args)
        {
            int altura = getIntInput("Altura");
            int largura = getIntInput("Largura");

            float area = calcTriangleArea(altura, largura);
            showTriangleArea(area);
            showTriangle(altura, largura);
            Console.ReadLine();
        }
        static int getIntInput(string message)
        {
            Console.WriteLine($"Insira um valor para {message}: ");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);
            return number;
        }
        static float calcTriangleArea(int height, int width)
        {
            float area = (height * width) / 2;
            return area;
        }

        static void showTriangleArea(float area)
        {
            Console.WriteLine($"A Área do Triângulo é de: {area}");
        }

        static void showTriangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                string line = string.Empty;
                for (int j = 0; j <= i; j++)
                {
                    line += "*";
                }
                Console.WriteLine(line);
            }
        }
    }
}
