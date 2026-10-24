using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class calculadora
    {
        public String Visor { get; set; }
        public double Aux1 { get; set; }
        public double Aux2 { get; set; }
        public String op { get; set; }

        public calculadora() { 
            Visor = "0";
            op = "0";
            Aux1 = Aux2 = 0;
        }
        public void Digito(String num)
        {
            if(Visor.Length > 20) return;
            if (Visor.Equals("0")) Visor = num;
            else Visor += num;
        }

        public void Backspace()
        {
            string tmp = Visor.Substring(0, Visor.Length-1);
            Visor = tmp;
            if (Visor.Equals("")) Visor = "0";
        }

        public void calcular()
        {
            if (op.Equals("+")) Aux1 = Aux1 + Aux2;
            if (op.Equals("-")) Aux1 = Aux1 - Aux2;
            if (op.Equals("*")) Aux1 = Aux1 * Aux2;
            if (op.Equals("/")) Aux1 = Aux1 / Aux2;
            Visor = Aux1.ToString();
        }

        public void InverterSinal()
        {
            double num = Convert.ToDouble(Visor) * -1;
            Visor = num.ToString();
        }

        public void RaizQuadrada()
        {
            double num = Math.Sqrt(Convert.ToDouble(Visor));
            Visor = num.ToString();
        }

        public void Produto()
        {
            double num = Math.Pow(Convert.ToDouble(Visor),2);
            Visor = num.ToString();
        }

        public void Fracao()
        {
            double num =1f / Convert.ToDouble(Visor) ;
            Visor = num.ToString();
        }

        public void Pi()
        {
            double num = Math.PI;
            Visor = num.ToString("N5");
        }

        public void Seno()
        {
            double num = Convert.ToDouble(Visor);
            double rad = Math.PI * num / 180;
            Visor = Math.Sin(rad).ToString();
        }
        public void Cosseno()
        {
            double num = Convert.ToDouble(Visor);
            double rad = Math.PI * num / 180;
            Visor = Math.Cos(rad).ToString();
        }

        public void Tangente()
        {
            double num = Convert.ToDouble(Visor);
            double rad = Math.PI * num / 180;
            Visor = Math.Tan(rad).ToString();
        }

        public void Logaritmo()
        {
            double num = Convert.ToDouble(Visor);
            Visor = Math.Log10(num).ToString();
        }

        public void Porcentagem()
        {
            double pc = Double.Parse(Visor);
            Visor = (Aux1 * pc / 100).ToString();
        }
    }
}
