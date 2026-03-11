using CrudProdutos.Exceptions;
using CrudProdutos.Models;
using CrudProdutos.Repository;

namespace CrudProdutos.Services
{
    public class ProductService
    {
        private readonly IProductsRepository _repository;

        public ProductService(IProductsRepository repository)
        {
            this._repository = repository;
        }
        public IReadOnlyList<Produto> ObterTodos()
        {
            var data = _repository.ObterTodos();
            if (data.Count <= 0)
                throw new ProdutoNaoEncontradoException();

            return data;
        }

        public Produto ObterProdutoPorId(int id)
        {
            var produto = _repository.ObterProdutoPorId(id);
            if (produto == null)
                throw new ProdutoNaoEncontradoException();

            return produto;
        }

        public void CriarNovoProduto(Produto produto)
        {
            _repository.CriarNovoProduto(produto);
        }

        public void DeletarProduto(int id)
        {
            var produto = ObterProdutoPorId(id);
            _repository.DeletarProduto(id);
        }

        public void AtualizarProduto(Produto produtoNovo, int id)
        {
            ObterProdutoPorId(id);
            var produto = new Produto(produtoNovo.Nome, produtoNovo.Preco);
            produto.DefinirId(id);
            _repository.AtualizarProduto(produto);
        }

    }
}
