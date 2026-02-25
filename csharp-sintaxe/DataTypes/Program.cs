using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string idadeTexto = "20";
            int age = Convert.ToInt32(idadeTexto);
            float altura = 1.70F;
            double peso = 70.4D;
            decimal saldo = 30.70M;

            Console.WriteLine("Você tem: ");
            Console.WriteLine("Idade: " + age);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Conta bancária: " + saldo);
        }
    }
}
