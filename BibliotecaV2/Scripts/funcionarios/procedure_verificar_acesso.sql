USE BibliotecaDB
GO

CREATE PROCEDURE VerificarAcesso
	@usuario NVARCHAR(50),
	@senha VARBINARY(32) -- 2^32 = 256
AS
BEGIN
	SELECT FuncionarioID FROM Funcionarios
	WHERE 
		NomeUsuario = @usuario AND
		SenhaHash = @senha
END
GO

DECLARE @TEMP VARBINARY(32)
SET @TEMP = HASHBYTES('SHA2_256', 'Senha123!')

EXEC VerificarAcesso 'rlima',  @TEMP
GO