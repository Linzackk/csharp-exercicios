using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoPedidos
{
    internal class Item
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return this.preco; }   
            set { this.preco = value; }
        }
        private int quantidade;
        public int Quantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }

        public Item(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double SubTotal()
        {
            return this.preco * this.quantidade;
        }
    }
}
