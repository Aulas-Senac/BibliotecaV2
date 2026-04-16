namespace BibliotecaV2.controls
{
    partial class LivrosControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lboDados = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(268, 46);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Pesquisar livro:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(20, 226);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(206, 20);
            this.txtISBN.TabIndex = 31;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(20, 190);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(206, 20);
            this.txtQuantidade.TabIndex = 30;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(20, 151);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(206, 20);
            this.txtEditora.TabIndex = 29;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(20, 116);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(206, 20);
            this.txtGenero.TabIndex = 28;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(20, 82);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(206, 20);
            this.txtAutor.TabIndex = 27;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(20, 46);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(206, 20);
            this.txtTitulo.TabIndex = 26;
            // 
            // lboDados
            // 
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Location = new System.Drawing.Point(268, 75);
            this.lboDados.Margin = new System.Windows.Forms.Padding(2);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(362, 238);
            this.lboDados.TabIndex = 25;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboLivros_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Digite o ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Digite a quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Digite o editora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Digite o genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Digite o autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Digite o titulo:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(20, 261);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 19);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar seleção";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAcoes
            // 
            this.btnAcoes.Location = new System.Drawing.Point(526, 317);
            this.btnAcoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(104, 19);
            this.btnAcoes.TabIndex = 35;
            this.btnAcoes.Text = "Atualizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = true;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // btnAjuste
            // 
            this.btnAjuste.Location = new System.Drawing.Point(130, 261);
            this.btnAjuste.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(96, 19);
            this.btnAjuste.TabIndex = 34;
            this.btnAjuste.Text = "Cadastrar";
            this.btnAjuste.UseVisualStyleBackColor = true;
            this.btnAjuste.Click += new System.EventHandler(this.btnAjuste_Click);
            // 
            // LivrosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lboDados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LivrosControl";
            this.Size = new System.Drawing.Size(642, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnAjuste;
    }
}
