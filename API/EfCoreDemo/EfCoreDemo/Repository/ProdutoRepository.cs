using EfCoreDemo.Data;
using EfCoreDemo.Models;
using EfCoreDemo.Exceptions;

namespace EfCoreDemo.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public async Task<Produto> ProcurarProduto(int id)
        {
            var produto = _context.Produtos.Find(id);
            return produto;
        }

        public async Task<IReadOnlyList<Produto>> ProcurarTodosProdutos()
        {
            return _context.Produtos.ToList();
        }

        public async Task AtualizarProduto(Produto produtoAtualizado)
        {
            _context.Produtos.Update(produtoAtualizado);
            _context.SaveChanges();
        }

        public async Task RemoverProduto(int id)
        {
            _context.Produtos.Remove(await ProcurarProduto(id));
            _context.SaveChanges();
        }
    }
}
