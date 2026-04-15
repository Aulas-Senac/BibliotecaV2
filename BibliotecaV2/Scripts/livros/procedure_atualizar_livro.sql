USE BibliotecaDB
GO

CREATE PROCEDURE AtualizarLivro
	@Id INT,
	@Titulo NVARCHAR(200),
	@Genero NVARCHAR(100),
	@Autor NVARCHAR(150),
	@Editora NVARCHAR(100),
	@ISBN NVARCHAR(20),
	@QuantidadeDisponivel INT
AS
BEGIN
	UPDATE Livros
	SET
		Titulo = @Titulo,
		Genero = @Genero,
		Autor = @Autor,
		Editora = @Editora,
		ISBN = @ISBN,
		QuantidadeDisponivel = @QuantidadeDisponivel
	WHERE LivroID = @Id
END