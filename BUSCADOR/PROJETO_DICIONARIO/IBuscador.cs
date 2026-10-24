using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_DICIONARIO
{
    public interface IBuscador
    {
        void Dicionario(List<string> Palavras);
        List<string> Search(string criterio);
    }
}
