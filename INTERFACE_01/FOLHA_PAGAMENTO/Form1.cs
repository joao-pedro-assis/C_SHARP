using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLHA_PAGAMENTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<IFuncionario> Folha = new List<IFuncionario>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Folha.Add(new Funcionario("1", "JOAO", 180, 18f));
            Folha.Add(new Funcionario("2", "MARIA", 160, 21f));
            Folha.Add(new Funcionario("3", "JOSE", 140, 14f));
            Folha.Add(new Funcionario("4", "ANGELA", 200, 11f));
            Folha.Add(new Funcionario("5", "JOAQUIM", 170, 13f));
            Folha.Add(new Aposentado("6", "MARIO", 18f));
            Folha.Add(new Estagiario("7", "ROMARIO", 13f));
            Folha.Add(new Estagiario("8", "JOSEFA", 15f));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            IFuncionario func = Folha.FirstOrDefault(i => i.Cod == txtCodigo.Text);
            if (func != null)
            {
                if (func is Funcionario)
                {
                    lbHoras.Text = (func as Funcionario).HorasTrabalhadas.ToString();
                }
                else
                {
                    lbHoras.Text = "0";
                }
                lbSalario.Text = func.SalarioHora.ToString();
                lbNome.Text = func.Nome;
                lbSalarioBruto.Text = func.Calcular().ToString("C2");                
                lbTipo.Text = func.GetType().Name;
            }

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio.Items.Clear();
            foreach (var Emp in Folha)
            {
                Relatorio.Items.Add(Emp.Identificacao());
            }
        }
    }
}
