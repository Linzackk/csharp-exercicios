using System.ComponentModel.DataAnnotations;

namespace CadastroLoginProtegido.DTOs.Login
{
    public class LoginInfoDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Senha { get; set; }
    }
}
