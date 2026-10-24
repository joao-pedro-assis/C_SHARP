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
            if (Registro == null) Novo();
            else Editar();
            this.Dispose();
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
            }
        }
        
    }
}
