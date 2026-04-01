using Integracao.Models;
using Integracao.Repository;

namespace Integracao.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository;
        public UsuarioService(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _repository.Adicionar(usuario);
        }

        public Usuario ObterPorId(int id)
        {
            var usuario = _repository.ObterPorId(id);
            Console.WriteLine(usuario == null ? "NULL" : "ENCONTRADO");
            if (usuario == null)
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            return usuario;
        }

        public void AtualizarUsuario(UsuarioUpdateDTO userAtualizado, int id)
        {
            if (userAtualizado.Nome == null && userAtualizado.Email == null && userAtualizado.Telefone == null)
                throw new ArgumentException("Nenhuma informação fornecida.");

            Console.WriteLine("ANTES DE PROCURAR");
            var usuario = ObterPorId(id);
            Console.WriteLine("DEPOIS DE PROCURAR DEU NOT FOUND.");
            if (userAtualizado.Nome != null)
                usuario.Nome = userAtualizado.Nome;

            if (userAtualizado.Email != null)
                usuario.Email = userAtualizado.Email;

            if (userAtualizado.Telefone != null)
                usuario.Telefone = userAtualizado.Telefone;

            _repository.Atualizar(usuario);
        }

        public void DeletarUsuario(int id)
        {
            var usuario = ObterPorId(id);
            _repository.Deletar(usuario);
        }
    }
}
