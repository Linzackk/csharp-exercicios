using EfCoreDemo.Exceptions;
using EfCoreDemo.Models;
using EfCoreDemo.Repository;

namespace EfCoreDemo.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task AdicionarProduto(Produto produto)
        {
            // Mapear do DTO de entrada para a Classe
            await _repository.AdicionarProduto(produto);
        }

        public async Task<Produto> ObterProduto(int id)
        {
            var produto = await _repository.ProcurarProduto(id);
            if (produto == null)
            {
                Console.WriteLine("Erro!!!");
                Console.WriteLine(produto);
                Console.WriteLine("Produto é nulo? ", produto == null);
                throw new ProdutoNotFound();
            }
                

            // Aqui eu deveria mapear para o DTO de saída
            return produto;
        }

        public async Task<IReadOnlyList<Produto>> ObterTodosProdutos()
        {
            // Aqui eu deveria pegar e mapear para criar o DTO de saída
            return await _repository.ProcurarTodosProdutos();
        }

        public async Task RemoverProduto(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido.");

            await _repository.RemoverProduto(id);
        }

        public async Task AtualizarProduto(Produto produtoAtualizado, int id)
        {
            if (produtoAtualizado.Id <= 0)
                throw new ArgumentException("ID inválido.");

            if (produtoAtualizado.Nome.Length <= 3)
                throw new ArgumentException("Nome inválido.");

            if (produtoAtualizado.Preco <= 0)
                throw new ArgumentException("Preço inválido.");

            // Aqui eu deveria fazer a montagem da classe conforme as informações do DTO
            produtoAtualizado.Id = id;
            await _repository.AtualizarProduto(produtoAtualizado);
        }
    }
}
