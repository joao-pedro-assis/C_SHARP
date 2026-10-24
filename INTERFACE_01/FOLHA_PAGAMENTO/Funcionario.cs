using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_PAGAMENTO
{
    public class Funcionario : IFuncionario
    {
        public string Cod {  get; set; }
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double SalarioHora { get; set; }

        public Funcionario(string Cod,string Nome,double HorasTrabalhadas,double SalarioHora)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.HorasTrabalhadas = HorasTrabalhadas;
            this.SalarioHora = SalarioHora;
        }
        public double Calcular()
        {
            // calculo do salario bruto
            double sb = SalarioHora * HorasTrabalhadas;
            return sb;
        }

        public string Identificacao()
        {
            return String.Format("Codigo: {0}\tNome : {1}\tSalarioHora:{2},Horas:{3}",Cod,Nome,SalarioHora.ToString("C2"),HorasTrabalhadas);

        }
    }
}
