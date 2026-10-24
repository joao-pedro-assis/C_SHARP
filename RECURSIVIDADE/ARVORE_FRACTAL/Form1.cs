using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARVORE_FRACTAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Arvore arvore;
        private void Form1_Load(object sender, EventArgs e)
        {
            arvore = new Arvore(pnArvore.CreateGraphics(),pnArvore.Width,pnArvore.Height);
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            arvore.Desenhar();
        }

        private void sbAngulo_Scroll(object sender, ScrollEventArgs e)
        {
            lbAngulo.Text = sbAngulo.Value.ToString();
            arvore.Angulo = sbAngulo.Value;
            btnDesenhar_Click(sender, e);
        }

        private void sbCrescimento_Scroll(object sender, ScrollEventArgs e)
        {
            lbCrescimento.Text = sbCrescimento.Value.ToString();
            arvore.Crescimento = sbCrescimento.Value / 100f;
            btnDesenhar_Click(sender, e);
        }
    }
}
