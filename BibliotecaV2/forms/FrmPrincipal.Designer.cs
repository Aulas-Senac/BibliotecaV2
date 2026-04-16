namespace BibliotecaV2.forms
{
    partial class FrmPrincipal
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pcoLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlRequisicoes = new System.Windows.Forms.Panel();
            this.btnRequisicoes = new System.Windows.Forms.Button();
            this.pnlFuncionarios = new System.Windows.Forms.Panel();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.pnlLivros = new System.Windows.Forms.Panel();
            this.btnLivros = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcoLogo)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlRequisicoes.SuspendLayout();
            this.pnlFuncionarios.SuspendLayout();
            this.pnlLivros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(75)))), ((int)(((byte)(93)))));
            this.pnlHeader.Controls.Add(this.tableLayoutPanel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(75)))), ((int)(((byte)(93)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pcoLogo);
            this.pnlLogo.Location = new System.Drawing.Point(17, 5);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(9, 5, 0, 5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(30, 60);
            this.pnlLogo.TabIndex = 1;
            // 
            // pcoLogo
            // 
            this.pcoLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcoLogo.ErrorImage = null;
            this.pcoLogo.Image = global::BibliotecaV2.Properties.Resources.livro_32_cinza;
            this.pcoLogo.InitialImage = null;
            this.pcoLogo.Location = new System.Drawing.Point(0, 0);
            this.pcoLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pcoLogo.Name = "pcoLogo";
            this.pcoLogo.Size = new System.Drawing.Size(30, 60);
            this.pcoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcoLogo.TabIndex = 0;
            this.pcoLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(217)))));
            this.lblTitulo.Location = new System.Drawing.Point(51, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(746, 70);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Biblioteca";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(217)))));
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(158, 70);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(642, 380);
            this.pnlConteudo.TabIndex = 1;
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Controls.Add(this.btnUsuarios);
            this.pnlUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlUsuarios.Size = new System.Drawing.Size(158, 49);
            this.pnlUsuarios.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(158, 44);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(75)))), ((int)(((byte)(93)))));
            this.pnlMenuLateral.Controls.Add(this.pnlRequisicoes);
            this.pnlMenuLateral.Controls.Add(this.pnlFuncionarios);
            this.pnlMenuLateral.Controls.Add(this.pnlLivros);
            this.pnlMenuLateral.Controls.Add(this.pnlUsuarios);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 70);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(158, 380);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // pnlRequisicoes
            // 
            this.pnlRequisicoes.Controls.Add(this.btnRequisicoes);
            this.pnlRequisicoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequisicoes.Location = new System.Drawing.Point(0, 147);
            this.pnlRequisicoes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlRequisicoes.Name = "pnlRequisicoes";
            this.pnlRequisicoes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlRequisicoes.Size = new System.Drawing.Size(158, 49);
            this.pnlRequisicoes.TabIndex = 3;
            // 
            // btnRequisicoes
            // 
            this.btnRequisicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnRequisicoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRequisicoes.FlatAppearance.BorderSize = 0;
            this.btnRequisicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequisicoes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisicoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRequisicoes.Location = new System.Drawing.Point(0, 0);
            this.btnRequisicoes.Name = "btnRequisicoes";
            this.btnRequisicoes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRequisicoes.Size = new System.Drawing.Size(158, 44);
            this.btnRequisicoes.TabIndex = 0;
            this.btnRequisicoes.Text = "Requisições";
            this.btnRequisicoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequisicoes.UseVisualStyleBackColor = false;
            this.btnRequisicoes.Click += new System.EventHandler(this.btnRequisicoes_Click);
            // 
            // pnlFuncionarios
            // 
            this.pnlFuncionarios.Controls.Add(this.btnFuncionarios);
            this.pnlFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFuncionarios.Location = new System.Drawing.Point(0, 98);
            this.pnlFuncionarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlFuncionarios.Name = "pnlFuncionarios";
            this.pnlFuncionarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlFuncionarios.Size = new System.Drawing.Size(158, 49);
            this.pnlFuncionarios.TabIndex = 2;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnFuncionarios.Size = new System.Drawing.Size(158, 44);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // pnlLivros
            // 
            this.pnlLivros.Controls.Add(this.btnLivros);
            this.pnlLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLivros.Location = new System.Drawing.Point(0, 49);
            this.pnlLivros.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlLivros.Name = "pnlLivros";
            this.pnlLivros.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlLivros.Size = new System.Drawing.Size(158, 49);
            this.pnlLivros.TabIndex = 1;
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnLivros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLivros.Location = new System.Drawing.Point(0, 0);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLivros.Size = new System.Drawing.Size(158, 44);
            this.btnLivros.TabIndex = 0;
            this.btnLivros.Text = "Livros";
            this.btnLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.pnlHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcoLogo)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlRequisicoes.ResumeLayout(false);
            this.pnlFuncionarios.ResumeLayout(false);
            this.pnlLivros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pcoLogo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlFuncionarios;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Panel pnlLivros;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Panel pnlRequisicoes;
        private System.Windows.Forms.Button btnRequisicoes;
    }
}