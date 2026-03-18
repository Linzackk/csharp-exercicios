using EfCoreDemo.Data;
using EfCoreDemo.Exceptions;
using EfCoreDemo.Models;
using EfCoreDemo.Repository;
using EfCoreDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreDemo.Controller
{
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;
        
        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CriarNovoProduto([FromBody] Produto produto)
        {
            await _service.AdicionarProduto(produto);
            return CreatedAtAction(nameof(ProcurarProdutoPorId), new { id = produto.Id }, produto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ProcurarProdutoPorId(int id)
        {
            var produto = await _service.ObterProduto(id);
            return Ok(produto);
        }

        [HttpGet]
        public async Task<IActionResult> ProcurarProdutos()
        {
            var produtos = await _service.ObterTodosProdutos();
            return Ok(produtos);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarProduto([FromBody] Produto produtoAtualizado, int id)
        {
            await _service.AtualizarProduto(produtoAtualizado, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarProduto(int id)
        {
            await _service.RemoverProduto(id);
            return NoContent();
        }

        [HttpGet("teste-real")]
        public async Task<IActionResult> TesteReal()
        {
            await Task.Delay(10);
            throw new ProdutoNotFound(); // 👈 FORÇA AQUI
            throw new Exception("Erro real");
        }
    }
}

