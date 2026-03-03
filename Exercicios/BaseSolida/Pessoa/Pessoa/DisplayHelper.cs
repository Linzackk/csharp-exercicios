using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    enum Menu
    {
        AdicionarPessoa = 1,
        MostrarPessoas = 2,
        FiltrarPorIdade = 3,
        FiltrarPorPerfil = 4,
        Sair = 5
    }
    internal class DisplayHelper
    {
        
        public static void MostrarFiltroPorPerfil()
        {
            Perfil perfilAlvo = InputHelper.LerPerfilPessoa();
            List<PessoaClasse> pessoasFiltradas = Program.FiltrarPorPerfil(perfilAlvo);
            MostrarPessoas(pessoasFiltradas);
        }

        public static void MostrarFiltroPorIdade()
        {
            int idadeAlvo = InputHelper.LerIdadePessoa("Idade Alvo");
            List<PessoaClasse> pessoasFiltradas = Program.FiltrarPorIdade(idadeAlvo);
            MostrarPessoas(pessoasFiltradas);
        }
        public static void MostrarPerfis()
        {
            MostrarSeparacao();
            foreach (Perfil opcao in Enum.GetValues(typeof(Perfil)))
            {
                Console.WriteLine($"[ {(int)opcao} ] - {opcao}");
            }
            MostrarSeparacao();
        }
        public static void MostrarPessoas(List<PessoaClasse> usuarios)
        {
            MostrarSeparacao();
            foreach (PessoaClasse pessoa in usuarios)
            {
                Console.WriteLine(
                    $"Nome: {pessoa.Nome}\n" +
                    $"Idade: {pessoa.Idade}\n" +
                    $"Perfil: {pessoa.Perfil}\n"
                    );
            }
            MostrarSeparacao();
        }
        public static void MostrarSeparacao()
        {
            int tamanhoSeparacao = 30;
            for (int i = 0; i < tamanhoSeparacao; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public static void MostrarMenu()
        {
            MostrarSeparacao();
            foreach (var opcao in Enum.GetValues(typeof(Menu)))
            {
                Console.WriteLine($"[ {(int)opcao} ] - {opcao}");
            }
            MostrarSeparacao();
        }
    }
}
