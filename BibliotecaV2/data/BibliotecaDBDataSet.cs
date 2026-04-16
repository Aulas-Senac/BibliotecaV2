using System.Runtime.Remoting.Messaging;

namespace BibliotecaV2.data
{


    partial class BibliotecaDBDataSet
    {
        partial class UsuariosDataTable
        {
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
