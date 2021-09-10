using BLL;
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
using VRControleSolucao.UI;

namespace UI
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNome.Text == "")
                {
                    lbErro.Text = "Campo *Nome* é obrigatório para cadastro";
                }
                else
                {
                    criarCadastro();
                    Close();
                }
            }
            catch
            {
                lbErro.Text = "Ocorreu um erro. Digite novamente";

            }           

        }
        private void clearText()
        {

            txtNome.Text = "";
            txtDescricao.Text = "";
        }
        private void criarCadastro()
        {
            SolucaoBLL.getLast();
            Solucao solucao = new Solucao();
            solucao.Nome = txtNome.Text;
            solucao.Descricao = txtDescricao.Text;
            SolucaoBLL.save(solucao);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    lbErro.Text = "Campo *Nome* é obrigatório para cadastro";
                }
                else
                {
                    criarCadastro();
                    clearText();
                    lbErro.Text = "Cadastrado com sucesso!";
                }
            }
            catch
            {
                lbErro.Text = "Ocorreu um erro. Digite novamente";

            }
        }
    }
}
