using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTA_BANCARIA
{
    public abstract class Conta
    {
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public double Saldo { get; set; }   
        
        public Conta( string Numero, string Cliente) { 
            this.Numero = Numero;   
            this.Cliente = Cliente;
            this.Saldo = 0;
        }
        public Conta() : this("0", "") { }
        public void Creditar (double valor)
        {
            Saldo += valor;
        }
        public abstract void Debitar(double valor);
        
    }
}
