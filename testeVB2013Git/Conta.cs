using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeVB2013Git
{
    class Conta
    {
        public int numero;
        public double saldo;

        public Cliente titular;

        public void Sacar(double valor)
        {
            this.saldo -= valor;

        }

        public void Depositar(double valor)
        { 
            this.saldo += valor; 
        }

    }
}
