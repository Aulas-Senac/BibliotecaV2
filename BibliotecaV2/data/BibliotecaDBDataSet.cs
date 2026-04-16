namespace BibliotecaV2.data
{


    partial class BibliotecaDBDataSet
    {
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
