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
    public partial class FormPesquisarAluno : Form
    {
        public FormPesquisarAluno()
        {
            InitializeComponent();
        }
        internal int codigo { get; set; }
        internal academia BoaForma { get; set; }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if (rbI.Checked) tipo = "I";
            else if (rbM.Checked) tipo = "M";
            else if (rbF.Checked) tipo = "F";
            else tipo = "I";
            BindingSource bs = new BindingSource();

            bs.DataSource = BoaForma.Pesquisar(txtNome.Text.ToUpper(), tipo);
            dgvPesquisa.DataSource = bs;
            dgvPesquisa.AutoResizeColumns();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisa.Rows.Count != 0)
            {
                string valor = dgvPesquisa.CurrentRow.Cells["Cod"].Value.ToString();
                codigo = Int32.Parse(valor);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("pesquisa não realizada");
            }
        }

       

    }
}
