Public Interface IFreteRepositorio
    Sub Inserir(frete As Frete)
    Function Selecionar() As List(Of Frete)
    Sub Atualizar(frete As Frete)
    Sub Excluir(freteId As Integer)
End Interface