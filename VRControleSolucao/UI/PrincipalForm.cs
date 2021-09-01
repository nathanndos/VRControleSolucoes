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
            
            dataGridView1.Columns[1].Width = 360;
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
        }
    }
}
