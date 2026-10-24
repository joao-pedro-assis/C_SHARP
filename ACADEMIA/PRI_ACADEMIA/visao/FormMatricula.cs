using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRJ_ACADEMIA.modelo;
using System.IO;
using System.Drawing.Imaging;

namespace PRJ_ACADEMIA.visao
{
    public partial class FormMatricula : Form
    {
        public FormMatricula()
        {
            InitializeComponent();
        }
        internal Aluno Registro { get; set; }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validacao() == false) return;
            if (Registro == null) Novo();
            else Editar();
            this.Dispose();
        }

        private bool validacao()
        {
            if (txtNome.Text == string.Empty)
            {
                ep.SetError(txtNome, "Nome não foi preenchido.");
                ep.SetIconPadding(txtNome, -30);
                return false;
            }
            else
            {
                ep.SetError(txtNome, "");
            }
            
            if (txtContato.Text == string.Empty)
            {
                ep.SetError(txtContato, "Contato não foi preenchido.");
                ep.SetIconPadding(txtContato, -30);
                return false;
            }
            else
            {
                ep.SetError(txtContato, "");
            }

            if (txtDocumento.Text == string.Empty)
            {
                ep.SetError(txtDocumento, "Documento não foi preenchido.");
                ep.SetIconPadding(txtDocumento, -30);
                return false;
            }
            else
            {
                ep.SetError(txtDocumento, "");
            }

            if (txtPeso.Text == string.Empty)
            {
                ep.SetError(txtPeso, "Peso não foi preenchido.");
                ep.SetIconPadding(txtPeso, -30);
                return false;
            }
            else
            {
                ep.SetError(txtPeso, "");
            }

            if (txtAltura.Text == string.Empty)
            {
                ep.SetError(txtAltura, "Altura não foi preenchido.");
                ep.SetIconPadding(txtAltura, -30);
                return false;
            }
            else
            {
                ep.SetError(txtAltura, "");
            }

            TimeSpan calculo = DateTime.Now - dtNascimento.Value;
            int idade = (int)Math.Truncate(calculo.TotalDays / 365);

            if (idade < 13 || idade > 90)
            {
                ep.SetError(dtNascimento, "Idade invalida:" + idade);
                ep.SetIconPadding(dtNascimento, -30);
                return false;
            }
            else
            {
                ep.SetError(dtNascimento, "");
            }


            return true;

        }

        private void Editar()
        {
          string tipo = "";
          if (rbMasculino.Checked) tipo = "M";
          else if (rbFeminino.Checked) tipo = "F";
          else tipo = "I";

          Registro.Nome = txtNome.Text.ToUpper();
          Registro.Nascimento = dtNascimento.Value;
          Registro.Contato = txtContato.Text;
          Registro.Documento = txtDocumento.Text;
          Registro.Peso = Convert.ToDouble(txtPeso.Text);
          Registro.Altura = Convert.ToDouble(txtAltura.Text);
          Registro.Sexo = tipo;

          MessageBox.Show("Registro editado com sucesso");
        }

        private void Novo()

        {
            string tipo = "";
            if (rbMasculino.Checked) tipo = "M";
            else if (rbFeminino.Checked) tipo = "F";
            else tipo = "I";

            Registro = new Aluno
            {
                Cod = Convert.ToInt64(txtMatricula.Text),
                Nome = txtNome.Text.ToUpper(),
                Nascimento = dtNascimento.Value,
                Contato = txtContato.Text,
                Documento = txtDocumento.Text,
                Peso = Convert.ToDouble(txtPeso.Text),
                Altura = Convert.ToDouble(txtAltura.Text),
                Sexo = tipo
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void FormMatricula_Load(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                txtMatricula.Text = Registro.Cod.ToString();
                txtMatricula.ReadOnly = true;
                lbTitulo.Text = "FICHA DE MATRICULA NUMERO:" + Registro.Cod.ToString().PadLeft(12, '0');
                txtNome.Text = Registro.Nome;
                txtContato.Text = Registro.Contato;
                txtDocumento.Text = Registro.Documento;
                txtPeso.Text = Registro.Peso.ToString();
                txtAltura.Text = Registro.Altura.ToString();
                if (Registro.Sexo == "M") rbMasculino.Checked = true;
                if (Registro.Sexo == "F") rbFeminino.Checked = true;
                if (Registro.Sexo == "I") rbIndefinido.Checked = true;
                dtNascimento.Value = Registro.Nascimento;
                txtNome.Focus();
                txtNome.Select();
                btnGerar.Enabled = false;
            }
            else
            {
                controle.AlunoDB tabela = new controle.AlunoDB();
                txtMatricula.Text = tabela.ProximoCodigo().ToString();
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            controle.AlunoDB tabela = new controle.AlunoDB();
            txtMatricula.Text = tabela.ProximoCodigo().ToString();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            string caminho = Environment.CurrentDirectory + "\\fotos\\" + txtMatricula.Text + ".jpg";
            if (Registro == null) return;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "";
            openFile.Filter = "Imagens | *.jpg";
            openFile.ShowDialog();

            if (File.Exists(openFile.FileName))
            {
                Application.DoEvents();//Processador não intel
                GC.Collect(); //coleta o lixo da ram
                GC.WaitForPendingFinalizers();// esperar as pendencais em RAM
                if (File.Exists(caminho))
                {
                    File.Delete(caminho);
                }
                File.Copy(openFile.FileName, caminho);
                MessageBox.Show("Imagem sava com sucesso em:" + caminho);
            }

        }

        private void FormMatricula_Paint(object sender, PaintEventArgs e)
        {
            string caminho = Environment.CurrentDirectory + "\\fotos\\" + txtMatricula.Text + ".jpg";
            if (File.Exists(caminho))
            {
                pbFoto.CreateGraphics().DrawImage(Image.FromFile(caminho), 0, 0, pbFoto.Width, pbFoto.Height);
            }
        }

        private void btnWebcam_Click(object sender, EventArgs e)
        {
            formWebcam camera = new formWebcam();
            camera.ShowDialog();

            string caminho = Environment.CurrentDirectory + "\\fotos\\" + txtMatricula.Text + ".jpg";
            if (camera.pbFoto == null) 
            {
                MessageBox.Show("Foto não cadastrada");
                return;
            }
            if (File.Exists(caminho))
            {
                Application.DoEvents();//Processador não intel
                GC.Collect(); //coleta o lixo da ram
                GC.WaitForPendingFinalizers();// esperar as pendencais em RAM
                File.Delete(caminho);

            }
            
            camera.pbFoto.Image.Save(caminho, ImageFormat.Jpeg);
            
         }
    }
}
