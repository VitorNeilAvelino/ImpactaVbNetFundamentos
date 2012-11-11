<TestClass()>
Public Class DicionarioTeste
    <TestMethod()>
    Public Sub TestarDicionario()
        Dim vetorDeVendas() = {1, 2, 3, 4, 5}

        Dim erros = Validar(vetorDeVendas)

        'For Each erro As KeyValuePair(Of Int32, Exception) In erros
        For Each erro In erros
            Console.WriteLine("Venda {0}: {1}", erro.Key, erro.Value)
        Next

    End Sub

    Private Function Validar(ByVal vetorDeVendas As Integer()) As Dictionary(Of Int32, Exception)
        Dim listaDeErros As New Dictionary(Of Int32, Exception)

        For Each venda As Integer In vetorDeVendas
            If venda Mod 2 <> 0 Then
                listaDeErros.Add(venda, New Exception("Descrição do erro."))
            End If
        Next

        Return listaDeErros
    End Function
End Class