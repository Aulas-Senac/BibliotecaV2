USE BibliotecaDB
GO

CREATE PROCEDURE AtualizarRequisicao
	@RequisicaoID INT,
    @UsuarioID INT,
    @LivroID INT,
    @FuncionarioID INT,
    @DataDevolucao DATETIME,
    @Status NVARCHAR(20) 
AS
BEGIN
    UPDATE Requisicoes
    SET
        UsuarioID = @UsuarioID,
        LivroID = @LivroID,
        FuncionarioID = @FuncionarioID,
        DataDevolucao = @DataDevolucao,
        Status = @Status
    WHERE RequisicaoID = @RequisicaoID 
END