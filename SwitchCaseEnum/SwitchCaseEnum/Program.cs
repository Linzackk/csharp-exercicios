using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseEnum
{
    internal class Program
    {
        enum Menu
        {
            Login = 1,
            Informacoes = 2,
            Sair = 3
        }
        static void Main(string[] args)
        {
            Menu menu = Menu.Login;
            Menu menu2 = Menu.Informacoes;
            Menu menu3 = Menu.Sair;
            Menu invalido = (Menu)99;

            SelecionarOpcao(menu);
            SelecionarOpcao(menu2);
            SelecionarOpcao(menu3);
            SelecionarOpcao(invalido);
        }
        static void SelecionarOpcao(Menu opcao)
        {   
            if (!Enum.IsDefined(typeof(Menu), (int)opcao))
            {
                Console.WriteLine("Opcao Invalida!!!");
                return;
            }
            switch (opcao)
            {
                case Menu.Login:
                    Console.WriteLine("Logando...");
                    break;
                case Menu.Informacoes:
                    Console.WriteLine("Mostrando Informações...");
                    break;
                case Menu.Sair:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opcao Inválida.");
                    break;
            }
        }
    }
}
