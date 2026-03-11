using ApiFuncionarios.Repository;
using ApiFuncionarios.Models;
using ApiFuncionarios.Exceptions;

namespace ApiFuncionarios.Services
{
    public class FuncionarioService
    {
        private IFuncionarioRepository _repository;
        public FuncionarioService(IFuncionarioRepository repository)
        {
            this._repository = repository;
        }

        public IReadOnlyList<Funcionario> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public Funcionario ObterPorId(int id)
        {
            var funcionario = _repository.ObterPorId(id);
            if (funcionario == null)
                throw new NotFoundException("Funcionário");

            return funcionario;
        }

        public void CriarNovo(Funcionario funcionario)
        {
            _repository.CriarNovo(funcionario);
        }

        public void Atualizar(Funcionario funcionario, int id)
        {
            var funcionarioCadastrado = ObterPorId(id);
            funcionario.DefinirId(id);
            _repository.Atualizar(funcionario);
        }

        public void Deletar(int id)
        {
            var funcionarioCadastrado = ObterPorId(id);
            _repository.Deletar(funcionarioCadastrado);
        }
    }
}

