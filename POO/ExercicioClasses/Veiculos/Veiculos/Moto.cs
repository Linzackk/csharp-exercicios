using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Moto : Veiculo
    {
        public Moto(string marca, string modelo, int ano)
            : base(marca, modelo, ano, 120) { }

        public override void Acelerar()
        {
            this.Velocidade += 10;
        }
        public override void Frear()
        {
            this.Velocidade -= 3;
        }
    }
}
