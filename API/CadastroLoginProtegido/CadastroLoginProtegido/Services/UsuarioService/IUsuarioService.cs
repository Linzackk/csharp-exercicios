using CadastroLoginProtegido.DTOs.Usuario;

namespace CadastroLoginProtegido.Services.UsuarioService
{
    public interface IUsuarioService
    {
        Task<UsuarioResponseDTO> CriarUsuario(UsuarioCreateDTO user);
        Task<UsuarioResponseDTO> ObterPorId(int id);
        Task<IReadOnlyCollection<UsuarioResponseDTO>> ObterTodos();
    }
}
