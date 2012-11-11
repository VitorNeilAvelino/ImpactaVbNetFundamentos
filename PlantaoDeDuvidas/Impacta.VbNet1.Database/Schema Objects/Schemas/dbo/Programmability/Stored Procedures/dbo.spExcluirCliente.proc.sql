CREATE PROCEDURE dbo.spExcluirCliente
		(
	@Id varchar(50)
	)
	
AS
	Delete From Cliente where id = @id