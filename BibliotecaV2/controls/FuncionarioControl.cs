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
        #region campos

        private List<FuncionariosRow> _listaCache = new List<FuncionariosRow>();

        #endregion

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

            using (FuncionariosTableAdapter funcionariosTable = new FuncionariosTableAdapter())
            {
                _listaCache = funcionariosTable.GetData().ToList();
            }

            FiltrarLista(txtPesquisa.Text);
        }

        private void FiltrarLista(string termo)
        {
            lboDados.Items.Clear();

            var resultado = string.IsNullOrWhiteSpace(termo)
                            ? _listaCache
                            : _listaCache.Where(f => f.NomeUsuario.ToLower().Contains(termo.Trim().ToLower())).ToList();

            foreach (var item in resultado)
            {
                lboDados.Items.Add(item);
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
            using (FuncionariosTableAdapter adapter = new FuncionariosTableAdapter())
            {
                var data = adapter.GetData();

                var cargosExistentes = data
                .Select(f => f.Cargo)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

                cboCargos.Items.Clear();
                cboCargos.Items.AddRange(cargosExistentes.ToArray());
            }
            // Usamos LINQ para pegar apenas a coluna Cargo, remover duplicados e nulos
        }

        #endregion

        #region eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validar campos e retornar caso falso
            DateTime? ultimoLogin = null;

            if (dtpUltimoLogin.CustomFormat != " ")
            {
                ultimoLogin = dtpUltimoLogin.Value;
            }

            using (FuncionariosTableAdapter funcionariosTable = new FuncionariosTableAdapter())
            {
                // cadastro
                if (lboDados.SelectedItem == null)
                {
                    funcionariosTable.Insert(
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

                    funcionariosTable.Update(
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
            }
            AtualizarLista();
            LimparElementos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            FuncionariosRow funcionariosRow = lboDados.SelectedItem as FuncionariosRow;

            if (funcionariosRow == null) return;

            using (FuncionariosTableAdapter funcionariosTable = new FuncionariosTableAdapter())
            {
                funcionariosTable.Delete(funcionariosRow.FuncionarioID);
            }

            AtualizarLista();
            LimparElementos();
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
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
            FiltrarLista(txtPesquisa.Text);
        }

        #endregion
    }
}
