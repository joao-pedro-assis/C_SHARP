using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJ_RELOGIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap desenho;
        string arquivo = "fundo.png";
        Graphics relogio;
        int xseg, yseg;
        int seg;


        private void Form1_Load(object sender, EventArgs e)
        {
            desenho = new Bitmap(pbRelogio.Width, pbRelogio.Height);
            relogio = Graphics.FromImage(desenho);
            relogio.DrawImage(Image.FromFile(arquivo), 0, 0, pbRelogio.Width, pbRelogio.Height);
            pbRelogio.Image = desenho;
        }

        private void pulso_Tick(object sender, EventArgs e)
        {
            seg = DateTime.Now.Second;
            relogio.DrawImage(Image.FromFile(arquivo), 0, 0, pbRelogio.Width, pbRelogio.Height);
            DesenharPonteiroDoSegundo();
            Graphics g = pbRelogio.CreateGraphics();
            g.DrawImage(desenho, 0, 0);

        }
        private void DesenharPonteiroDoSegundo()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 245;
            int angulo = (seg * 6) - 90;
            Pen p = new Pen(Color.Transparent, 12);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            relogio.DrawLine(p, cx, cy, cx + xseg, cy + yseg);
            double rad = Math.PI * angulo / 180;
            xseg = (int)(raio * Math.Cos(rad));
            yseg = (int)(raio * Math.Sin(rad));
            p.Color = Color.Red;
            relogio.DrawLine(p, cx, cy, cx + xseg, cy + yseg);
        }
    }
}
