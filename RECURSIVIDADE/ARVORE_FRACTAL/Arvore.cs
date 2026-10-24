using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARVORE_FRACTAL
{
    public class Arvore
    {
        public Graphics Tela {  get; set; }
        public Pen Caneta { get; set; }
        public int Width {  get; set; }
        public int Height { get; set; }
        public double Angulo { get; set; }
        public double Crescimento { get; set; }
        public Arvore(Graphics Tela,int Width, int Height)
        {
            this.Tela = Tela;
            this.Width = Width; 
            this.Height = Height;
            Angulo = 45;
            Crescimento = 0.65f;
            Caneta = new Pen(Color.Black,0);
        }
        public void Desenhar()
        {
            Tela.ResetTransform(); //reseta as coordenadas
            Tela.Clear(Color.Honeydew);
            Tela.TranslateTransform(Width / 2, Height); //deslocar a origem 0,0
            Tronco(175f);
        }

        private void Tronco(double len)
        {
            Caneta.Color = Color.Maroon;
            Caneta.Width = 2f;
            Tela.DrawLine(Caneta, 0, 0, 0, (int)-len);
            Color[] cores = new Color[]
            {
                Color.Green,Color.Red,Color.Yellow,Color.Blue,Color.Orange,Color.GreenYellow,Color.Violet
            };
            Random r = new Random();
            SolidBrush cor = new SolidBrush(cores[r.Next(0,7)]);
            Tela.FillEllipse(cor,-5,(int)-len,10,10);

            Tela.TranslateTransform(0, (float)-len,System.Drawing.Drawing2D.MatrixOrder.Prepend);
            if(len >= 10)
            {
                GraphicsState estado = Tela.Save();
                Tela.RotateTransform((float)Angulo, System.Drawing.Drawing2D.MatrixOrder.Prepend);
                Tronco(len * Crescimento);

                Tela.Restore(estado);

                estado = Tela.Save();
                Tela.RotateTransform((float)-Angulo, System.Drawing.Drawing2D.MatrixOrder.Prepend);
                Tronco(len * Crescimento);
                Tela.Restore(estado);
            }  
        }
    }
}
