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
            SolucaoBLL.getLast();
            Solucao solucao = new Solucao();
            solucao.Nome = txtNome.Text;
            solucao.Descricao = txtDescricao.Text;
            SolucaoBLL.save(solucao);

            MessageBox.Show("Cadastrado com sucesso");
            
            clearText();


        }
        private void clearText()
        {

            txtNome.Text = "";
            txtDescricao.Text = "";
        }
    }
}
