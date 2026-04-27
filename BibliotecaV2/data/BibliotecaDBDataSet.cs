using BibliotecaV2.data.BibliotecaDBDataSetTableAdapters;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Cryptography;

namespace BibliotecaV2.data
{


    partial class BibliotecaDBDataSet
    {
        partial class RequisicoesRow
        {
            public override string ToString()
            {
                UsuariosTableAdapter usuariosTable = new UsuariosTableAdapter();
                List<UsuariosRow> usuarios = usuariosTable.GetData().ToList();

                FuncionariosTableAdapter funcionariosTable = new FuncionariosTableAdapter();
                List<FuncionariosRow> funcionarios = funcionariosTable.GetData().ToList();

                LivrosTableAdapter livrosTable = new LivrosTableAdapter();
                List<LivrosRow> livros = livrosTable.GetData().ToList();


                UsuariosRow usuarioEncontrado = usuarios.FirstOrDefault(u => u.UsuarioID == this.UsuarioID);
                LivrosRow livroEncontrado = livros.FirstOrDefault(l => l.LivroID == this.LivroID);
                FuncionariosRow funcionarioEncontrado = funcionarios.FirstOrDefault(f => f.FuncionarioID == this.FuncionarioID);

                string dataDevolucao = this.IsDataDevolucaoNull() ? "Devolvido" : this.DataDevolucao.ToString("dd/MM/yyyy HH:mm:ss");

                return $"{usuarioEncontrado.Nome} | {livroEncontrado.Titulo} | {funcionarioEncontrado.NomeCompleto} | {this.DataRequisicao} | {dataDevolucao} | {this.Status}";
            }
        }

        partial class FuncionariosRow
        {
            public override string ToString()
            {
                // Supondo que existe uma coluna chamada UltimoLogin do tipo DateTime? (nullable)
                // e que "Nunca" deve ser exibido se o valor for nulo.
                string ultimoLoginTexto = this.IsUltimoLoginNull() ? "Nunca" : this.UltimoLogin.ToString("dd/MM/yyyy HH:mm:ss");

                return $"{NomeUsuario} | {SenhaHash} | {NomeCompleto} | {Cargo} | {Email} | {DataCadastro:dd/MM/yyyy HH:mm:ss} | {ultimoLoginTexto} | {(Ativo == true ? "Ativo" : "Não Ativo")}";
            }
        }

        partial class ObterLivroDataTable
        {
        }

        partial class LivrosRow
        {
            public override string ToString()
            {
                return $"{Titulo} | {Genero} | {Autor} | {Editora} | {ISBN} | {QuantidadeDisponivel} | {DataCadastro}";
            }
        }

        partial class UsuariosRow
        {
            public override string ToString()
            {
                return $"{UsuarioID} - {Nome} | {Telefone} | {Email}";
            }
        }
    }
}
