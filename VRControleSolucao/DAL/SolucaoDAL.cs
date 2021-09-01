using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SolucaoDAL
    {
        public static void add(Solucao solucao)
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=vrsolucoes;Integrated Security=True";

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery= "INSERT INTO tbl_problemas(Id_problema, Nome, Descricao) VALUES(@id_problema, @nome, @descricao )";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@id_problema", solucao._idSolucao);
                    cmd.Parameters.AddWithValue("@nome", solucao.Nome);
                    cmd.Parameters.AddWithValue("@descricao", solucao.Descricao);

                    conec.Open();
                    cmd.ExecuteNonQuery();

                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }
            }
        }public static bool findSolucao(int codigo)
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=vrsolucoes;Integrated Security=True";
            bool testeFind = false;
            using (SqlConnection conec = new SqlConnection(textConnection))
            {

                try
                {
                    const string sqlQuery = "SELECT COUNT(@Id_problema) FROM tbl_problemas";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);

                    cmd.Parameters.AddWithValue("@Id_problema",codigo);

                    conec.Open();
                    cmd.ExecuteNonQuery();

                    int i = int.Parse(cmd.ExecuteScalar().ToString());

                    if (i == 0)
                    {
                        testeFind = false;
                    }
                    else
                    {
                        testeFind = true;
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }
            }
            return testeFind;
        }
        public static int getLast()
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=vrsolucoes;Integrated Security=True";
            int last;

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT MAX(Id_problema) FROM tbl_problemas";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);

                    conec.Open();

                    last = int.Parse(cmd.ExecuteScalar().ToString());
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conec.Close();
                }

            }
            return last;
        }
        public static DataTable getData()
        {
            string textConnection = @"Data Source=DESKTOP-DFR8CKK\SQLEXPRESS;Initial Catalog=vrsolucoes;Integrated Security=True";
   
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    string sqlQuery = "SELECT Id_problema, Nome FROM tbl_problemas";
                    conec.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conec))
                    //Representa um conjunto de comandos SQL e uma conexão de banco de dados
                    //serve pra preencher dataset
                    {
                        using (DataTable dt = new DataTable())
                        //representa uma tabela de dados
                        {
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch { throw; }
                finally
                {
                    conec.Close();
                }
            }
        }
    }
}
