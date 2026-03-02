using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CadastroComNull
{
    class Pessoa
    {
        private string nome;
        private string apelido;
        private int? idade;

        public string Nome 
        { 
            get => nome; 
            set => nome = value ?? "Não informado."; 
        }
        public string Apelido 
        { 
            get => apelido; 
            set => apelido = value ?? "Não informado."; 
        }
        public int? Idade 
        { 
            get => idade;
            set => idade = value; 
        }

        public Pessoa(string nome, string apelido, int? idade)
        {
            this.Nome = nome;
            this.Apelido = apelido;
            this.Idade = idade;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(
                $"Nome: {this.Nome}\n" +
                $"Apelido: {this.Apelido}\n" +
                $"Idade: {this.Idade?.ToString() ?? "Não Informada"}"
            );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Isaac", null, 20);
            Pessoa pessoa2 = new Pessoa(null, "Cabeçudo", 19);
            Pessoa pessoa3 = new Pessoa("Carol", "Carolzinha", null);

            var pessoas = new Pessoa[3] { pessoa1, pessoa2, pessoa3};
            foreach (Pessoa pessoa in pessoas)
            {
                pessoa.MostrarInformacoes();   
            }
        }
    }
}
