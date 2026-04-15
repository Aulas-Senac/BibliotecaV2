USE BibliotecaDB
GO

CREATE PROCEDURE InserirFuncionario
    @NomeUsuario NVARCHAR(50),
    @SenhaHash NVARCHAR(255),
    @NomeCompleto NVARCHAR(100),
	@Cargo text ,
    @Email NVARCHAR(100),
    @UltimoLogin DATETIME,
    @Ativo BIT 
AS
BEGIN
    INSERT INTO Funcionarios (NomeUsuario, SenhaHash, NomeCompleto, Cargo, Email, UltimoLogin, Ativo)
    VALUES (@NomeUsuario, @SenhaHash, @NomeCompleto,@Cargo, @Email, @UltimoLogin, @Ativo) 
END