using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeTDD
{
    public class UsuarioService
    {
        private IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario ObterUsuario(int id)
        {
            var usuario = _repository.BuscarPorId(id);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            return usuario;
        }
    }
}
