using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace Ligarbase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            lbStatus.Text = "";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            SqlConnection conec = null;

            try
            {
                conec = new SqlConnection(Common.get());
                SqlCommand cmd = new SqlCommand("",conec);

                //define instrução SQL - nome de tabela/armazenamento/etc
                cmd.CommandText = @"CREATE DATABASE vrsolucoes ON" +
                    "(FILENAME = 'C:\\VRControleSolucoes\\vrsolucoes.mdf')" +
                    "(FILENAME = 'C:\\VRControleSolucoes\\vrcoluoes_log.ldf')" +
                    "FOR ATTACH";

                conec.Open();
               
                lbStatus.Text = "Sucesso";

            }
            catch
            {
                lbStatus.Text = "Erro";
            }
        }
    }
}
