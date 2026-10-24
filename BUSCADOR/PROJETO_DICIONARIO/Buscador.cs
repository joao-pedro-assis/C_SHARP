using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO_DICIONARIO
{
    public class Buscador : IBuscador
    {
        public Dicionario BancoPalavras { get; set; }
        public Buscador()
        {
            BancoPalavras = new Dicionario();
        }

        public void Dicionario(List<string> Palavras)
        {
            foreach (var item in Palavras) 
            {
                BancoPalavras.Adicionar(item);
            }
        }

        public List<string> Search(string criterio)
        {
            List<string> resultado = BancoPalavras.Palavras.Where(i => i.StartsWith(criterio)).ToList();
            return resultado;
        }
    }
}
