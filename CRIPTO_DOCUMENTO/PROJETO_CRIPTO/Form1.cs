using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_CRIPTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "arquivo texto | *.txt";
            openFile.ShowDialog();
            if (File.Exists(openFile.FileName))
            {
                string[] linhas = File.ReadAllLines(openFile.FileName);
                foreach (string line in linhas) 
                {
                    txtDocumento.Text += line;
                }
                FileName.Text = openFile.FileName;
            }
            else
            {
                FileName.Text = "";
                txtDocumento.Clear();
            }
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            int qtd = File.ReadAllLines(FileName.Text).Count();

            if (txtChave.Text == string.Empty)
            {
                MessageBox.Show("Chava ou Trava vazia");
                return;
            }

            txtDocumento.Clear();
            Crypto crypto = new Crypto();
            crypto.Trava = txtChave.Text;

            StreamWriter saida = new StreamWriter(Environment.CurrentDirectory +
             @"\saida.txt");
            StreamReader arq = new StreamReader(FileName.Text);
            for (int i = 0; i < qtd; i++)
            {
                string line = arq.ReadLine();
                txtDocumento.Text += crypto.Codificar(line) + "\r\n";
                saida.WriteLine(crypto.Codificar(line));
            }

            saida.Close(); // fecha o stream e salva o arquivo
            MessageBox.Show("arquivo salvo em " + Environment.CurrentDirectory +
             @"\saida.txt");

        }

        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            int qtd = File.ReadAllLines(FileName.Text).Count();
            StreamReader arq = new StreamReader(FileName.Text);
            if (txtChave.Text == string.Empty)
            {
                MessageBox.Show("Chava ou Trava vazia");
                return;
            }

            txtDocumento.Clear();
            Crypto crypto = new Crypto();
            crypto.Trava = txtChave.Text;

            StreamWriter saida = new StreamWriter(Environment.CurrentDirectory +
  @"\saida.txt");

            for (int i = 0; i < qtd; i++)
            {
                string line = arq.ReadLine();
                txtDocumento.Text += crypto.Decodificar(line) + "\r\n";
                saida.WriteLine(crypto.Decodificar(line));
            }
            saida.Close(); // fecha o stream e salva o arquivo
            MessageBox.Show("arquivo salvo em " + Environment.CurrentDirectory +
             @"\saida.txt");
        }
    }
}
