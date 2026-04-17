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

        #region campos

        private List<LivrosRow> _listaCache = new List<LivrosRow>();
        
        #endregion

        #region construtores

        public LivrosControl()
        {
            InitializeComponent();
            AtualizarLista();
        }

        #endregion

        #region metodos
        private void AtualizarLista()
        {
            lboDados.Items.Clear();
            using (LivrosTableAdapter livrosTable = new LivrosTableAdapter())
            {
                _listaCache = livrosTable.GetData().ToList();
            }

            FiltrarLista(txtPesquisa.Text);
        }

        private void FiltrarLista(string termo)
        {
            lboDados.Items.Clear();

            var resultado = string.IsNullOrWhiteSpace(termo)
                            ? _listaCache
                            : _listaCache.Where(l => l.Titulo.ToLower().Contains(termo.Trim().ToLower())).ToList();

            foreach (var item in resultado)
            {
                lboDados.Items.Add(item);
            }
        }

        private void LimparElementos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditora.Clear();
            txtGenero.Clear();
            txtISBN.Clear();
            txtQuantidade.Clear();
            lboDados.SelectedIndex = -1;
        }

        #endregion

        #region eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validar campos e retornar caso falso

            using (var livrosTable = new LivrosTableAdapter())
            {
                // cadastro
                if (lboDados.SelectedItem == null)
                {
                    if (int.TryParse(txtQuantidade.Text, out int quantidade))
                    {
                        livrosTable.Insert(txtTitulo.Text, txtGenero.Text, txtAutor.Text, txtEditora.Text, txtISBN.Text, quantidade);
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida.");
                        return;
                    }
                }
                else // atualização
                {
                    LivrosRow livro = lboDados.SelectedItem as LivrosRow;

                    if (livro == null) return;

                    if (int.TryParse(txtQuantidade.Text, out int quantidade))
                    {
                        livrosTable.Update(livro.LivroID, txtTitulo.Text, txtGenero.Text, txtAutor.Text, txtEditora.Text, txtISBN.Text, quantidade);
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida.");
                        return;
                    }
                }
            }
            AtualizarLista();
            LimparElementos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            LivrosRow livrosRow = lboDados.SelectedItem as LivrosRow;
            if (livrosRow == null) return;

            using (LivrosTableAdapter livrosTable = new LivrosTableAdapter())
            {
                livrosTable.Delete(livrosRow.LivroID);
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

        private void lboLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            LivrosRow livrosRow = lboDados.SelectedItem as LivrosRow;

            if (livrosRow == null) return;

            txtTitulo.Text = livrosRow.Titulo;
            txtGenero.Text = livrosRow.Genero;
            txtQuantidade.Text = livrosRow.QuantidadeDisponivel.ToString();
            txtEditora.Text = livrosRow.Editora;
            txtISBN.Text = livrosRow.ISBN;
            txtAutor.Text = livrosRow.Autor;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            FiltrarLista(txtPesquisa.Text);
        }
        #endregion
    }
}
