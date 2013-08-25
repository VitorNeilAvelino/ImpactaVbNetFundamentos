Public Class Frete
    Public Property Cliente As Cliente
    Public Property ValorCarga As Decimal
    Public Property UfDestino As String
    Public Property Percentual As Decimal
    Public Property ValorTotal As Decimal

    'Public Sub New(valorCarga As Decimal)
    '    Me.ValorCarga = valorCarga
    'End Sub

    Public Sub Calcular(Uf As String)

        Select Case Uf.ToUpper()
            Case "SP"
                Percentual = Convert.ToDecimal(0.2)
                'Case "ES"
            Case "RJ", "ES"
                Percentual = CDec(0.3)
            Case "MG"
                Percentual = 0.35D
            Case "AM"
                Percentual = 0.6D
                'Case "A" to "D"
                'Case 1 To 10
                'Case Is > 10
            Case Else
                Percentual = 0.75D
        End Select

        ValorTotal = ValorCarga * (1 + Percentual)
    End Sub
End Class