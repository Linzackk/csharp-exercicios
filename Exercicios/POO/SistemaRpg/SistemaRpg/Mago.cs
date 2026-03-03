using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRpg
{
    internal class Mago : Personagem
    {
        public Mago(string nome, int vida) : base(nome, vida) { }

        protected override int CalcularDano()
        {
            return (int)DanoDeItens.BolaDeFogo;
        }
        public override void Atacar()
        {
            Console.WriteLine($"{this.Nome} invocou bola de fogo causando {CalcularDano()} de dano.");
        }
        public override void ReceberDano(int dano)
        {
            base.ReceberDano(dano + 1);
        }
    }
}
