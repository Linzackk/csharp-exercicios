using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeTDD
{
    public interface IUsuarioRepository
    {
        Usuario? BuscarPorId(int id);
    }
}
