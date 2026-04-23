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

        public RequisicaoControl()
        {
            InitializeComponent();
            AtualizarDados();
            FormatarDatas();
        }

        private void FormatarDatas()
        {
            dtpDataRequisicao.Format = DateTimePickerFormat.Custom;
            dtpDataRequisicao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDataRequisicao.Enabled = false;

            dtpDataDevolucao.Format = DateTimePickerFormat.Custom;
            dtpDataDevolucao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void AtualizarDados()
        {
            ConfigurarRequisicoes();
            ConfigurarUsuarios();
            ConfigurarLivros();
            ConfigurarFuncionarios();

            ConfigurarListBoxDados();
            ConfigurarComboBox();
        }

        private void ConfigurarRequisicoes()
        {
            RequisicoesTableAdapter requisicaoTable = new RequisicoesTableAdapter();
            requisicoes = requisicaoTable.GetData().ToList();
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

        private void ConfigurarListBoxDados()
        {
            foreach (var requisicao in requisicoes)
            {
                UsuariosRow usuarioEncontrado = ObterUsuarioPorId(requisicao.UsuarioID);
                LivrosRow livroEncontrado = ObterLivroPorId(requisicao.LivroID);
                FuncionariosRow funcionarioEncontrado = ObterFuncionarioPorId(requisicao.FuncionarioID);

                lboDados.Items.Add(requisicao);
            }
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
            cboUsuario.Items.Clear();
            cboLivro.Items.Clear();
            cboFuncionario.Items.Clear();
        }

        private void ConfigurarComboBox()
        {
            LimparElementos();

            foreach (var requisicao in requisicoes)
            {

                UsuariosRow usuarioEncontrado = usuarios.FirstOrDefault(u => u.UsuarioID == requisicao.UsuarioID);
                LivrosRow livroEncontrado = livros.FirstOrDefault(l => l.LivroID == requisicao.LivroID);
                FuncionariosRow funcionarioEncontrado = funcionarios.FirstOrDefault(f => f.FuncionarioID == requisicao.FuncionarioID);

                cboUsuario.Items.Add(usuarioEncontrado.Nome);
                cboLivro.Items.Add(livroEncontrado.Titulo);
                cboFuncionario.Items.Add(funcionarioEncontrado.NomeCompleto);

                if (!cboStatus.Items.Contains(requisicao.Status))
                {
                    cboStatus.Items.Add(requisicao.Status);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicoesRow requisicao = lboDados.SelectedItem as RequisicoesRow;

            if (requisicao == null) return;

            UsuariosRow usuario = ObterUsuarioPorId(requisicao.UsuarioID);
            LivrosRow livro = ObterLivroPorId(requisicao.LivroID);
            FuncionariosRow funcionario = ObterFuncionarioPorId(requisicao.FuncionarioID);

            if (usuario != null)
            {
                cboUsuario.Text = usuario.Nome;
            }

            if (livro != null)
            {
                cboLivro.Text = livro.Titulo;
            }

            if (funcionario != null)
            {
                cboFuncionario.Text = funcionario.NomeCompleto;
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
