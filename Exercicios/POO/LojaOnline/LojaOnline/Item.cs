using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class Item
    {
        private string nome;
        public string Nome
        {
            get => this.nome;
        }
        private decimal preco;
        public decimal Preco
        {
            get => this.preco;
        }
        private int quantidade;
        public int Quantidade
        {
            get => this.quantidade;
        }
        public Item(string nome, decimal preco, int quantidade)
        {
            if (string.IsNullOrEmpty(nome)) { throw new ArgumentException("Nome Inválido"); }
            if (nome.Length <= 3) { throw new ArgumentException("Nome Curto demais."); }
            this.nome = nome;

            if (preco <= 0) { throw new ArgumentException("Preço deve ser maior que 0."); }
            this.preco = preco;

            if (quantidade < 0) { throw new ArgumentException("Quantidade deve ser positiva."); }

            this.quantidade = quantidade;
        }

        public decimal CalcularTotal()
        {
            return this.Preco * this.Quantidade;
        }
    }
}
