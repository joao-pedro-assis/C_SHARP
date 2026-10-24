using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_DICIONARIO
{
    public class Dicionario
    {
        public List<string> Palavras { get; set; }
        public Dicionario()
        {
            Palavras = new List<string>();
        }
        public void Adicionar(string Palavra)
        {
            if (string.IsNullOrEmpty(Palavra) == false)
            {
                Palavras.Add(Palavra);
            }
        }
    }
}
