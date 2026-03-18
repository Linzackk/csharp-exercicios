namespace EfCoreDemo.Exceptions
{
    public class ProdutoNotFound : Exception
    {
        public ProdutoNotFound()
            : base("Produto não encontrado") { }
    }
}
