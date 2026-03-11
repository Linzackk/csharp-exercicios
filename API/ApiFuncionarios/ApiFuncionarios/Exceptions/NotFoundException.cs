namespace ApiFuncionarios.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string objetoNaoEncontrado)
            : base($"{objetoNaoEncontrado} não encontrado.") { }
    }
}
