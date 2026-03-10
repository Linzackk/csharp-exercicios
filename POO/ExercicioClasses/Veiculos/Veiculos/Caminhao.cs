using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Caminhao : Veiculo
    {
        private int capacidadeCarga;
        public int CapacidadeCarga { get => this.capacidadeCarga; }
        public Caminhao(string marca, string modelo, int ano, int capacidadeCarga) 
            : base(marca, modelo, ano, 100)
        {
            this.capacidadeCarga = capacidadeCarga;
        }

        public override void Acelerar()
        {
            this.Velocidade += 7;
        }

        public override void Frear()
        {
            this.Velocidade -= 5;
        }
        public override string ToString()
        {
            return
                $"{base.ToString()}\n" +
                $"Carga total em Kg: {this.CapacidadeCarga}";
        }
    }
}
