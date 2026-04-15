USE BibliotecaDB
GO

CREATE PROCEDURE AtualizarFuncionario
    @Id INT,
	@NomeUsuario NVARCHAR(50),
    @SenhaHash NVARCHAR(255),
    @NomeCompleto NVARCHAR(100),
	@Cargo text ,
    @Email NVARCHAR(100),
    @UltimoLogin DATETIME,
    @Ativo BIT 
AS
BEGIN
    UPDATE Funcionarios
    SET 
        NomeUsuario = @NomeUsuario,
        SenhaHash = @SenhaHash,
        NomeCompleto = @NomeCompleto,
	    Cargo = @Cargo,
        Email = @Email ,
        UltimoLogin = @UltimoLogin,
        Ativo = @Ativo
    WHERE FuncionarioID = @Id
END