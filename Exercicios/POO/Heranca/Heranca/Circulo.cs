using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Circulo : FormasGeometricas
    {
        private double raio;

        public Circulo(double raio)
        {
            this.Raio = raio;
        }

        public double Raio { get => raio; private set => raio = value; }

        public override double CalcularArea()
        {
            return Math.PI * (raio * raio);
        }
    }
}
