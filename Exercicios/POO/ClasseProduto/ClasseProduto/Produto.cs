using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    internal class Produto
    {
        public Produto(string nome, double preco, int estoque)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Estoque = estoque;
        }

        public Produto(string nome)
        {
            this.Nome = nome;
        }

        public Produto() : this("Sem nome")
        {
            this.Nome = "Sem nome";
        }

        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Estoque { get; private set; }
    }
}
