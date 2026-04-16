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
    public partial class LivrosControl : UserControl
    {

        public LivrosControl()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lboDados.Items.Clear();
            LivrosTableAdapter LivrosDados = new LivrosTableAdapter();
            var dados = from linha in LivrosDados.GetData()
                        select linha;
            foreach (LivrosRow dado in dados) lboDados.Items.Add(dado);
        }

        private void limparElementos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtGenero.Text = "";
            txtISBN.Text = "";
            txtQuantidade.Text = "";
        }

        private void lboLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboDados.SelectedItem == null) return;
            LivrosRow livro = lboDados.SelectedItem as LivrosRow;
            if (livro == null) return;
            btnAjuste.Text = "Atualizar";
            btnAcoes.Text = "Excluir";
            txtTitulo.Text = livro.Titulo;
            txtGenero.Text = livro.Genero;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();
            txtEditora.Text = livro.Editora;
            txtISBN.Text = livro.ISBN;
            txtAutor.Text = livro.Autor;
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboDados.SelectedItem == null) return;
                LivrosRow livro = lboDados.SelectedItem as LivrosRow;
                if (livro == null) return;
                LivrosTableAdapter livros = new LivrosTableAdapter();
                //livros.Delete(livro.LivroID);
                AtualizarLista();
                limparElementos();
                btnAcoes.Text = "Atualizar Lista";
                btnAjuste.Text = "Cadastrar";
            }
            else
            {
                AtualizarLista();
            }
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            if (btnAjuste.Text == "Cadastrar")
            {
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string genero = txtGenero.Text;
                string editora = txtEditora.Text;
                string isbn = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    //livros.Insert(titulo, genero, autor, editora, isbn, quantidade);
                    AtualizarLista();
                    limparElementos();
                }
                catch
                {
                    MessageBox.Show("Erro de código");
                }
            }
            else
            {
                if (lboDados.SelectedItem == null)
                {
                    lboDados.ClearSelected();
                    AtualizarLista();
                    limparElementos();
                    return;
                }
                LivrosRow livro = lboDados.SelectedItem as LivrosRow;
                if (livro == null) return;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string genero = txtGenero.Text;
                string editora = txtEditora.Text;
                string isbn = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    //livros.Update(livro.LivroID, titulo, genero, autor, editora, isbn, quantidade);
                    AtualizarLista();
                    limparElementos();

                    btnAcoes.Text = "Atualizar Lista";
                    btnAjuste.Text = "Cadastrar";
                }
                catch
                {
                    MessageBox.Show("Erro de código");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboDados.ClearSelected();
            AtualizarLista();
            limparElementos();
            btnAcoes.Text = "Atualizar Lista";
            btnAjuste.Text = "Cadastrar";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                AtualizarLista();
                return;
            }

            string termo = txtPesquisa.Text.Trim().ToLower();

            LivrosTableAdapter dados = new LivrosTableAdapter();

            var listaUsuarios = dados.GetData().ToList();

            var filtrados = listaUsuarios
                .Where(l => l.Titulo.ToLower().Contains(termo))
                .ToList();

            lboDados.Items.Clear();

            foreach (var livro in filtrados)
            {
                lboDados.Items.Add(livro);
            }
        }
    }
}
