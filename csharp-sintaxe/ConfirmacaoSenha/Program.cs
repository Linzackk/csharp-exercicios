using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmacaoSenha
{
    /*
     * Pedir a senha e guardar
     * Pedir novamente a senha
     * Ver se elas são iguais
     */ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma Senha: ");
            string password = Console.ReadLine();

            if (!CheckPasswordEmpty(password)) { 
                Console.WriteLine("Insira novamente a Senha: ");
                string confirmationPassword = Console.ReadLine();
                if (confirmationPassword.Equals(password))
                {
                    Console.WriteLine("Senhas Iguais!");
                }
                else
                {
                    Console.WriteLine("Senhas não sao Iguais.");
                }
            }
            Console.ReadLine();
        }
        private static bool CheckPasswordEmpty(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Senha inválida.");
                return true;
            }
                
            else 
                return false;
        }
    }
}
