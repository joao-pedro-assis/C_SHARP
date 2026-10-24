using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VALIDADOR_DOCUMENTOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0) txtDocumento.Mask = "999,999,999-99";
            if (cbTipo.SelectedIndex == 1) txtDocumento.Mask = "99,999,999/9999-99";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedIndex = 0;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            pessoa documento;
            if (cbTipo.SelectedIndex == 0)
            {
                documento = new PessoaFisica(txtNome.Text,
                txtEndereco.Text, txtDocumento.Text);
            }
            else
            {
                documento = new PessoaJuridica(txtNome.Text,
                txtEndereco.Text, txtDocumento.Text);
            }
            lbValidacao.Text = String.Format(
            "Nome :{0}\nEndereço: {1}\nDocumento = {2}", documento.Nome,
            documento.Endereco, documento.validar());
                              
        }
    }
}
