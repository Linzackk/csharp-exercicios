using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeProdutos
{
    internal class ListaProdutos
    {
        private List<Produto> produtos;
        public List<Produto> Produtos
        {
            get 
            { 
                List<Produto> copia = new List<Produto>();
                foreach (Produto produto in this.produtos) { copia.Add(produto); }
                return copia;
            }
        }

        public ListaProdutos()
        {
            this.produtos = new List<Produto>();
        }
        public override string ToString()
        {
            string texto = "";
            foreach (var produto in this.Produtos)
            {
                texto += $"{produto.ToString()}\n";
            }
            return texto;
        }
        public void AdicionarProduto(Produto produto)
        {
            this.produtos.Add(produto);
        }

        public void AtualizarProduto(int id, decimal novoPreco)
        {
            var produtoAlvo = this.produtos.FindAll(produto => produto.Id == id);
            if (produtoAlvo.Count == 0) { throw new Exception("Produto não encontrado"); }
            else { produtoAlvo[0].AtualizarPreco(novoPreco); }
        }

        public void RemoverProduto(int id)
        {
            if (this.produtos.RemoveAll(produto => produto.Id == id) == 0)
            {
                throw new Exception("Produto não encontrado");
            }
        }

        public void MostrarListaProdutos()
        {
            if (this.Produtos.Count == 0)
            {
                Console.WriteLine("Nenhum Produto adicionado.\n");
            }
            else
            {
                Console.WriteLine(this.ToString());
            }
        }
    }
}
