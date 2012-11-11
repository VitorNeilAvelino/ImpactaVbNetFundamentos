CREATE PROCEDURE dbo.spAtualizarCliente
		(
		@Id varchar(50),
	@Nome varchar(50),
	@DataNascimento date,
	@Email varchar(50),
	@Endereco varchar(50)
	)
AS
	Update Cliente
	Set Nome = @Nome,
	DataNascimento = @DataNascimento,
	Email = @Email,
	Endereco = @Endereco
	Where Id = @Id
