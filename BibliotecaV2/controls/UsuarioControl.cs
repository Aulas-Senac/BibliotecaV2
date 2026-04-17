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
        #region campos
        private List<UsuariosRow> _listaCache = new List<UsuariosRow>();
        #endregion

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
            using (UsuariosTableAdapter usuariosTable = new UsuariosTableAdapter())
            {
                _listaCache = usuariosTable.GetData().ToList();
            }

            FiltrarLista(txtPesquisa.Text);
        }

        private void FiltrarLista(string termo)
        {
            lboDados.Items.Clear();

            var resultado = string.IsNullOrWhiteSpace(termo)
                            ? _listaCache
                            : _listaCache.Where(u => u.Nome.ToLower().Contains(termo.Trim().ToLower())).ToList();

            foreach (var item in resultado)
            {
                lboDados.Items.Add(item);
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
  
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validar campos e retornar caso falso

            using (var usuarioTable = new UsuariosTableAdapter())
            {
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
            }
            AtualizarLista();
            LimparElementos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            UsuariosRow usuariosRow = lboDados.SelectedItem as UsuariosRow;
            if (usuariosRow == null) return;

            using (UsuariosTableAdapter usuariosTable = new UsuariosTableAdapter())
            {
                usuariosTable.Delete(usuariosRow.UsuarioID);
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
            UsuariosRow usuariosRow = lboDados.SelectedItem as UsuariosRow;

            if (usuariosRow == null) return;

            txtNome.Text = usuariosRow.Nome;
            txtEmail.Text = usuariosRow.Email;
            txtTelefone.Text = usuariosRow.Telefone;
            dtpDataCadastro.Value = usuariosRow.DataCadastro;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            FiltrarLista(txtPesquisa.Text);
        }

        #endregion
    }
}
