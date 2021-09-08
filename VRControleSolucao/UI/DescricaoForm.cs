using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRControleSolucao.UI
{
    public partial class DescricaoForm : Form
    {
        public DescricaoForm(int codigo, string nomeSolucao, string descricaoSolucao)
        {
            InitializeComponent();
            tbCodigo.Text = codigo.ToString();
            txtBoxNome.Text = nomeSolucao;
            txtBoxDescricao.Text = descricaoSolucao;
        }

        private void txtBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxNome.Enabled = true;
            txtBoxDescricao.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
