using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutosAvancada
{
    public abstract class Produto
    {
        private readonly string nome;
        private readonly decimal precoBase;

        public string Nome => this.nome;
        public decimal PrecoBase => this.precoBase;

        public Produto(string nome, decimal precoBase)
        {
            this.nome = nome;
            this.precoBase = precoBase;
        }

        public virtual decimal CalcularPreco() 
        {
            return PrecoBase;
        }
    }
}
