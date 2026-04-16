namespace BibliotecaV2.data
{


    partial class BibliotecaDBDataSet
    {
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

        partial class UsuariosDataTable
        {
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
