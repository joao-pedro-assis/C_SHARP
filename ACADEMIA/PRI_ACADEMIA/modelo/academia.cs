using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_ACADEMIA.modelo
{
    class academia
    {
        public BindingList<Aluno>Alunos{ get; set;}
        public academia()
        {
            Alunos = new BindingList<Aluno>();
        }
        public void Matricular(Aluno Reg)
        {
            if (Reg != null)
            {
                Alunos.Add(Reg);
                controle.AlunoDB tabela = new controle.AlunoDB();
                try
                {
                    tabela.Insert(Reg);
                }
                catch (Exception Erro)
                {
                    System.Windows.Forms.MessageBox.Show("Falha ao carregar Registro:" + Erro.Message);
                    
                }
            }
        }

        public void Editar(Aluno aluno)
        {
            try
            {
                Aluno old = Alunos.FirstOrDefault(i => i.Cod == aluno.Cod);
                old.Nome = aluno.Nome;
                old.Nascimento = aluno.Nascimento;
                old.Peso = aluno.Peso;
                old.Altura = aluno.Altura;
                old.Contato = aluno.Contato;
                old.Documento = aluno.Documento;
                old.Sexo = aluno.Sexo;

                controle.AlunoDB tabela = new controle.AlunoDB();
                tabela.update(old);
                
            }
            catch (Exception)
            {

                
            }
        }




        public void Remover(long Matricula)
        {
            try
            {
                Aluno old = Alunos.FirstOrDefault(i => i.Cod == Matricula);
                if (old != null)
                {
                    Alunos.Remove(old);
                    controle.AlunoDB tabela = new controle.AlunoDB();
                    tabela.delete(old);
                }
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro:" + Erro.Message);  
              
            }
        }

        public object Pesquisar(string texto, string tipo)
        {
            if (tipo == "I")
            {
                return Alunos.Where(i => i.Nome.StartsWith(texto));
            }
            else if (tipo == "F")
            {
                return Alunos.Where(i => i.Nome.EndsWith(texto));
            }
            else
            {
                return Alunos.Where(i => i.Nome.Contains(texto));
            }
        }

        internal void LerTabela(System.Data.DataSet DS)
        {
            DS.Tables.Add(new System.Data.DataTable());
            DS.Tables[0].Columns.Add("Cod");
            DS.Tables[0].Columns.Add("Nome");
            DS.Tables[0].Columns.Add("Nascimento");
            DS.Tables[0].Columns.Add("Contato");
            DS.Tables[0].Columns.Add("Peso");
            DS.Tables[0].Columns.Add("Altura");
            DS.Tables[0].Columns.Add("IMC");
            DS.Tables[0].Columns.Add("Classificacao");
            DS.Tables[0].Columns.Add("Sexo");

            foreach (Aluno reg in Alunos)
            {
                System.Data.DataRow row = DS.Tables[0].NewRow();
                row["Cod"] = reg.Cod;
                row["Nome"] = reg.Nome;
                row["Nascimento"] = reg.Nascimento.ToShortDateString() ;
                row["Contato"] = reg.Contato;
                row["Peso"] = reg.Peso.ToString("N2");
                row["Altura"] = reg.Altura;
                row["IMC"] = reg.IMC;
                row["Sexo"] = reg.Sexo;
                row["Classificacao"] = reg.Classificacao;
                DS.Tables[0].Rows.Add(row);
            }
            DS.DataSetName = "dsAluno";
        }
    }
}
