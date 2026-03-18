using EfCoreDemo.Models;

namespace EfCoreDemo.Repository
{
    public interface IProdutoRepository
    {
        Task AdicionarProduto(Produto produto);
        Task<Produto> ProcurarProduto(int id);
        Task<IReadOnlyList<Produto>> ProcurarTodosProdutos();
        Task RemoverProduto(int id);
        Task AtualizarProduto(Produto produtoAtualizado);
    }
}
