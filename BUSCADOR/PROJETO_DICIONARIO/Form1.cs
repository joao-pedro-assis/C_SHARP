using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_DICIONARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IBuscador buscador = new Buscador();
        private void Form1_Load(object sender, EventArgs e)
        {
            buscador.Dicionario(new List<string>()
            {
                "Abacate",
                "Limão",
                "Melão",
                "Morango",
                "Banana",
                "Melancia",
                "Jaca",
                "Amora",
                "Abóbora",
                "Laranja",
                "Tangerina",
                "Ameixa",
                "Figo",
                "Framboesa",
                "Goiaba",
                "Kiwi",
                "Uva",
                "Tomate",
                "Jabuticaba",
                "Pera",
                "Açaí",
                "Coco",
                "Manga",
                "Pitanga",
                "Fruta do conde",
                "Romã",
                "Pitaia",
                "Tâmara"
            });
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<string> Resultado = new List<string>();
            Resultado  = buscador.Search(txtCriterio.Text);
            if (Resultado.Count > 0) 
            {
                Lista.DataSource = Resultado;
            }
            
        }

        
    }
}
