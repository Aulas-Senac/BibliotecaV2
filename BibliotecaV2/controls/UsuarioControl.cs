using BibliotecaV2.data.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaV2.data.BibliotecaDBDataSet;

namespace BibliotecaV2.controls
{
    public partial class UsuarioControl : UserControl
    {

        #region construtores
        public UsuarioControl()
        {
            InitializeComponent();
            AtualizarLista();
            
            dtpDataCadastro.Format = DateTimePickerFormat.Custom;
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }
        #endregion

        #region metodos
        private void AtualizarLista()
        {
            lboDados.Items.Clear();

            UsuariosTableAdapter usuariosTable = new UsuariosTableAdapter();

            var data = usuariosTable.GetData();

            foreach (var dado in data)
            {
                lboDados.Items.Add(dado);
            }
        }

        private void LimparElementos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            lboDados.SelectedIndex = -1;
        }

        #endregion

        #region eventos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validar campos e retornar caso falso

            UsuariosTableAdapter usuarioTable = new UsuariosTableAdapter();
            // cadastro
            if (lboDados.SelectedItem == null)
            {
                usuarioTable.Insert(txtNome.Text, txtEmail.Text, txtTelefone.Text);
            }
            else // atualização
            {
                UsuariosRow usuariosRow = lboDados.SelectedItem as UsuariosRow;

                if (usuariosRow == null) return;

                usuarioTable.Update(usuariosRow.UsuarioID, txtNome.Text, txtEmail.Text, txtTelefone.Text);
            }
            AtualizarLista();
            LimparElementos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lboDados.SelectedItem == null) return;

            UsuariosRow usuariosRow = lboDados.SelectedItem as UsuariosRow;

            if (usuariosRow == null) return;

            UsuariosTableAdapter usuariosTable = new UsuariosTableAdapter();

            usuariosTable.Delete(usuariosRow.UsuarioID);

            AtualizarLista();
            LimparElementos();
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsuariosRow usuariosRow = lboDados.SelectedItem as UsuariosRow;

            if (usuariosRow == null) return;

            txtNome.Text = usuariosRow.Nome;
            txtEmail.Text = usuariosRow.Email;
            txtTelefone.Text = usuariosRow.Telefone;
            dtpDataCadastro.Value = usuariosRow.DataCadastro;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                AtualizarLista();
                return;
            }

            string termo = txtPesquisa.Text.Trim().ToLower();

            UsuariosTableAdapter dados = new UsuariosTableAdapter();

            var listaUsuarios = dados.GetData().ToList();

            var filtrados = listaUsuarios
                .Where(u => u.Nome.ToLower().Contains(termo))
                .ToList();

            lboDados.Items.Clear();

            foreach (var usuario in filtrados)
            {
                lboDados.Items.Add(usuario);
            }
        }

        #endregion
    }
}
