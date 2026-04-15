USE BibliotecaDB
GO

CREATE PROCEDURE AtualizarUsuario
	@Id INT,
    @Nome NVARCHAR(100),
    @Email NVARCHAR(100),
    @Telefone NVARCHAR(15)
AS 
BEGIN
    UPDATE Usuarios
    SET
        Nome = @Nome,
        Email = @Email,
        Telefone = @Telefone
    WHERE UsuarioID = @Id
END