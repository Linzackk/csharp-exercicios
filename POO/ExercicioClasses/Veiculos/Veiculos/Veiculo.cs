using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public abstract class Veiculo
    {
        private string modelo;
        private string marca;
        private int ano;
        private int velocidade;
        public int Velocidade
        {
            get => velocidade;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Velocidade não pode ser negativa.");
                if (value > velocidadeMaxima)
                    return;
                velocidade = value;
            }
        }

        public string Modelo { get => modelo;  }
        public string Marca { get => marca; }
        public int Ano { get => ano; }

        private int velocidadeMaxima;
        public Veiculo(string marca, string modelo, int ano, int velocidadeMaxima = 0)
        {
            if (string.IsNullOrEmpty(marca))
                throw new ArgumentException("Marca inválida");
            this.marca = marca;

            if (string.IsNullOrEmpty(modelo))
                throw new ArgumentException("Modelo inválido");
            this.modelo = modelo;

            if (ano > 2026 || ano < 1900)
                throw new ArgumentException("Ano inválido");
            this.ano = ano;

            Velocidade = 0;

            if (velocidadeMaxima < 0)
                throw new ArgumentException("Velocidade Máxima inválida");
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public abstract void Acelerar();
        public abstract void Frear();

        public override string ToString()
        {
            return
                $"Informações:\n" +
                $"Modelo: {this.Modelo}\n" +
                $"Marca: {this.Marca}\n" +
                $"Ano: {this.Ano}";
        }
    }
}
