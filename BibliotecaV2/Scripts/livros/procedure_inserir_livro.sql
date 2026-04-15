USE BibliotecaDB
GO

CREATE PROCEDURE InserirLivro
	@Titulo NVARCHAR(200),
	@Genero NVARCHAR(100),
	@Autor NVARCHAR(150),
	@Editora NVARCHAR(100),
	@ISBN NVARCHAR(20),
	@QuantidadeDisponivel INT
AS
BEGIN
	INSERT INTO Livros(Titulo, Genero, Autor, Editora, ISBN, QuantidadeDisponivel)
	VALUES (@Titulo, @Genero, @Autor, @Editora, @ISBN, @QuantidadeDisponivel)
END