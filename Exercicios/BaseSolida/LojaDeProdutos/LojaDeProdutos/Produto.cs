using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeProdutos
{
    enum StatusEstoque
    {
        Disponivel,
        Esgotado,
        Reservado
    }
    internal class Produto
    {
        private int id;
        private string nome;
        private decimal preco;
        private StatusEstoque status;

        public string Nome 
        { 
            get => nome; 
            set
            {
                if (!(ValidarService.ValidarNomeProduto(value))) { throw new Exception("Nome Inválido"); }
                else { this.nome = value; }
            } 
        }
        public decimal Preco 
        {
            get => preco; 
            set
            {
                if (!(ValidarService.ValidarPrecoProduto(value))) { throw new Exception("Preço Inválido"); }
                else { this.preco = value; }
            }
        }
        public StatusEstoque Status { 
            get => status; 
            set => status = value; 
        }

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        public Produto(int id, string nome, decimal preco, StatusEstoque status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Status = status;
        }

        public override string ToString()
        {
            return (
                $"Produto: {this.Nome}\n" +
                $"Preco: R${this.Preco}\n" +
                $"Estoque: {this.Status}\n"
                );
        }

        public void AtualizarPreco( decimal novoPreco)
        {
            this.Preco = novoPreco;
        }
    }
}
