using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLHA_PAGAMENTO
{
    public interface IFuncionario
    {
        string Cod { get; set; }
        string Nome { get; set; }
        double SalarioHora { get; set; }
        double Calcular(); // assinatura do método
        string Identificacao(); 

    }
}
