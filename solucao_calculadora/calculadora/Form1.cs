using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private calculadora Calc;
        private bool estadoIgual = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            Calc = new calculadora();
        }

        private void TestarIgual(object sender,EventArgs e)
        {
            if(estadoIgual)
            {
                btCe_Click(sender, e);
                estadoIgual = false;
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt0.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt1.Text);
            lbVisor.Text = Calc.Visor;

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt2.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt3.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt4.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt5.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt6.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt7.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt8.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            Calc.Digito(bt9.Text);
            lbVisor.Text = Calc.Visor;
        }

        private void btBackspace_Click(object sender, EventArgs e)
        {
            Calc.Backspace();
            lbVisor.Text = Calc.Visor;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            if (Calc.Aux2 == 0) Calc.Aux2 = double.Parse(lbVisor.Text);
            if(Calc.Aux1.ToString() != Calc.Visor)
            {
                Calc.Aux2 = Double.Parse(lbVisor.Text);
            }
            Calc.calcular();
            lbVisor.Text = Calc.Visor;
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            estadoIgual = false;
            Calc.op = "+";
            Calc.Aux1 = Double.Parse(Calc.Visor);
            Calc.Visor = "0";
        }

        private void btsubtrair_Click(object sender, EventArgs e)
        {
            estadoIgual = false;
            Calc.op = "-";
            Calc.Aux1 = Double.Parse(Calc.Visor);
            Calc.Visor = "0";
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            estadoIgual = false;
            Calc.op = "*";
            Calc.Aux1 = Double.Parse(Calc.Visor);
            Calc.Visor = "0";
        }

        private void btdivisao_Click(object sender, EventArgs e)
        {
            estadoIgual =false;
            Calc.op = "/";
            Calc.Aux1 = Double.Parse(Calc.Visor);
            Calc.Visor = "0";
        }

        private void btCe_Click(object sender, EventArgs e)
        {
            Calc = new calculadora();
            lbVisor.Text = Calc.Visor;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            Calc.Visor = "0";
            lbVisor.Text = Calc.Visor;
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            Calc.InverterSinal();
            lbVisor.Text= Calc.Visor;  
        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.RaizQuadrada();
            lbVisor.Text = Calc.Visor;

        }

        private void btQuadrado_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Produto();
            lbVisor.Text = Calc.Visor;
        }

        private void btFracao_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Fracao();
            lbVisor.Text = Calc.Visor;
        }

        private void btPi_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Pi();
            lbVisor.Text = Calc.Visor;
        }

        private void btSeno_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Seno();
            lbVisor.Text = Calc.Visor;
        }

        private void btTangente_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Tangente();
            lbVisor.Text = Calc.Visor;
        }

        private void btCosseno_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Cosseno();
            lbVisor.Text = Calc.Visor;
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Logaritmo();
            lbVisor.Text = Calc.Visor;
        }

        private void btPorcentagem_Click(object sender, EventArgs e)
        {
            estadoIgual = true;
            Calc.Porcentagem();
            lbVisor.Text = Calc.Visor;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            if (Char.IsNumber(tecla)) {
                TestarIgual(sender, e);
                Calc.Digito(Convert.ToString(tecla));
                lbVisor.Text = Calc.Visor;
            }
            if(tecla.Equals('+')) btSoma_Click(sender, e);
            if (tecla.Equals('-')) btsubtrair_Click(sender, e);
            if (tecla.Equals('*')) btMultiplicacao_Click(sender, e);
            if (tecla.Equals('/')) btdivisao_Click(sender, e);
            if (tecla.Equals('=')) btCalcular_Click(sender, e);

            if(tecla == Convert.ToChar(Keys.Delete)) btCe_Click(sender, e);
            if (tecla == Convert.ToChar(Keys.Back)) btBackspace_Click(sender, e);
            
        }

        

        private void mmSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btPonto_Click(object sender, EventArgs e)
        {

        }

        private void lbVisor_Click(object sender, EventArgs e)
        {

        }

        private void menuSair_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
