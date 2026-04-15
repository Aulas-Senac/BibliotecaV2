USE BibliotecaDB
GO

CREATE PROCEDURE InserirRequisicao
    @UsuarioID INT,
    @LivroID INT,
    @FuncionarioID INT,
    @DataDevolucao DATETIME
AS
BEGIN
    INSERT INTO Requisicoes(UsuarioID, LivroID, FuncionarioID, DataDevolucao)
    VALUES(@UsuarioID, @LivroID, @FuncionarioID, @DataDevolucao)
END