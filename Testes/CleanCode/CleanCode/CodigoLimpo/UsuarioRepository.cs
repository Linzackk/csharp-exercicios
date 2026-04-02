using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario ObterPorNomeEEmail(string nome, string email)
        {
            return new Usuario("Isaac", "isaac@isaac.com");
        }
    }
}
