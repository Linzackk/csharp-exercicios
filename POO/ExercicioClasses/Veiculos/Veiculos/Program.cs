using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[3]
            {
                new Carro("chevrolet", "Kadet", 2002, 2),
                new Moto("honda", "CG", 2026),
                new Caminhao("volkswagen", "Facchini", 2010, 10000)
            };

            foreach(var veiculo in veiculos)
            {
                Console.WriteLine(veiculo.ToString());
            }
        }
    }
}
