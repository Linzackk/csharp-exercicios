using EfCoreDemo.Data;
using EfCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreDemo.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarNovoProduto([FromBody] Produto produto)
        {
            try
            {
                if (string.IsNullOrEmpty(produto.Nome))
                    throw new ArgumentException("Nome Inválido.");

                if (produto.Preco <= 0)
                    throw new ArgumentException("Preço inválido.");

                _context.Add(produto);
                _context.SaveChanges();
                return CreatedAtAction(nameof(ProcurarProdutoPorId), new {id =  produto.Id}, produto);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult ProcurarProdutoPorId(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("ID inválido");

                var produtoProcurado = _context.Produtos.Find(id);
                if (produtoProcurado == null)
                    return NotFound();

                return Ok(produtoProcurado);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ProcurarProdutos()
        {
            var produtos = _context.Produtos.ToList();
            if (produtos.Count == 0)
                return NotFound("Nenhum objeto cadastrado");

            return Ok(produtos);
        }
    }
}

