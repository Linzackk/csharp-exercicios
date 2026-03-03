using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Quadrado : FormasGeometricas
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.Lado = lado;
        }

        public double Lado { get => lado; private set => lado = value; }

        public override double CalcularArea()
        {
            return lado * lado;
        }
    }
}
