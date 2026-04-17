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
            // Limpa o cache de dados
            _listaCache?.Clear();
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
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(265, 39);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(362, 20);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Pesquisar livro:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(18, 276);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(233, 20);
            this.txtISBN.TabIndex = 31;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(18, 228);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(233, 20);
            this.txtQuantidade.TabIndex = 30;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(18, 179);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(233, 20);
            this.txtEditora.TabIndex = 29;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(17, 132);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(234, 20);
            this.txtGenero.TabIndex = 28;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(17, 84);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(234, 20);
            this.txtAutor.TabIndex = 27;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(17, 39);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(234, 20);
            this.txtTitulo.TabIndex = 26;
            // 
            // lboDados
            // 
            this.lboDados.FormattingEnabled = true;
            this.lboDados.HorizontalScrollbar = true;
            this.lboDados.Location = new System.Drawing.Point(265, 68);
            this.lboDados.Margin = new System.Windows.Forms.Padding(2);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(362, 238);
            this.lboDados.TabIndex = 25;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboLivros_SelectedIndexChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(15, 261);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 24;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(15, 213);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 23;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(16, 164);
            this.lblEditora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(43, 13);
            this.lblEditora.TabIndex = 22;
            this.lblEditora.Text = "Editora:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(14, 117);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 21;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(15, 68);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 20;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Título:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(17, 311);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 61;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Location = new System.Drawing.Point(265, 311);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(87, 23);
            this.btnAtualizarLista.TabIndex = 60;
            this.btnAtualizarLista.Text = "Atualizar Lista";
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(552, 311);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 59;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(97, 311);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 23);
            this.btnSalvar.TabIndex = 58;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // LivrosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lboDados);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
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
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnSalvar;
    }
}
