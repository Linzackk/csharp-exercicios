using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRpg
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int vida) : base(nome, vida) { }

        protected override int CalcularDano()
        {
            return (int)DanoDeItens.Espadada;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{this.Nome} cortou causando {CalcularDano()} de dano.");
        }

        public override void ReceberDano(int dano)
        {
            base.ReceberDano(dano - 2);
        }
    }
}
