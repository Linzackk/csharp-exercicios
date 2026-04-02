using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public interface IUsuarioRepository
    {
        Usuario ObterPorNomeEEmail(string nome, string email);
    }
}
