using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaObjetoLista
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var isaac = new Pessoa("Isaac", 20);
            var carol = new Pessoa("Carol", 19);
            var maria = new Pessoa("Maria", 59);

            var pessoas = new List<Pessoa>() { isaac, carol};
            ProcurarPorMaria(pessoas);

            pessoas.Add(maria);
            ProcurarPorMaria(pessoas);
            Console.WriteLine($"{pessoas[2].Nome} - {pessoas[2].Idade} ");

        }

        static void ProcurarPorMaria(List<Pessoa> lista)
        {
            var pessoaAlvo = lista.Find(pessoa => pessoa.Nome == "Maria");
            if (pessoaAlvo == null)
            {
                Console.WriteLine("Maria não Foi Encontrada");
            }
            else
            {
                AlterarIdadeDeMaria(pessoaAlvo);
            }
        }

        static void AlterarIdadeDeMaria(Pessoa maria)
        {
            maria.Idade = 35;
        }
    }
}
