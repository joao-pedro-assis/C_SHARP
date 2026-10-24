using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PRJ_ACADEMIA.controle
{
    class ServidorSQL
    {
        public SQLiteConnection Con { get; set; }

        public bool CreateDataBase(string name)
        {
            try
            {
                SQLiteConnection.CreateFile(name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public void Open(string name)
        {
            string sqlcon = String.Format("Data Source = {0}; version = 3;",name);
            Con = new SQLiteConnection(sqlcon);
            Con.Open();
        }

        public void CreateTableAluno()
        {
            Open("academia.lite");
            using (var comando = new SQLiteCommand(Con))
            {
                string sql = "CREATE TABLE ALUNO (COD INT PRIMARY KEY, NOME VARCHAR (30), NASCIMENTO DATETIME, CONTATO VARCHAR(15), DOCUMENTO VARCHAR(15),"
                +"PESO DOUBLE, ALTURA DOUBLE, SEXO VARCHAR(1)"+
                ")";
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
