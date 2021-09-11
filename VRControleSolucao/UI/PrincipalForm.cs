using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using UI;

namespace VRControleSolucao.UI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            reloadDataSet();
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].Width = 440;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.Show();
        }
        public void reloadDataSet()
        {
            
            dataGridView1.DataSource = SolucaoBLL.getDataTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reloadDataSet();
            tbPesquisa.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lbErro.Text = "";
                if (tbPesquisa.Text == "")
                {
                    lbErro.Text = "Campo pesquisa está vazio";

                }            
                else
                {
                    dataGridView1.DataSource = SolucaoBLL.consultaNome(tbPesquisa.Text, rbNome.Checked);
                }
            }
           catch
            {
                lbErro.Text = "Digite apenas valores válidos na pesquisa por código";
                tbPesquisa.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCodigo.Checked == true)
                {
                    if (tbPesquisa.Text == "")
                    {
                        lbErro.Text = "Campo pesquisa está vazio";

                    }
                    else if (int.Parse(tbPesquisa.Text)>0)
                    {
                        lbErro.Text = "";
                        Solucao sl = SolucaoBLL.get(int.Parse(tbPesquisa.Text));
                        DescricaoForm descricaoForm = new DescricaoForm(sl._idSolucao, sl.Nome, sl.Descricao);
                        descricaoForm.Show();
                    }
                    else
                    {
                        lbErro.Text = "Digite apenas valores positivos na pesquisa por código";
                        tbPesquisa.Text = "";
                    }
                    
                }
            }
            catch
            {
                lbErro.Text = "Digite apenas valores númericos na pesquisa por código";
                tbPesquisa.Text = "";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
