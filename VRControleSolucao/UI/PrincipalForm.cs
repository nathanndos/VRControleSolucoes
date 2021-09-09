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
            dataGridView1.Columns[0].Width = 80;    
            
            dataGridView1.Columns[1].Width = 420;
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

                dataGridView1.DataSource = SolucaoBLL.consultaNome(tbPesquisa.Text, rbNome.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbCodigo.Checked == true)
            {
                Solucao sl = SolucaoBLL.get(int.Parse(tbPesquisa.Text));
                DescricaoForm descricaoForm = new DescricaoForm(sl._idSolucao,sl.Nome, sl.Descricao);
                descricaoForm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
