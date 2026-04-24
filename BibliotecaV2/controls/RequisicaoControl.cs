using BibliotecaV2.data.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaV2.data.BibliotecaDBDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BibliotecaV2.controls
{
    public partial class RequisicaoControl : UserControl
    {
        private List<RequisicoesRow> requisicoes = new List<RequisicoesRow>();
        private List<UsuariosRow> usuarios = new List<UsuariosRow>();
        private List<LivrosRow> livros = new List<LivrosRow>();
        private List<FuncionariosRow> funcionarios = new List<FuncionariosRow>();

        private bool isConfiguracaoInicial = false;

        public RequisicaoControl()
        {
            InitializeComponent();
            IniciarConfiguracoes(); 
        }

        private void FormatarDatas()
        {
            dtpDataRequisicao.Format = DateTimePickerFormat.Custom;
            dtpDataRequisicao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDataRequisicao.Enabled = false;

            dtpDataDevolucao.Format = DateTimePickerFormat.Custom;
            dtpDataDevolucao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDataDevolucao.Enabled = false;
        }

        private void IniciarConfiguracoes()
        {
            if (!isConfiguracaoInicial)
            {
                FormatarDatas();
                cboStatus.Enabled = false;

                ConfigurarUsuarios();
                ConfigurarLivros();
                ConfigurarFuncionarios();

                ConfigurarCombosBox();
                AtualizarDados();
            }
        }

        private void AtualizarDados()
        {
            ConfigurarRequisicoes();
        }

        private void ConfigurarRequisicoes()
        {
            RequisicoesTableAdapter requisicaoTable = new RequisicoesTableAdapter();
            requisicoes = requisicaoTable.GetData().ToList();

            ConfigurarListBoxDados();
        }

        private void ConfigurarListBoxDados()
        {
            lboDados.Items.Clear();

            foreach (var requisicao in requisicoes)
            {
                lboDados.Items.Add(requisicao);
            }
        }

        private void ConfigurarUsuarios()
        {

            UsuariosTableAdapter usuariosTable = new UsuariosTableAdapter();
            usuarios = usuariosTable.GetData().ToList();

        }

        private void ConfigurarLivros()
        {

            LivrosTableAdapter livrosTable = new LivrosTableAdapter();
            livros = livrosTable.GetData().ToList();
        }

        private void ConfigurarFuncionarios()
        {

            FuncionariosTableAdapter funcionariosTable = new FuncionariosTableAdapter();
            funcionarios = funcionariosTable.GetData().ToList();
        }   

        private UsuariosRow ObterUsuarioPorId(int id)
        {
            return usuarios.FirstOrDefault(u => u.UsuarioID == id);
        }

        private LivrosRow ObterLivroPorId(int id)
        {
            return livros.FirstOrDefault(l => l.LivroID == id);
        }

        private FuncionariosRow ObterFuncionarioPorId(int id)
        {
            return funcionarios.FirstOrDefault(f => f.FuncionarioID == id);
        }

        private void LimparElementos()
        {
            cboUsuario.SelectedIndex = -1;
            cboLivro.SelectedIndex = -1;
            cboFuncionario.SelectedIndex = -1;
            dtpDataRequisicao.Value = DateTime.Now;
            dtpDataDevolucao.Value = DateTime.Now;
            cboStatus.SelectedIndex = -1;
            lboDados.SelectedItem = null;
        }

        private void ConfigurarCombosBox()
        {
            LimparElementos();

            cboUsuario.DisplayMember = "Nome";
            cboUsuario.DataSource = usuarios;

            cboLivro.DisplayMember = "Titulo";
            cboLivro.DataSource = livros;

            cboFuncionario.DisplayMember = "NomeCompleto";
            cboFuncionario.DataSource = funcionarios;

            // ajustar itens do cbo
            List<String> status = new List<string>();

            foreach (var requisicao in requisicoes)
            {
                if (!cboStatus.Items.Contains(requisicao.Status))
                {
                    cboStatus.Items.Add(requisicao.Status);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosRow usuario = cboUsuario.SelectedItem as UsuariosRow;
            LivrosRow livro = cboLivro.SelectedItem as LivrosRow;
            FuncionariosRow funcionario = cboFuncionario.SelectedItem as FuncionariosRow;

            if (usuario == null || livro == null || funcionario == null)
            {
                MessageBox.Show("Selecione usuário, livro e funcionário");
                return;
            }

            using (RequisicoesTableAdapter requisicoesTable = new RequisicoesTableAdapter())
            {
                // cadastro
                if (lboDados.SelectedItem == null)
                {
                    requisicoesTable.Insert(usuario.UsuarioID, livro.LivroID, funcionario.FuncionarioID);
                }
                // edição
                else
                {
                    RequisicoesRow requisicao = lboDados.SelectedItem as RequisicoesRow;

                    if (requisicao == null) return;

                    requisicoesTable.Update(requisicao.RequisicaoID, usuario.UsuarioID, livro.LivroID, funcionario.FuncionarioID, requisicao.DataDevolucao, requisicao.Status);
                }
            }
            AtualizarDados();
            LimparElementos();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RequisicoesRow requisicao = lboDados.SelectedItem as RequisicoesRow;

            if (requisicao == null) return;

            RequisicoesTableAdapter requisicoesTable = new RequisicoesTableAdapter();

            requisicoesTable.Delete(requisicao.RequisicaoID);

            AtualizarDados();
            LimparElementos();
        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicoesRow requisicao = lboDados.SelectedItem as RequisicoesRow;

            if (requisicao == null) return;

            cboStatus.Enabled = true;

            UsuariosRow usuario = ObterUsuarioPorId(requisicao.UsuarioID);
            LivrosRow livro = ObterLivroPorId(requisicao.LivroID);
            FuncionariosRow funcionario = ObterFuncionarioPorId(requisicao.FuncionarioID);

            if (usuario != null)
            {
                cboUsuario.SelectedItem = usuario;
            }

            if (livro != null)
            {
                cboLivro.SelectedItem = livro;
            }

            if (funcionario != null)
            {
                cboFuncionario.SelectedItem = funcionario;
            }

            dtpDataRequisicao.Value = requisicao.DataRequisicao;

            if (!requisicao.IsDataDevolucaoNull()) // evitar null exception
            {
                dtpDataDevolucao.Value = requisicao.DataDevolucao;
            }
            else
            {
                dtpDataDevolucao.CustomFormat = " ";
            }

            cboStatus.Text = requisicao.Status;
        }
    }
}