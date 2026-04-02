using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public Usuario ProcurarUsuario(string nome, string email)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome não pode ser inválido.");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email não pode ser inválido.");

            var usuario = _repository.ObterPorNomeEEmail(nome, email);
            if (usuario == null)
                throw new ArgumentException("Usuário não encontrado.");

            return usuario;
        }
        public void ProcUsr(string n, string e)
        {
            if (n != "")
            {
                var u = new Usuario(n, e);
                _rep.Save(u);
                Console.WriteLine("ok");
            }
        }

    }
}
