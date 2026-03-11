using CrudProdutos.Models;
using System.Collections.Generic;
namespace CrudProdutos.Repository
{
    public class InMemoryProductsRepository : IProductsRepository
    {
        private List<Produto> produtosCadastrados = new();

        private static int ultimoId = 0;
        public IReadOnlyList<Produto> ObterTodos()
        {
            return produtosCadastrados.ToList();
        }
        public Produto? ObterProdutoPorId(int id)
        {
            return produtosCadastrados.Find(produto => produto.Id == id);
        }
        public void CriarNovoProduto(Produto produto)
        {
            produto.DefinirId(++ultimoId);
            produtosCadastrados.Add(produto);
        }

        public bool DeletarProduto(int id)
        {
            int index = EncontrarIndex(id);
            if (index == -1)
                return true;

            produtosCadastrados.RemoveAt(index);
            return false;
        }
        public bool AtualizarProduto(Produto produto)
        {
            int index = EncontrarIndex(produto.Id);
            if (index == -1)
                return false;

            var produtoCadastrado = produtosCadastrados[index];
            produtoCadastrado.AtualizarPreco(produto.Preco);
            produtoCadastrado.AtualizarNome(produto.Nome);
            return true;
        }

        private int EncontrarIndex(int id)
        {
            return produtosCadastrados.FindIndex(p => p.Id == id);
        }
    }
}
