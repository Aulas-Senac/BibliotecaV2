using BibliotecaV2.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaV2.forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        #region metodos

        private void AbrirTela(Control tela) {
            // Descarta todos os controles anteriores
            foreach (Control c in pnlConteudo.Controls)
                c.Dispose();

            pnlConteudo.Controls.Clear();
            tela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(tela);
        }

        #endregion

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioControl usuarioControl = new UsuarioControl();
            AbrirTela(usuarioControl);
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            LivrosControl livrosControl = new LivrosControl();
            AbrirTela(livrosControl);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            FuncionarioControl funcionarioControl = new FuncionarioControl();
            AbrirTela(funcionarioControl);
        }

        private void btnRequisicoes_Click(object sender, EventArgs e)
        {
            RequisicaoControl requisicaoControl = new RequisicaoControl();
            AbrirTela(requisicaoControl);
        }
    }
}
