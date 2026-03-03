using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Triangulo : FormasGeometricas
    {
        private double altura;
        private double largura;

        public Triangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double Altura { get => altura; private set => altura = value; }
        public double Largura { get => largura; private set => largura = value; }

        public override double CalcularArea()
        {
            return (altura * largura) / 2;
        }
    }
}
