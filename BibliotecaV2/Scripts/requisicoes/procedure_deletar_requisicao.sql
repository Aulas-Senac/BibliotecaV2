USE BibliotecaDB
GO

CREATE PROCEDURE DeletarRequisicao
	@Id INT
AS
BEGIN
	DELETE FROM Requisicoes
	WHERE RequisicaoID = @Id;
END