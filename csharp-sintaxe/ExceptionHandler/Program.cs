using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insira um numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro de numero muito grande pra variavel pequena");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de conversão, texto pra numero.");
            }
            catch (Exception e)
            {   

                Console.WriteLine("Erro padrão, pega todos: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
