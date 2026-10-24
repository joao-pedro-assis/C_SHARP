using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALIDADOR_DOCUMENTOS
{
    public abstract class pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }


        public pessoa (string Nome,string Endereco)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;

        }
        public abstract bool validar(); //assinatura do método
        //principio da substituição de Liskov (Barbara Liskov)
    }
}
