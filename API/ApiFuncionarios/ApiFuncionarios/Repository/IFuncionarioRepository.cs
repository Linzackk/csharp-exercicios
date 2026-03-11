using ApiFuncionarios.Models;

namespace ApiFuncionarios.Repository
{
    public interface IFuncionarioRepository
    {
        IReadOnlyList<Funcionario> ObterTodos();
        Funcionario? ObterPorId(int id);
        void CriarNovo(Funcionario funcionario);
        bool Atualizar(Funcionario funcionario);
        bool Deletar(Funcionario funcionario);
    }
}
