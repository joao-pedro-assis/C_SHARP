using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTA_BANCARIA
{
    public class ContaCorrente : Conta
    {
        public double limite {  get; set; }
        public ContaCorrente(string Numero, string Cliente, double limite) : base(Numero, Cliente)
        {
            this.limite = limite;
        }
        public override void Debitar(double valor)
        {
            double disponivel = Saldo + limite;
            if (valor <= disponivel) 
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
