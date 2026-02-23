using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparacaoString
{
    /*
     * Pedir mensagem no Input
     * Mostrar ela na order
     * Mostrar ela Invertida
     */ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma Mensagem: ");
            string message = Console.ReadLine();

            if (String.IsNullOrEmpty(message)) {
                Console.WriteLine("Mensagem Inválida.");
            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.WriteLine($"{message[i]}");
                }
                Console.WriteLine();

                for (int i = message.Length -1; i >= 0; i--)
                {
                    Console.WriteLine($"{message[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}
