USE BibliotecaDB
GO

CREATE PROCEDURE DeletarFuncionario
	@Id INT
AS
BEGIN
	DELETE FROM Funcionarios
	WHERE FuncionarioID = @Id
END