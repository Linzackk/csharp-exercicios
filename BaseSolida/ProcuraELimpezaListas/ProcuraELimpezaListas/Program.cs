using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcuraELimpezaListas
{
    internal class Program
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
        static void Main(string[] args)
        {
            var isaac = new Pessoa("Isaac", 20);
            var carol = new Pessoa("Carol", 19);
            var maria = new Pessoa("Maria", 59);
            var pedro = new Pessoa("Pedro", 59);
            var carla = new Pessoa("Carla", 34);
            var jao = new Pessoa("Jao", 40);

            var pessoas = new List<Pessoa>() { isaac, carol, maria, pedro, carla, jao };
            MostrarPessoas(pessoas);
            MostrarPessoas(FiltragemPorIdade(pessoas, 25));
            RemoverPorIdade(pessoas, 20);
            MostrarPessoas(pessoas);
        }

        static void MostrarPessoas(List<Pessoa> lista)
        {
            foreach(var pessoa in lista)
            {
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
            }
            Console.WriteLine();
        }

        static List<Pessoa> FiltragemPorIdade(List<Pessoa> lista, int idadeMinima)
        {
            var listaFiltrada = lista.FindAll((pessoa) => pessoa.Idade >= idadeMinima);
            return listaFiltrada;
        }

        static void RemoverPorIdade(List<Pessoa> lista, int idadeMinima)
        {
            lista.RemoveAll((pessoa) => pessoa.Idade < idadeMinima);
        }
    }
}
