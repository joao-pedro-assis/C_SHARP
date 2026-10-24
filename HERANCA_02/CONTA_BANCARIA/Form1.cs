using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTA_BANCARIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Conta> ContasBancarias = new List <Conta>();

        private void Form1_Load(object sender, EventArgs e)
        {
            ContasBancarias.Add(new ContaCorrente("100", "JOAO", 100));
            ContasBancarias.Add(new ContaPoupanca("105", "MATHEUS"));
            ContasBancarias.Add(new ContaPoupanca("250", "JOANA"));
            ContasBancarias.Add(new ContaPoupanca("555", "PEDRO"));
            ContasBancarias.Add(new ContaCorrente("200", "MARIA", 156));
            ContasBancarias.Add(new ContaCorrente("300", "JOSE", 234));
            ContasBancarias.Add(new ContaCorrente("400", "ANA", 890));
            ContasBancarias.Add(new ContaCorrente("500", "JOAQUIM", 585));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String numero = txtConta.Text;
            Conta conta = ContasBancarias.FirstOrDefault(i => i.Numero == numero);
            if (conta != null) 
            {
                lbCliente.Text = conta.Cliente + "(" + conta.Numero + ")";
                lbSaldo.Text = conta.Saldo.ToString("C2");
                lbTipo.Text = conta.GetType().Name;
            }
            else
            {
                lbCliente.Text = "";
                lbSaldo.Text = "R$ 0,00";
                lbTipo.Text = "TIPO";
            }

        }

        private void btnSimularDepositos_Click(object sender, EventArgs e)
        {
            String numero = txtConta.Text;
            Conta conta = ContasBancarias.FirstOrDefault(i => i.Numero == numero);
            if (conta != null) 
            {
                Random sorteio = new Random();
                double valor = 0;
                lbOcorrencias.Text = "";
                for (int i = 0; i<5; i++)
                {
                    valor = sorteio.Next(100, 2300);
                    lbOcorrencias.Text += "\nDeposito de: " + valor.ToString();
                    conta.Creditar(valor);
                    Thread.Sleep(200);
                }
                MessageBox.Show("Creditados efetuados");
                btnBuscar_Click(sender, new EventArgs());
            }

        }

        private void btnSimularSaques_Click(object sender, EventArgs e)
        {
            String numero = txtConta.Text;
            Conta conta = ContasBancarias.FirstOrDefault(i => i.Numero == numero);
            if (conta != null)
            {
                Random sorteio = new Random();
                double valor = 0;
                lbOcorrencias.Text = "";
                for (int i = 0; i < 5; i++)
                {
                    valor = sorteio.Next(100, 2300);
                    lbOcorrencias.Text += "\nSaque de: " + valor.ToString();
                    try
                    {
                        conta.Debitar(valor);
                    }
                    catch (Exception ex) 
                    {
                        lbOcorrencias.Text += "\n" +  ex.Message + "no saque de:" + valor.ToString(); 
                    }


                    Thread.Sleep(200);
                }
                MessageBox.Show("Débitos efetuados");
                btnBuscar_Click(sender, new EventArgs());
            }

        }
    }
}
