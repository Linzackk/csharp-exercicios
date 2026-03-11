using CrudProdutos.Models;
using System.Collections.Generic;

namespace CrudProdutos.Repository
{
    public interface IProductsRepository
    {
        IReadOnlyList<Produto> ObterTodos();
        Produto? ObterProdutoPorId(int id);
        void CriarNovoProduto(Produto produto);
        bool AtualizarProduto(Produto produto);
        bool DeletarProduto(int id);
    }
}
