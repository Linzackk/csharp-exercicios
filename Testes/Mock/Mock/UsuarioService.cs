using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock
{
    public class UsuarioService
    {
        public readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario? ObterUsuario(int id)
        {
            var usuario = _repository.BuscarPorId(id);

            if (usuario == null)
                throw new Exception("Usuario não encontrado.");

            return usuario;
        }
    }
}
