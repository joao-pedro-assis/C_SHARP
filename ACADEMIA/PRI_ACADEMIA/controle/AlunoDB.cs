using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel;
using PRJ_ACADEMIA.modelo;

namespace PRJ_ACADEMIA.controle
{
    class AlunoDB
    {
        ServidorSQL servidor = new ServidorSQL();
        public void Insert(Aluno reg)
        {
            servidor.Open("academia.sqlite");
            using (var comandos = new SQLiteCommand(servidor.Con))
            {
                string sql = String.Format("INSERT INTO ALUNO VALUES({0},'{1}','{2}','{3}','{4}',{5},{6},'{7}')",
                    reg.Cod, reg.Nome, reg.Nascimento.Date, reg.Documento, reg.Contato,
                    reg.Peso.ToString().Replace(',', '.'), reg.Altura.ToString().Replace(',', '.'),
                    reg.Sexo);
                comandos.CommandText = sql;
                comandos.ExecuteNonQuery();

            }
        }
        public void select(BindingList<Aluno> Lista)
        {
              servidor.Open("academia.sqlite");
              using (var comandos = new SQLiteCommand(servidor.Con))
              {
                  string sql = "SELECT * FROM ALUNO ORDER BY COD";
                  comandos.CommandText = sql;
                  SQLiteDataReader dr = comandos.ExecuteReader();
                  while (dr.Read())
                  {
                      Aluno reg = new Aluno
                      {
                          Cod = dr.GetInt32(0),
                          Nome = dr.GetString(1),
                          Nascimento = Convert.ToDateTime(dr.GetString(2)),
                          Documento = dr.GetString(3),
                          Contato = dr.GetString(4),
                          Peso = dr.GetDouble(5),
                          Altura = dr.GetDouble(6),
                          Sexo = dr.GetString(7)
                      };
                      Lista.Add(reg);
                  }
                  dr.Close();
              }
        }


        public void update(Aluno reg)
        {
            servidor.Open("academia.sqlite");
            using (var comandos = new SQLiteCommand(servidor.Con))
            {
                string sql = String.Format("UPDATE ALUNO  SET " + "NOME = '{1}',NASCIMENTO = '{2}', DOCUMENTO = '{3}'," + "CONTATO = '{4}', PESO = {5}, ALTURA = {6}, SEXO = '{7}'" + " WHERE COD = {0}",
                    reg.Cod, reg.Nome, reg.Nascimento.Date, reg.Documento, reg.Contato,
                    reg.Peso.ToString().Replace(',', '.'), reg.Altura.ToString().Replace(',', '.'),
                    reg.Sexo);
                comandos.CommandText = sql;
                comandos.ExecuteNonQuery();

            }
        }
        public void delete(Aluno reg)
        {
            servidor.Open("academia.sqlite");
            using (var comandos = new SQLiteCommand(servidor.Con))
            {
                string sql = String.Format("DELETE FROM ALUNO WHERE COD = {0}",reg.Cod);
                comandos.CommandText = sql;
                comandos.ExecuteNonQuery();

            }
        }
        public long ProximoCodigo()
        {
             servidor.Open("academia.sqlite");
             using (var comandos = new SQLiteCommand(servidor.Con))
             {
                 string sql = String.Format("SELECT MAX(COD) FROM ALUNO");
                 comandos.CommandText = sql;
                 SQLiteDataReader dr = comandos.ExecuteReader();
                 if (dr.Read())
                 {
                     long cod = dr.GetInt32(0) + 1;
                     dr.Close();
                     return cod;
                 }
                 dr.Close();
             }
             
             return 0;
        }
    }
}
