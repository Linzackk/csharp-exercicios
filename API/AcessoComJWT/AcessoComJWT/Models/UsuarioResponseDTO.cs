using AcessoComJWT.Utils;

namespace AcessoComJWT.Models
{
    public class UsuarioResponseDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    }
}
