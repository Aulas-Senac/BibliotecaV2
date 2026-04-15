USE BibliotecaDB
GO

CREATE PROCEDURE InserirUsuario
	@Nome NVARCHAR(100),
	@Email NVARCHAR(100),
	@Telefone NVARCHAR(15)
AS
BEGIN
	INSERT INTO Usuarios(Nome, Email, Telefone)
	VALUES (@Nome, @Email, @Telefone)
END