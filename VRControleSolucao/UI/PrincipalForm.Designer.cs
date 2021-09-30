
namespace VRControleSolucao.UI
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbErro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPesquisa.Location = new System.Drawing.Point(164, 76);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(222, 29);
            this.tbPesquisa.TabIndex = 1;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            this.tbPesquisa.Enter += new System.EventHandler(this.tbPesquisa_Enter);
            this.tbPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisa_KeyDown);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNome.Location = new System.Drawing.Point(164, 111);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(92, 25);
            this.rbNome.TabIndex = 7;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome F1";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCodigo.Location = new System.Drawing.Point(262, 111);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(99, 25);
            this.rbCodigo.TabIndex = 8;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código F2";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todos os registros";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(426, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(540, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Visualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(284, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nova solução";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(82, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 160);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(82, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "Atualizar F5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(500, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "Fechar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Menu de busca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(546, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desenvolvido por: Nathan Silva";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbErro.ForeColor = System.Drawing.Color.Red;
            this.lbErro.Location = new System.Drawing.Point(12, 452);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(39, 19);
            this.lbErro.TabIndex = 23;
            this.lbErro.Text = "teste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Versão: 1.2 [Sakura]";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.label1);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRControleSoluções ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbErro;
        private System.Windows.Forms.Label label5;
    }
}