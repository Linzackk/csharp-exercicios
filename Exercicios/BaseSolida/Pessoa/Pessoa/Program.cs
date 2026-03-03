using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class Program
    {
        
        static List<PessoaClasse> usuarios = new List<PessoaClasse>();
        static void Main(string[] args)
        {
            

            bool usandoSistema = true;

            while (usandoSistema)
            {
                DisplayHelper.MostrarMenu();
                int opcao = InputHelper.LerInputOpcao();

                switch (opcao)
                {
                    case (int)Menu.Sair:
                        usandoSistema = false;
                        break;
                    case (int)Menu.AdicionarPessoa:
                        AdicionarPessoa();
                        break;
                    case (int)Menu.MostrarPessoas:
                        DisplayHelper.MostrarPessoas(usuarios);
                        break;
                    case (int)Menu.FiltrarPorPerfil:
                        DisplayHelper.MostrarFiltroPorPerfil();
                        break;
                    case (int)Menu.FiltrarPorIdade:
                        DisplayHelper.MostrarFiltroPorIdade();
                        break;
                    default:
                        Console.WriteLine("Opcao Inválida.");
                        break;
                }
            }
        }
        public static List<PessoaClasse> FiltrarPorIdade(int idadeAlvo)
        {
            return usuarios.Where(x => x.Idade == idadeAlvo).ToList();
        }

        public static List<PessoaClasse> FiltrarPorPerfil(Perfil perfilAlvo)
        {
            return usuarios.Where(x => x.Perfil == perfilAlvo).ToList();
        }
        static void AdicionarPessoa()
        {
            string nome = InputHelper.LerNomePessoa();
            int idade = InputHelper.LerIdadePessoa("Sua Idade");
            Perfil perfil = InputHelper.LerPerfilPessoa();
            var pessoa = new PessoaClasse(nome, idade, perfil);
            usuarios.Add(pessoa);
            Console.WriteLine("Você foi adicionado com sucesso.");
        }
    }
}
