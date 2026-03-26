using CadastroLoginProtegido.Models;
using System.ComponentModel.DataAnnotations;

namespace CadastroLoginProtegido.DTOs.Usuario
{
    public class UsuarioCreateDTO
    {
        [Required]
        [MinLength(3)]
        public string Nome { get; set; }

        [Required]
        public DateOnly DataNascimento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Cargos Cargo { get; set; }
    }
}
