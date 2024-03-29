﻿using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class SolucaoDAL
    {
        public static void add(Solucao solucao)
        {
            string textConnection = Common.get()[0];

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
        }
        public static bool findSolucao(int codigo)
        {
            string textConnection = Common.get()[0];
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
        public static void update(Solucao solucao) {
            string textConnection = Common.get()[0];

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "UPDATE tbl_problemas SET Nome=@Nome, Descricao=@Descricao WHERE Id_problema=@Codigo";

                    SqlCommand cmd = new SqlCommand(sqlQuery, conec);
                    cmd.Parameters.AddWithValue("@Nome",solucao.Nome);
                    cmd.Parameters.AddWithValue("@Descricao", solucao.Descricao);
                    cmd.Parameters.AddWithValue("@Codigo", solucao._idSolucao);

                    conec.Open();
                    cmd.ExecuteNonQuery();
                }
                catch { throw; }
                finally { conec.Close(); }
                
            }
        }
        public static int getLast()
        {
            string textConnection = Common.get()[0];
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
            string textConnection = Common.get()[0];
   
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT Id_problema, Nome FROM tbl_problemas";
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
        public static DataTable consultNome(string valor)
        {
            string textConnection = Common.get()[0];
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try

                {
                    string sqlQuery = $"SELECT Id_problema, Nome FROM tbl_problemas WHERE Nome LIKE '%{valor}%'";

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
        public static DataTable consultCodigo(int valor)
        {
            string textConnection = Common.get()[0];
            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try

                {
                    string sqlQuery = $"SELECT Id_problema, Nome FROM tbl_problemas WHERE Id_problema = {valor}";

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
        public static Solucao get(int codigo)
        {
            string textConnection = Common.get()[0];

            Solucao sol = new Solucao(codigo);
            SqlDataReader dr = null;

            using (SqlConnection conec = new SqlConnection(textConnection))
            {
                try
                {
                    const string sqlQuery = "SELECT Id_problema, Nome, Descricao FROM tbl_problemas WHERE Id_problema = @Codigo";
                    SqlCommand cmd = new SqlCommand(sqlQuery,conec);

                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conec.Open();

                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        sol.Nome = dr[1].ToString();
                        sol.Descricao = dr[2].ToString();
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

            return sol;
        }
    }
}
