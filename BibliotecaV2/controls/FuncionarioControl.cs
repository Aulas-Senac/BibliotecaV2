using BibliotecaV2.data.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaV2.data.BibliotecaDBDataSet;

namespace BibliotecaV2.controls
{
    public partial class FuncionarioControl : UserControl
    {

        #region construtores
        public FuncionarioControl()
        {
            InitializeComponent();
            AtualizarLista();

            ConfigurarDatas();
            ConfigurarComboBox();
        }
        #endregion

        #region metodos
        private void AtualizarLista()
        {
            lboDados.Items.Clear();

            FuncionariosTableAdapter funcionariosTable = new FuncionariosTableAdapter();

            var data = funcionariosTable.GetData();

            foreach (var dado in data)
            {
                lboDados.Items.Add(dado);
            }
        }

        private void LimparElementos()
        {
            txtUsuario.Clear();
            txtSenhaHash.Clear();
            txtNomeCompleto.Clear();
            cboCargos.SelectedItem = null;
            txtEmail.Clear();
            lboDados.SelectedIndex = -1;
        }

        private void ConfigurarDatas()
        {
            dtpDataCadastro.Enabled = false;
            dtpDataCadastro.Format = DateTimePickerFormat.Custom;
            dtpDataCadastro.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtpUltimoLogin.Enabled = false;
            dtpUltimoLogin.Format = DateTimePickerFormat.Custom;
            dtpUltimoLogin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void ConfigurarComboBox()
        {
            FuncionariosTableAdapter adapter = new FuncionariosTableAdapter();
            var data = adapter.GetData();

            // Usamos LINQ para pegar apenas a coluna Cargo, remover duplicados e nulos
            var cargosExistentes = data
                .Select(f => f.Cargo)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            cboCargos.Items.Clear();
            cboCargos.Items.AddRange(cargosExistentes.ToArray());
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
            DateTime? ultimoLogin = null;

            if (dtpUltimoLogin.CustomFormat != " ")
            {
                ultimoLogin = dtpUltimoLogin.Value;
            }

            FuncionariosTableAdapter funcionarioTable = new FuncionariosTableAdapter();
            // cadastro
            if (lboDados.SelectedItem == null)
            {
                funcionarioTable.Insert(
                    txtUsuario.Text,
                    txtSenhaHash.Text,
                    txtNomeCompleto.Text,
                    cboCargos.Text,
                    txtEmail.Text,
                    ultimoLogin,
                    chkAtivo.Checked
                );
            }
            else // atualização
            {
                FuncionariosRow funcionariosRow = lboDados.SelectedItem as FuncionariosRow;

                if (funcionariosRow == null) return;

                funcionarioTable.Update(
                    funcionariosRow.FuncionarioID,
                    txtUsuario.Text,
                    txtSenhaHash.Text,
                    txtNomeCompleto.Text,
                    cboCargos.Text,
                    txtEmail.Text,
                    ultimoLogin,
                    chkAtivo.Checked
                );
            }
            AtualizarLista();
            LimparElementos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lboDados.SelectedItem == null) return;

            FuncionariosRow funcionariosRow = lboDados.SelectedItem as FuncionariosRow;

            if (funcionariosRow == null) return;

            FuncionariosTableAdapter funcionariosTable = new FuncionariosTableAdapter();

            funcionariosTable.Delete(funcionariosRow.FuncionarioID);

            AtualizarLista();
            LimparElementos();
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncionariosRow funcionariosRow = lboDados.SelectedItem as FuncionariosRow;

            if (funcionariosRow == null) return;

            txtUsuario.Text = funcionariosRow.NomeUsuario;
            txtSenhaHash.Text = funcionariosRow.SenhaHash;
            txtNomeCompleto.Text = funcionariosRow.NomeCompleto;
            cboCargos.Text = funcionariosRow.Cargo;
            txtEmail.Text = funcionariosRow.Email;
            dtpDataCadastro.Value = funcionariosRow.DataCadastro;

            if (!funcionariosRow.IsUltimoLoginNull()) // evitar null exception
            {
                dtpUltimoLogin.Value = funcionariosRow.UltimoLogin;
            }
            else
            {
                dtpUltimoLogin.CustomFormat = " ";
            }

            chkAtivo.Checked = funcionariosRow.Ativo;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                AtualizarLista();
                return;
            }

            string termo = txtPesquisa.Text.Trim().ToLower();

            FuncionariosTableAdapter dados = new FuncionariosTableAdapter();

            var listaUsuarios = dados.GetData().ToList();

            var filtrados = listaUsuarios
                .Where(f => f.NomeUsuario.ToLower().Contains(termo))
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
