using ApiFuncionarios.Models;
using ApiFuncionarios.Exceptions;

namespace ApiFuncionarios.Repository
{
    public class InMemoryFuncionarioRepository : IFuncionarioRepository
    {
        static private int ultimoId = 0;
        private List<Funcionario> funcionariosCadastrados = new();

        private int EncontrarIndex(int id)
        {
            return funcionariosCadastrados.FindIndex(func => func.Id == id);
        }
        public IReadOnlyList<Funcionario> ObterTodos()
        {
            return funcionariosCadastrados.ToList();
        }

        public Funcionario? ObterPorId(int id)
        {
            int index = EncontrarIndex(id);
            if (index == -1)
            {
                return null;
            }
            return funcionariosCadastrados[index];
        }

        public void CriarNovo(Funcionario funcionario)
        {
            funcionario.DefinirId(++ultimoId);
            funcionariosCadastrados.Add(funcionario);
        }

        public bool Atualizar(Funcionario funcionario)
        {
            if (funcionario == null)
                return false;

            funcionario.AlterarCargo(funcionario.Cargo);
            funcionario.AlterarNome(funcionario.Nome);
            funcionario.AlterarSalario(funcionario.Salario);
            return true;
        }
        
        public bool Deletar(Funcionario funcionario)
        {
            if (funcionario == null)
                return false;

            funcionariosCadastrados.Remove(funcionario);
            return true;
        }
    }
}
