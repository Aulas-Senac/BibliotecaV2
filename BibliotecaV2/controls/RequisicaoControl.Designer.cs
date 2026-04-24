namespace BibliotecaV2.controls
{
    partial class RequisicaoControl
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
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.dtpDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.dtpDataRequisicao = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lboDados = new System.Windows.Forms.ListBox();
            this.lblDataRequisicao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboLivro = new System.Windows.Forms.ComboBox();
            this.lblLivro = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(28, 132);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(256, 21);
            this.cboFuncionario.TabIndex = 104;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(25, 116);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(65, 13);
            this.lblFuncionario.TabIndex = 103;
            this.lblFuncionario.Text = "Funcionario:";
            // 
            // dtpDataDevolucao
            // 
            this.dtpDataDevolucao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDataDevolucao.Location = new System.Drawing.Point(28, 232);
            this.dtpDataDevolucao.Name = "dtpDataDevolucao";
            this.dtpDataDevolucao.Size = new System.Drawing.Size(256, 20);
            this.dtpDataDevolucao.TabIndex = 98;
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Location = new System.Drawing.Point(25, 216);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(88, 13);
            this.lblDataDevolucao.TabIndex = 97;
            this.lblDataDevolucao.Text = "Data Devolução:";
            // 
            // dtpDataRequisicao
            // 
            this.dtpDataRequisicao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDataRequisicao.Enabled = false;
            this.dtpDataRequisicao.Location = new System.Drawing.Point(28, 182);
            this.dtpDataRequisicao.Name = "dtpDataRequisicao";
            this.dtpDataRequisicao.Size = new System.Drawing.Size(256, 20);
            this.dtpDataRequisicao.TabIndex = 96;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(28, 324);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 95;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(302, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(94, 13);
            this.lblBuscar.TabIndex = 94;
            this.lblBuscar.Text = "Buscar requisição:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(305, 37);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(313, 20);
            this.txtPesquisa.TabIndex = 93;
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Location = new System.Drawing.Point(305, 337);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(87, 23);
            this.btnAtualizarLista.TabIndex = 92;
            this.btnAtualizarLista.Text = "Atualizar Lista";
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(543, 337);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 91;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lboDados
            // 
            this.lboDados.FormattingEnabled = true;
            this.lboDados.HorizontalScrollbar = true;
            this.lboDados.Location = new System.Drawing.Point(305, 63);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(313, 264);
            this.lboDados.TabIndex = 90;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // lblDataRequisicao
            // 
            this.lblDataRequisicao.AutoSize = true;
            this.lblDataRequisicao.Location = new System.Drawing.Point(25, 166);
            this.lblDataRequisicao.Name = "lblDataRequisicao";
            this.lblDataRequisicao.Size = new System.Drawing.Size(89, 13);
            this.lblDataRequisicao.TabIndex = 89;
            this.lblDataRequisicao.Text = "Data Requisição:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(108, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 23);
            this.btnSalvar.TabIndex = 84;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(28, 37);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(256, 21);
            this.cboUsuario.TabIndex = 106;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 105;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cboLivro
            // 
            this.cboLivro.FormattingEnabled = true;
            this.cboLivro.Location = new System.Drawing.Point(28, 83);
            this.cboLivro.Name = "cboLivro";
            this.cboLivro.Size = new System.Drawing.Size(256, 21);
            this.cboLivro.TabIndex = 108;
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Location = new System.Drawing.Point(25, 67);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(33, 13);
            this.lblLivro.TabIndex = 107;
            this.lblLivro.Text = "Livro:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(28, 286);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(256, 21);
            this.cboStatus.TabIndex = 109;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 270);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 110;
            this.lblStatus.Text = "Status:";
            // 
            // RequisicaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboLivro);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.dtpDataDevolucao);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.dtpDataRequisicao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lboDados);
            this.Controls.Add(this.lblDataRequisicao);
            this.Controls.Add(this.btnSalvar);
            this.Name = "RequisicaoControl";
            this.Size = new System.Drawing.Size(642, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDataDevolucao;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.DateTimePicker dtpDataRequisicao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Label lblDataRequisicao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboLivro;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}
