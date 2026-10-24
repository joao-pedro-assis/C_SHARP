using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALIDADOR_DOCUMENTOS
{
    public class PessoaJuridica : pessoa
    {
        public string CNPJ {  get; set; } 
        public PessoaJuridica(string nome, string endereco, string CNPJ) : base(nome, endereco)
        {
            this.CNPJ = CNPJ;
        }

        public override bool validar()
        {
            char[] digitos = CNPJ.ToCharArray();
            int peso = 5;
            int soma = 0;
            for (int i = 0; i < 12; i++)
            {
                int p = peso * Convert.ToInt16(digitos[i].ToString());
                peso--;
                if (peso < 2) peso = 9;
                soma += p;
            }
            int DV1;
            int resto = soma % 11;
            if (resto < 2) DV1 = 0; else DV1 = 11 - resto;
            if (DV1 != Convert.ToInt16(digitos[12].ToString()))
                return false;

            peso = 6;
            soma = 0;

            for (int i = 0; i < 13; i++)
            {
                int p = peso * Convert.ToInt16(digitos[i].ToString());
                peso--;
                if (peso < 2) peso = 9;
                soma += p;
            }

            int DV2;
            resto = soma % 11;

            if (resto < 2) DV2 = 0; else DV2 = 11 - resto;
            if (DV2 != Convert.ToInt16(digitos[13].ToString()))
                return false;

            return true;
        }
    }
}
