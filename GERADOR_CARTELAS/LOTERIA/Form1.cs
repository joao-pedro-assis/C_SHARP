using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTERIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (rbMegasena.Checked)
            {
                Cartela mega = new Cartela(60);
                mega.Desenhar(pnCartela, 6, 10);
                mega.Sortear(6);
            }
            if (rblotofacil.Checked) 
            {
                Cartela loto = new Cartela(25);
                loto.Desenhar(pnCartela, 5, 5);
                loto.Sortear(15);
            }
            if (rbQuina.Checked)
            {
                Cartela quina = new Cartela(80);
                quina.Desenhar(pnCartela, 8, 10);
                quina.Sortear(5);
            }
            if (rbLoto.Checked)
            {
                Cartela lotomania = new Cartela(100);
                lotomania.Desenhar(pnCartela, 10, 10);
                lotomania.Sortear(15);
            }
        }
    }
}
