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
using PRJ_ACADEMIA.controle;

namespace PRJ_ACADEMIA.visao
{
    public partial class FormAcademia : Form
    {
        public FormAcademia()
        {
            InitializeComponent();
        }
        academia BoaForma;
        BindingSource bs;

        private void FormAcademia_Load(object sender, EventArgs e)
        {
            CriarBancoDados();
            BoaForma = new academia();
            bs = new BindingSource();
            LerArquivoDados();

            dgvAlunos.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvAlunos.DefaultCellStyle.ForeColor = Color.Black;
            dgvAlunos.DefaultCellStyle.BackColor = Color.FromArgb(215, 214, 255);

            bs.DataSource = BoaForma.Alunos;
            bn.BindingSource = bs;
            dgvAlunos.DataSource = bs;
            dgvAlunos.AutoResizeColumns();

        }

        private void CriarBancoDados()
        {
            string banco = "academia.sqlite";
            if (!File.Exists(banco))
            {
                ServidorSQL servidor = new ServidorSQL();
                if (servidor.CreateDataBase(banco))
                {
                    MessageBox.Show("Base de dados academia.sqlite criada");
                }
                else
                {
                    MessageBox.Show("falha ao criar o banco de dados academia.sqlite");
                }
            }
        }
        private void LerArquivoDados()
        {
            string arquivo = "Lista.txt";
            string[] linhas = File.ReadAllLines(arquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                Aluno reg = new Aluno
                {
                    Cod = Int64.Parse(campos[0]),
                    Nome = campos[1].ToUpper().TrimStart(),
                    Nascimento = Convert.ToDateTime(campos[2]),
                    Documento = campos[3],
                    Contato = campos[4],
                    Peso = Double.Parse(campos[5]),
                    Altura = Math.Round(Double.Parse(campos[6]) / 100, 1),
                    Sexo = campos[7]
                };
                BoaForma.Matricular(reg);
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            FormMatricula ficha = new FormMatricula();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                BoaForma.Matricular(ficha.Registro);
                bs.ResetBindings(true);
                bs.MoveLast();
                dgvAlunos.AutoResizeColumns();
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMatricula ficha = new FormMatricula();
            ficha.Registro = (Aluno)bs.Current;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                BoaForma.Editar(ficha.Registro);
                bs.ResetBindings(true);
                dgvAlunos.AutoResizeColumns();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op;
            Aluno Reg = (Aluno)bs.Current;
            op = MessageBox.Show("Excluir " + Reg.Nome ,"ALERTA", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                BoaForma.Remover(Reg.Cod);
                bs.ResetBindings(true);
                bs.MoveFirst();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisarAluno pesquisa = new FormPesquisarAluno();
            pesquisa.BoaForma = BoaForma;
            pesquisa.ShowDialog();
            if (pesquisa.codigo != 0 )
            {
                Aluno Reg = BoaForma.Alunos.FirstOrDefault(i => i.Cod == pesquisa.codigo);
                bs.Position = bs.IndexOf(Reg);
                btnEditar_Click(sender, e);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio relatorio = new FormRelatorio();
            DataSet DS = new DataSet();
            BoaForma.LerTabela(DS);
            relatorio.DS = DS;
            relatorio.Arquivo = @"H:\DS\ACADEMIA\PRI_ACADEMIA\relatorio\aluno.rdlc";
            relatorio.Show();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            FormRelatorio relatorio = new FormRelatorio();
            DataSet DS = new DataSet();
            BoaForma.LerTabela(DS);
            relatorio.DS = DS;
            relatorio.Arquivo = @"H:\DS\ACADEMIA\PRI_ACADEMIA\relatorio\graficoaluno.rdlc";
            relatorio.Show();
        }
    }
}
