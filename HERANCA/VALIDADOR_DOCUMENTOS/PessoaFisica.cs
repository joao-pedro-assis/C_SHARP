using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VALIDADOR_DOCUMENTOS
{
    public class PessoaFisica:pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome, string endereco,string cpf) : base(nome, endereco)
        {
            this.CPF = cpf;
        }
        public override bool validar() 
        {

            char[] digitos = CPF.ToCharArray();
            int peso = 10;
            int soma = 0;
            for (int i=0; i < 9; i++)
            {
                int p = peso * Convert.ToInt16(digitos[i].ToString());
                peso--;
                soma += p;
            }
            int DV1;
            int resto = soma % 11;
            if (resto < 1) DV1 = 0; else DV1 =11 - resto;
            if(DV1 != Convert.ToInt16(digitos[9].ToString()))
            {
                return false;
            }
            peso = 11;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                int p = peso * Convert.ToInt16(digitos[i].ToString());
                peso--;
                soma += p;
            }
            int DV2;
            resto = soma % 11;
            if (resto < 2) DV2 = 0; else DV2 = 11 - resto;
            if (DV2 != Convert.ToInt16(digitos[10].ToString()))
            {
                return false;
            }
            return true;//retorna verdadeiro o teste do documento
        }

    }
}
