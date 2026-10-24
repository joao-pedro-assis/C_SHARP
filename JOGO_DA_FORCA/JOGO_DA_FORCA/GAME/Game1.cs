using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace GAME
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Forca Jogo;
        string[] Lista;

        string[] Dicas;
          
        List<Label> Letras;
        int erros = 0;
        SoundPlayer FundoMusical;
        WaveOutEvent SomGrito = new WaveOutEvent();
        WaveOutEvent somMorte = new WaveOutEvent();
        private void Game1_Load(object sender, EventArgs e)
        {
            lbLetras.BackColor = Color.FromArgb(150, 25, 25, 25);
            lbCronometro.BackColor = Color.FromArgb(150, 25, 25, 25);
            CarregarLista();
            Jogo = new Forca(Lista, Dicas);
            NovoJogo();
            TocarMusica();
        }
        private void CarregarLista()
        {
            string arquivo = "lista.txt";
            if (!File.Exists(arquivo))
            {
                MessageBox.Show("Lista não encontrada");
                Environment.Exit(0);
            }
            string[] Linhas = File.ReadAllLines(arquivo);

            Dicas = new string[Linhas.Count()];
            Lista = new string[Linhas.Count()];
            int i = 0;
            foreach (string linha in Linhas)
            {
                if (linha.Equals("")) continue;
                string[] campos = linha.Split(',');
                Lista[i] = campos[0];
                Dicas[i] = campos[1];
                i++;
            }
        }
        private void TocarMusica()
        {
            FundoMusical = new SoundPlayer();
            FundoMusical.SoundLocation = "musca.wav";
            try
            {
                FundoMusical.PlayLooping();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message);
            }
        }
        private void NovoJogo()
        {       
            lbLetras.Text = String.Empty;
            pnPalavra.Controls.Clear();
            Jogo.sortear();
            lbDica.Text = "Dica = " + Jogo.Dicas[Jogo.Pos];
            DesenharPalavra(Jogo.Palavras[Jogo.Pos]);
            erros = 0;
            pbBoneco.Image = null;
        }
        private void DesenharPalavra(string p)
        {
            Letras = new List<Label>();
            int cx = 10, cy = 10;
            for (int i = 0; i < p.Length; i++)
            {
                Label letra = new Label();
                letra.Text = "?";
                letra.Width = 45;
                letra.Height = 45;
                letra.AutoSize = false;
                letra.BorderStyle = BorderStyle.FixedSingle;
                letra.TextAlign = ContentAlignment.MiddleCenter;
                letra.ForeColor = Color.Orange;
                letra.BackColor = Color.Black;
                letra.Top = cy;
                letra.Left = cx;
                cx += 50;
                Letras.Add(letra);
                pnPalavra.Controls.Add(letra);             
            }
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            string letra = txtLetra.Text;
            ProcurarLetra(letra);
            txtLetra.Clear();
            txtLetra.Focus();
        }
        private void ProcurarLetra(string letra)
        {
            string p = Jogo.Palavras[Jogo.Pos];
            bool achou = false;
            if (letra.Equals("") || letra.Equals(" ")) return;
            if (Char.IsNumber(Convert.ToChar(letra))) return;
            if (lbLetras.Text.Contains(letra))
            {
                MessageBox.Show("Letra ja digitada");
                return;
            }
            lbLetras.Text += letra + " ";

            for (int i = 0; i < p.Length; i++)
            {
                if (p.Substring(i,1).Equals(letra))
                {
                    Letras[i].Text = letra;
                    Letras[i].BackColor = Color.White;
                    Letras[i].ForeColor = Color.Black;
                    achou = true;
                }
            }
            if (achou == false)
            {
                DesenharBoneco();
            }
            if (erros == 6)
            {
                Derrota();
            }           
            vitoria();                  
        }
        private void DesenharBoneco()
        {
           erros++;
           string local = "KEEPER" + erros.ToString() + ".png";
           if(erros < 7)
           {
               if (File.Exists(local))
               {
                   pbBoneco.Image = Image.FromFile(local);
               }
               else MessageBox.Show("Erro ao carregar imagem");
           }
           Gritar();
        }
        private void Gritar()
        {
            string somFile = "oof.wav";
            AudioFileReader som = new AudioFileReader(somFile);
            SomGrito.Init(som);
            SomGrito.Play();
        }
        private void vitoria()
        {
            string tmp = String.Empty;

            foreach(Label item in Letras)
            {
                tmp += item.Text;
            }
            string p = Jogo.Palavras[Jogo.Pos];
            if (tmp.Equals(p))
            {
                cronometro.Stop();
                MessageBox.Show("ganhou o jogo");
                NovoJogo();
                lbCronometro.Text = "120";
                cronometro.Start();
            }
        }
        private void Derrota()
        {     
            string somMorteFile = "morte.wav";
            AudioFileReader som = new AudioFileReader(somMorteFile);
            somMorte.Init(som);
            somMorte.Play();
            string p = Jogo.Palavras[Jogo.Pos];
            cronometro.Stop();
            MessageBox.Show("Que pena, a palavra era " + p, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            NovoJogo();
            lbCronometro.Text = "120";
            cronometro.Start();
        }
        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {

           if (e.KeyChar == Convert.ToChar(Keys.Return))
           {
                btnJogar_Click(sender, e);
           }
        }
        private void cronometro_Tick(object sender, EventArgs e)
        {
            int seg = Convert.ToInt16(lbCronometro.Text);
            seg--;
            lbCronometro.Text = seg.ToString().PadLeft(1, '0');
            if (seg == 0)
            {
                cronometro.Stop();
                lbCronometro.Text = "120";
                MessageBox.Show("tempo esgotado. A palavra era " + Jogo.Palavras[Jogo.Pos]);
                NovoJogo();
                cronometro.Start(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbCronometro.Text = "120";
            NovoJogo();
        }
    }
}
