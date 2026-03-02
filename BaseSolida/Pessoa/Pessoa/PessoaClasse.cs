using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    enum Perfil
    {
        Admin,
        Usuario,
        Visitante
    }
    internal class PessoaClasse
    {
        private string nome;
        public string Nome 
        {
            get => this.nome;
            set => this.nome = value; 
        }

        private int idade;
        public int Idade
        {
            get => this.idade;
            set => this.idade = value;
        }

        private Perfil perfil;
        public Perfil Perfil
        {
            get => this.perfil;
            set => this.perfil = value;
        }

        public PessoaClasse(string nome, int idade, Perfil perfil)
        {
            this.nome = nome;
            this.idade = idade;
            this.perfil = perfil;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {this.Nome} e eu tenho {this.Idade} anos");
            Console.WriteLine($"Meu Perfil é {this.Perfil}");
            Console.WriteLine($"Minha idade é: {ValidarIdade()}");
        }

        public string ValidarIdade()
        {
            if ( this.Idade < 0 || this.Idade > 120) { return "Inválida"; }
            else { return "Válida"; }
        }
    }
}
