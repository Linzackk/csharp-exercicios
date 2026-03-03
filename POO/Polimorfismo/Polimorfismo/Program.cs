using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal abstract class Frete
    {
        public virtual decimal CalcularFrete()
        {
            return 30;
        }
    }
    internal class FreteNormal : Frete
    {
        public override decimal CalcularFrete()
        {
            return base.CalcularFrete();
        }
    }
    internal class FreteExpresso : Frete
    {
        public override decimal CalcularFrete()
        {
            return base.CalcularFrete() * 1.5M;
        }
    }

    internal class FreteInternacional : Frete
    {
        public override decimal CalcularFrete()
        {
            return base.CalcularFrete() + 50 ;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Frete normal = new FreteNormal();
            Frete express = new FreteExpresso();
            Frete internacional = new FreteInternacional();

            var fretes = new List<Frete>() { normal, express, internacional};

            foreach (var frete in fretes)
            {
                Console.WriteLine(frete.CalcularFrete());
            }
        }
    }
}
