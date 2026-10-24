using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_ACADEMIA.modelo
{
    class Aluno
    {
        public long Cod { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Documento { get; set; }
        public string Contato { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Sexo { get; set; }

        public Aluno(long Cod, string Nome, DateTime Nascimento, string Documento, string Contato, double Peso, double Altura, string Sexo)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.Nascimento = Nascimento;
            this.Documento = Documento;
            this.Contato = Contato;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Sexo = Sexo; 
        }
        public Aluno():this(0, "", DateTime.Now, "", "", 0f, 0f, "")
        {

        }

        public double IMC
        {
            get
            {
                return Math.Round(Peso / Math.Pow(Altura, 2),2); 
            }
        }

        public int Idade
        {
            get
            {
                TimeSpan calculo = DateTime.Now - Nascimento;
                return (int)calculo.TotalDays / 365; 
            }
        }
        public string Classificacao
        {
            get
            {
                double i = IMC;
                if (i < 18.5) return "baixo peso";
                else if (i >= 18.5 && i < 25) return "peso normal";
                else if (i >= 25 && i < 30) return "sobre peso";
                else if (i >= 30 && i < 35) return "obesidade I";
                else if (i >= 35 && i < 40) return "obesidade II";
                else if (i >= 40 && i < 50) return "obsidade III";
                else return "Obesidade Mórbida";
            }
        }
    }
}
