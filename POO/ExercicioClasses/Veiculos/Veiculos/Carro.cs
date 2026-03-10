using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Carro : Veiculo
    {
        private int numeroDePortas;
        public int NumeroDePortas { get => numeroDePortas; }
        public Carro(string marca, string modelo, int ano, int numeroDePortas)
            : base(marca, modelo, ano, 80)
        {
            this.numeroDePortas = numeroDePortas;
        }

        public override void Acelerar()
        {
            this.Velocidade += 5;
        }

        public override void Frear()
        {
            this.Velocidade -= 4;
        }
        public override string ToString()
        {
            return
                $"{base.ToString()}\n" +
                $"Quantidade de Portas: {this.NumeroDePortas}";
        }
    }
}
