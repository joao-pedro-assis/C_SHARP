using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTA_BANCARIA
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string Numero, string Cliente) :base (Numero, Cliente) 
        {
            this.Saldo = 0;
        }
        public override void Debitar(double valor)
        {         
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                throw new Exception("Saldo insuficiente");
            }
        }
    }
}
