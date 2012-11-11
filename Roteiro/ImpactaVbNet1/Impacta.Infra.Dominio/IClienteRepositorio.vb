Public Interface IClienteRepositorio
    Function Selecionar() As List(Of Cliente)
    Function Selecionar(nome As String) As List(Of Cliente)
    Sub Gravar(cliente As Cliente)
    Sub Atualizar(cliente As Cliente)
    Sub Excluir(clienteId As String)
End Interface