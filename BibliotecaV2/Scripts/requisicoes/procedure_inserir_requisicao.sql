USE BibliotecaDB
GO

CREATE PROCEDURE InserirRequisicao
    @UsuarioID INT,
    @LivroID INT,
    @FuncionarioID INT
AS
BEGIN
    UPDATE Livros SET QuantidadeDisponivel = QuantidadeDisponivel - 1 
    WHERE LivroID = @LivroID AND QuantidadeDisponivel > 0;

    INSERT INTO Requisicoes(UsuarioID, LivroID, FuncionarioID, DataDevolucao, Status)
    VALUES(@UsuarioID, @LivroID, @FuncionarioID, DATEADD(DAY, 7, GETDATE()), 'Aprovada')
END


exec ObterRequisicao