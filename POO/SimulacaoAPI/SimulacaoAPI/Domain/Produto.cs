using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAPI.Domain
{
    public class Produto
    {
        private readonly string nome;
        public string Nome => this.nome;

        private readonly decimal preco;
        public decimal Preco => this.preco;

        private readonly int quantidade;
        public int Quantidade => this.quantidade;

        public Produto(string nome, decimal preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        public decimal CalcularTotal()
        {
            return this.Preco * this.Quantidade;
        }
    }
}
