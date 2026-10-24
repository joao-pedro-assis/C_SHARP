using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_PAGAMENTO
{
    public class Estagiario:IFuncionario
    {
        public string Cod { get; set; }
        public string Nome { get; set; }
        public double HorasTabalhadas { get; set; }
        public double SalarioHora { get; set; }
        public Estagiario(string Cod, string Nome, double SalarioHora)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.SalarioHora = SalarioHora;
        }
        public double Calcular()
        {
            // calculo do salario bruto
            double sb = SalarioHora * 80;
            return sb;
        }
        public string Identificacao()
        {
            return String.Format("Codigo: {0}\tNome : {1}\tSalarioHora:{2}", Cod, Nome, SalarioHora.ToString("C2"));

        }
    }
}
