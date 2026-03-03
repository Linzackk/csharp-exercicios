using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRpg
{
    enum DanoDeItens
    {
        Soco = 1,
        Espadada = 3,
        BolaDeFogo = 4,
    }
    internal class Personagem
    {
        public Personagem(string nome, int vida)
        {
            this.Nome = nome;
            this.vidaAtual = vida;
            this.vidaMaxima = vida;
        }
        private string nome;
        public string Nome
        {
            get => nome;
            private set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Nome inválido."); }
                if (value.Length <= 3) { throw new ArgumentException("Nome curto demais."); }
                nome = value;
            }
        }
        private int vidaAtual;
        public int VidaAtual
        {
            get => vidaAtual;
            private set
            {
                if (value < 0) { vidaAtual = 0; return; }
                vidaAtual = value;
            }
        }
        private int vidaMaxima;
        public int VidaMaxima {
            get => vidaMaxima;
        }

        public virtual void ReceberDano(int dano)
        {
            if (dano <= 0) { Console.WriteLine("Nenhum dano foi causado."); }
            else { this.vidaAtual -= dano; }
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(
                $"Herói: {this.Nome}\n" +
                $"Vida: {this.VidaAtual} / {this.VidaMaxima}\n"
                );
        }

        public virtual void Atacar() 
        {
            Console.WriteLine($"{this.Nome} socou causando {CalcularDano()} de dano.");
        }

        protected virtual int CalcularDano()
        {
            return (int)DanoDeItens.Soco;
        }

    }
}
