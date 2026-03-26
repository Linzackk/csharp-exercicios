using CadastroLoginProtegido.Models;

namespace CadastroLoginProtegido.DTOs.Usuario
{
    public class UsuarioResponseDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
    }
}
