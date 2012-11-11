CREATE PROCEDURE dbo.spGravarCliente
		(
	@Nome varchar(50),
	@DataNascimento date,
	@Email varchar(50),
	@Endereco varchar(50)
	)
	
AS
	Insert into Cliente(Nome, DataNascimento, Email, Endereco) 
	values
	(
	@Nome,
	@DataNascimento,
	@Email,
	@Endereco
	)
