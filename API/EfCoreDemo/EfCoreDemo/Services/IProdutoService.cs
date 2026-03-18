using EfCoreDemo.Models;

namespace EfCoreDemo.Services
{
    public interface IProdutoService
    {
        Task AdicionarProduto(Produto produto);
        Task<Produto> ObterProduto(int id);
        Task<IReadOnlyList<Produto>> ObterTodosProdutos();
        Task RemoverProduto(int id);
        Task AtualizarProduto(Produto produtoAtualizado, int id);
    }
}
