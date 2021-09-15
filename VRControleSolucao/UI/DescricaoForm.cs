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
using BLL;

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
            blockInput();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNome.Text =="")
                {
                    lbErro.Text = "Não é permitido alterar *nome* para vazio";
                }
                else
                {
                    lbErro.Text = "Alterado com sucesso!";
                    SolucaoBLL.update(int.Parse(tbCodigo.Text),txtBoxNome.Text,txtBoxDescricao.Text);
                    blockInput();
                }
                
            }
            catch
            {
                lbErro.Text = "Ocorreu um erro. Tente novamente";

            }
            finally {  }

            

        }
        public void blockInput()
        {
            txtBoxNome.ReadOnly= !txtBoxNome.ReadOnly;
            txtBoxDescricao.ReadOnly = !txtBoxDescricao.ReadOnly;
            btnSalvar.Enabled = !btnSalvar.Enabled;

            if (btnSalvar.Enabled == true)
            {
                button1.Text = "Bloquear edição";
            }
            else
            {
                button1.Text = "Habilitar edição";

            }
        }

        private void txtBoxNome_Enter(object sender, EventArgs e)
        {
      
        }
    }
}
