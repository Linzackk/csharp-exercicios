using AcessoComJWT.Utils;

namespace AcessoComJWT.Models
{
    public class UsuarioCreateDTO
    {
        public string Nome { get; set; }
        public RolesUsuario Role { get; set; }
        public string Email { get; set; }
    }
}
