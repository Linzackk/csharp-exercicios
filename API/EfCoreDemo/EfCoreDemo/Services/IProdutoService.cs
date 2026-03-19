using EfCoreDemo.DTO;
using EfCoreDemo.Models;

namespace EfCoreDemo.Services
{
    public interface IProdutoService
    {
        Task<ProdutoResponseDTO> AdicionarProduto(ProdutoRequestDTO produto);
        Task<ProdutoResponseDTO> ObterProduto(int id);
        Task<IReadOnlyList<ProdutoResponseDTO>> ObterTodosProdutos();
        Task RemoverProduto(int id);
        Task AtualizarProduto(ProdutoRequestDTO produtoAtualizado, int id);
        Task AtualizarParcialmenteProduto(ProdutoPatchDTO informacaoParaAtualizar, int id);
    }
}
