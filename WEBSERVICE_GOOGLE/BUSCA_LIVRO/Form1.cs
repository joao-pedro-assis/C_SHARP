using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUSCA_LIVRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            GoogleApi google = new GoogleApi();
            dynamic dados = await google.Books(txtCodigo.Text);
            if (dados != null)
            {
                if(dados.totalItems == 0)
                {
                    MessageBox.Show("livro não encontrado");
                    return;
                }
                txtTitulo.Text = dados.items[0].volumeInfo.title;
                txtAutor.Text = dados.items[0].volumeInfo.authors[0];
                txtAno.Text = dados.items[0].volumeInfo.publishedDate;
                txtEditora.Text = dados.items[0].volumeInfo.publisher;
                txtSinopse.Text = dados.items[0].volumeInfo.description;
                txtPaginas.Text = dados.items[0].volumeInfo.pageCount;
                txtPais.Text = dados.items[0].saleInfo.country;
                try
                {
                    txtPreco.Text = dados.items[0].saleInfo.listPrice.amount;
                }
                catch(Exception) 
                {
                    txtPreco.Text = "NC";
                }
                try
                {
                    string imagem = dados.items[0].volumeInfo.imageLinks.thumbnail;
                    if (imagem != "")
                    {
                        pbCapa.ImageLocation = imagem;
                    }
                    else pbCapa.ImageLocation = "";
                }
                catch (Exception)
                {
                    pbCapa.ImageLocation = "";
                }
            }
        }

        
    }
}
