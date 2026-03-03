using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class ContaBancaria
    {
        private double saldo;
        public double Saldo
        {
            get => saldo;
            private set
            {
                if (value <  0) { throw new ArgumentException("Saldo não pode ser negativo."); }
                this.saldo = value;
            }
        }

        public void Sacar(double valor)
        {
            if (this.Saldo < valor) { throw new ArgumentException("Não é permitido saques acima do valor da conta"); }
            this.Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0) { throw new ArgumentException("Valor mínimo de depósito: R$0,01."); }
            this.Saldo += valor;
        }

        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }
    }
}
