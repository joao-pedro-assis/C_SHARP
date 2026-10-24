using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTERIA
{
    public class Cartela
    {
        public List<Label> Numeros {  get; set; }    
        public Cartela(int Qtd) 
        {
            Numeros = new List<Label>();
            for (int i = 0; i < Qtd; i++)
            {
                Label Num = new Label();
                Num.Text = (i + 1).ToString();
                if (i == 99) Num.Text = "00"; 
                Num.AutoSize = false;
                Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Num.BorderStyle = BorderStyle.FixedSingle;
                Num.ForeColor = System.Drawing.Color.Black;
                Num.BackColor = System.Drawing.Color.Transparent;
                Num.Image = Image.FromFile("ball.png");
                Numeros.Add(Num);
            }
        }
        public void Desenhar(Panel p, int Lin, int col)
        {
            int ph = 0;
            int pv = 0;
            int cont = 0;
            foreach (Label Num in Numeros)
            {
                Num.Width = p.Width/col;
                Num.Height = (p.Height - 30) / Lin;
                if(cont % col == 0 && cont !=0)
                {
                    ph = 0;
                    pv += Num.Height;
                }
                Num.Left = ph;
                Num.Top = pv;
                ph += Num.Width;
                p.Controls.Add(Num);
                cont++;
            }
        }

        public void Sortear(int qtd)
        {
            List<int> Num = new List<int>();
            int i = 0;
            while (i < qtd) 
            {
                Random faixa = new Random();
                int n = faixa.Next(1,Numeros.Count);
                if (Num.Contains(n))
                {
                    i--;
                }
                else 
                {
                    Num.Add(n);
                }
                i++;
            }
            foreach (int n in Num)
            {
                Numeros[n].BackColor = Color.WhiteSmoke;
                Numeros[n].ForeColor = Color.Red;
            }
            
        }
    }
}
