using System.ComponentModel.DataAnnotations;

namespace EfCoreDemo.DTO
{
    public class ProdutoRequestDTO
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }
    }
}
