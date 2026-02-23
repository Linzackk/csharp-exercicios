using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class InputHelper
    {
        public static string LerNomePessoa()
        {
            Console.WriteLine("Insira seu Nome: ");
            return Console.ReadLine();
        }
        public static int LerIdadePessoa(string message)
        {
            while (true)
            {
                Console.WriteLine($"Insira {message}: ");
                if (int.TryParse(Console.ReadLine(), out int idade)) 
                    return idade;
                Console.WriteLine("Input invalido");
            }
        }

        public static Perfil LerPerfilPessoa()
        {
            while (true)
            {
                DisplayHelper.MostrarPerfis();
                int opcao = LerInputOpcao();

                switch (opcao)
                {
                    case (int)Perfil.Admin:
                        return Perfil.Admin;

                    case (int)Perfil.Usuario:
                        return Perfil.Usuario;

                    case (int)Perfil.Visitante:
                        return Perfil.Visitante;

                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            }
        }
        public static int LerInputOpcao()
        {
            Console.WriteLine("Insira a Opcao que você gostaria:  ");
            if (int.TryParse(Console.ReadLine(), out int val))
            {
                return val;
            }
            else
            {
                return -1;
            }
        }
    }
}
