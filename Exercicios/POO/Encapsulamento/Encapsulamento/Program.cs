using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var conta = new ContaBancaria(50);
                conta.Sacar(50.01);
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            try
            {
                var conta = new ContaBancaria(50);
                conta.Depositar(-50);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            try
            {
                var conta = new ContaBancaria(-50);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            try
            {
                var conta = new ContaBancaria(50);
                conta.Depositar(5);
                conta.Sacar(3);
                Console.WriteLine(conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
