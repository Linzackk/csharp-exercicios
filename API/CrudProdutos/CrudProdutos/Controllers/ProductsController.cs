using CrudProdutos.Exceptions;
using CrudProdutos.Models;
using CrudProdutos.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ProductService _service;
        public ProductsController(ProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult BuscarProdutos()
        {
            try
            {
                var produtos = _service.ObterTodos();
                return Ok(produtos);
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarProdutoPorId(int id)
        {
            try
            {
                var produto = _service.ObterProdutoPorId(id);
                return Ok(produto);
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor.");
            }            
        }

        [HttpPost]
        public IActionResult CriarNovoProduto([FromBody] Produto produto)
        {
            try
            {
                _service.CriarNovoProduto(produto);
                return CreatedAtAction(nameof(BuscarProdutoPorId), new { id = produto.Id }, produto);
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(int id, [FromBody] Produto produto)
        {
            try
            {
                _service.AtualizarProduto(produto, id);
                return NoContent();
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarProduto(int id)
        {
            try
            {
                _service.DeletarProduto(id);
                return NoContent();
            }
            catch (ProdutoNaoEncontradoException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor.");
            }
        }
    }
}
