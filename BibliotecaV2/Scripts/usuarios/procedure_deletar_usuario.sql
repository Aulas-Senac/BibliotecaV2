USE BibliotecaDB
GO

CREATE PROCEDURE DeletarUsuario
	@Id INT
AS
BEGIN
	DELETE FROM Usuarios 
	WHERE UsuarioID = @Id
END
