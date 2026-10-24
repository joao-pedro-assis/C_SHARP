using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_CEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnProcurar_Click(object sender, EventArgs e)
        {
            ApiCep cep = new ApiCep();
            dynamic dados = await cep.Pesquisar(txtCep.Text);
            if (dados != null) 
            {
                lbLogradouro.Text = dados.logradouro;
                lbBairro.Text = dados.bairro;
                lbCidade.Text = dados.localidade;
                lbEstado.Text = dados.estado + ": " + dados.regiao;
                lbIBGE.Text = dados.ibge;
                lbDDD.Text = dados.ddd;
                lbSiaf.Text = dados.siafi;
                
            }
        }
    }
}
