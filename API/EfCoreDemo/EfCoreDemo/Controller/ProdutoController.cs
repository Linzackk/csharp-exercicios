using EfCoreDemo.Data;
using EfCoreDemo.DTO;
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
        public async Task<IActionResult> CriarNovoProduto([FromBody] ProdutoRequestDTO produto)
        {
            var produtoCriado = await _service.AdicionarProduto(produto);
            return CreatedAtAction(nameof(ProcurarProdutoPorId), new { id = produtoCriado.Id }, produtoCriado);
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
        public async Task<IActionResult> AtualizarProduto([FromBody] ProdutoRequestDTO produtoAtualizado, int id)
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

        [HttpPatch("{id}")]
        public async Task<IActionResult> AtualizarParcialmenteProduto([FromBody] ProdutoPatchDTO produto, int id)
        {
            await _service.AtualizarParcialmenteProduto(produto, id);
            return NoContent();
        }
    }
}

