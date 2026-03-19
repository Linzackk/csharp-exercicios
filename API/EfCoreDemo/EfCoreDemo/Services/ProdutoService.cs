using AutoMapper;
using EfCoreDemo.DTO;
using EfCoreDemo.Exceptions;
using EfCoreDemo.Models;
using EfCoreDemo.Repository;

namespace EfCoreDemo.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;
        public ProdutoService(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProdutoResponseDTO> AdicionarProduto(ProdutoRequestDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Nome))
                throw new ArgumentException("Nome Inválido");

            if (dto.Preco <= 0)
                throw new ArgumentException("Preço precisa ser maior que 0");

            var produto = _mapper.Map<Produto>(dto);
            await _repository.AdicionarProduto(produto);
            return _mapper.Map<ProdutoResponseDTO>(produto);
        }

        public async Task<ProdutoResponseDTO> ObterProduto(int id)
        {
            var produto = await _repository.ProcurarProduto(id);
            if (produto == null)
                throw new ProdutoNotFound();

            return _mapper.Map<ProdutoResponseDTO>(produto);
        }

        public async Task<IReadOnlyList<ProdutoResponseDTO>> ObterTodosProdutos()
        {
            var produtos = await _repository.ProcurarTodosProdutos();
            return _mapper.Map<IReadOnlyList<ProdutoResponseDTO>>(produtos);
        }

        public async Task RemoverProduto(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido.");

            await _repository.RemoverProduto(id);
        }

        public async Task AtualizarProduto(ProdutoRequestDTO produtoAtualizado, int id)
        {
            var produtoRepository = await _repository.ProcurarProduto(id);
            if (produtoRepository == null)
                throw new ProdutoNotFound();

            if (produtoAtualizado.Nome.Length <= 3)
                throw new ArgumentException("Nome inválido.");

            if (produtoAtualizado.Preco <= 0)
                throw new ArgumentException("Preço inválido.");

            var produto = _mapper.Map<Produto>(produtoAtualizado);
            produto.Id = id;
            await _repository.AtualizarProduto(produto);
        }

        public async Task AtualizarParcialmenteProduto(ProdutoPatchDTO produto, int id)
        {
            var produtoRepository = await _repository.ProcurarProduto(id);

            if (produtoRepository == null)
                throw new ProdutoNotFound();

            if (produto.Nome != null)
                produtoRepository.Nome = produto.Nome;

            if (produto.Preco != null)
                produtoRepository.Preco = produto.Preco.Value;

            await _repository.AtualizarProduto(produtoRepository);
        }
    }
}
