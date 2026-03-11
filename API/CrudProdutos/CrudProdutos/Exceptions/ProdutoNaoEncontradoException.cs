namespace CrudProdutos.Exceptions
{
    public class ProdutoNaoEncontradoException : Exception
    {
        public ProdutoNaoEncontradoException()
            : base("Produto não encontrado.") { }
    }
}
