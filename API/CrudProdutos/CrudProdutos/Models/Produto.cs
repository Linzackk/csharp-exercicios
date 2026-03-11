namespace CrudProdutos.Models
{
    public class Produto
    {
        private int id;
        private string nome;
        private decimal preco;
        
        public int Id { get => id; }
        public string Nome { get => nome; }
        public decimal Preco { get => preco; }
        public Produto(string nome, decimal preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public void DefinirId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id inválido. Não pode ser negativo.");
            this.id = id;
        }
        public void AtualizarNome(string novoNome)
        {
            if (string.IsNullOrEmpty(novoNome))
                throw new ArgumentException("Nome não pode ser vazio.");

            if (novoNome.Length <= 3)
                throw new ArgumentException("Nome curto demais minimo 3 caracteres.");

            this.nome = novoNome;
        }

        public void AtualizarPreco(decimal novoPreco)
        {
            if (novoPreco <= 0)
                throw new ArgumentException("Preço deve ser maior que 0.");

            this.preco = novoPreco;
        }
    }
}
