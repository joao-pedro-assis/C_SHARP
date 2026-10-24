using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_PAGAMENTO
{
    public class Aposentado : IFuncionario
    {
        public string Cod { get ; set; }
        public string Nome { get; set; }
        public double SalarioHora { get ; set ; }
        public Aposentado(string Cod, string Nome, double SalarioHora)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.SalarioHora = SalarioHora;
        }
        public double Calcular()
        {
            double sb = SalarioHora * 160;
            if (sb > 7786.02) return 7782.02;
            else return sb;

        }

        public string Identificacao()
        {
            return String.Format("Codigo: {0}" +
                "\tNome : {1}" +
                "\tSalarioHora:{2}"
               , Cod, Nome, SalarioHora.ToString("C2"));
        }
    }
}
