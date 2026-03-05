using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPersonagensRPG
{
    public abstract class Personagem : IAtaque
    {
        private readonly string nome;
        public string Nome => this.nome;

        private int vidaMaxima;
        public int VidaMaxima
        {
            get => this.vidaMaxima;
            protected set
            {
                if (value <= 0) { throw new ArgumentException("Vida maxima deve ser maior que 0."); }
                this.vidaMaxima = value;
            }
        }
        private int vidaAtual;
        public int VidaAtual
        {
            get => this.vidaAtual;
            protected set
            {
                if (value > this.VidaMaxima) { this.vidaAtual = this.vidaMaxima; }
                else if (value < 0) { this.vidaAtual = 0; }
                else { this.vidaAtual = value; }
            }
        }

        private int danoAtaque;
        public int DanoAtaque
        {
            get => this.danoAtaque;
            protected set
            {
                if (value <= 0) { throw new ArgumentException("Dano precisa ser minimo 1."); }
                this.danoAtaque = value;
            }
        }

        private int valorDefesa;
        public int ValorDefesa
        {
            get => this.valorDefesa;
            protected set
            {
                if (value <= 0) { throw new ArgumentException("Defesa precisa ser minimo 1."); }
                this.valorDefesa = value;
            }
        }

        private int manaMaxima;
        public int ManaMaxima
        {
            get => this.manaMaxima;
            set
            {
                if (value <= 0) { throw new ArgumentException("Vida maxima deve ser maior que 0."); }
                this.manaMaxima = value;
            }
        }

        private int manaAtual;
        public int ManaAtual
        {
            get => this.manaAtual;
            set
            {
                if (value > this.ManaMaxima) { this.manaAtual = this.ManaMaxima; }
                else if (value < 0) { throw new ArgumentException("Mana Atual não pode ser negativa");}
                else this.manaAtual = value;
            }
        }

        public Personagem(string nome, int vidaMaxima, int manaMaxima, int danoAtaque, int defesa)
        {
            this.nome = nome;
            this.VidaMaxima = vidaMaxima;
            this.VidaAtual = vidaMaxima;
            this.ManaMaxima = manaMaxima;
            this.ManaAtual = manaMaxima;
            this.DanoAtaque = danoAtaque;
            this.ValorDefesa = defesa;
        }

        public abstract void UsarHabilidade();
        public abstract void ExecutarAtaque(Personagem alvo);
        public virtual void ReceberDano(int dano)
        {
            int danoFinal = dano - ValorDefesa;
            if (danoFinal < 0)  
                danoFinal = 0;
            this.VidaAtual -= danoFinal;
        }
        public virtual void ReceberCura(int cura)
        {
            this.VidaAtual += cura;
        }
    }
}
