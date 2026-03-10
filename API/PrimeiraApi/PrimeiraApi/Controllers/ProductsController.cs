using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Models;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok("Lista de Produtos");
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            if (id <= 0)
                return NotFound("Produto não encontrado");

            return Ok("Produto com ID " + id);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (product == null)
                return BadRequest("Produto inválido.");

            return CreatedAtAction(nameof(GetProductById), new {id = product.Id}, product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            if (id <= 0)
                return BadRequest("Id Inválido");

            return NoContent();
        }
    }
}
