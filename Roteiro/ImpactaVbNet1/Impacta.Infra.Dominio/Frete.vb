Public Class Frete
    Public Property Cliente As String
    Public Property ValorCarga As Decimal
    Public Property Uf As String
    Public Property PercentualFrete As Decimal
    Public Property ValorTotal As Decimal

    'Public Sub New(valorCarga As Decimal)
    '    Me.ValorCarga = valorCarga
    'End Sub

    Public Sub Calcular(Uf As String)

        Select Case Uf.ToUpper()
            Case "SP"
                PercentualFrete = Convert.ToDecimal(0.2)
                'Case "ES"
            Case "RJ", "ES"
                PercentualFrete = CDec(0.3)
            Case "MG"
                PercentualFrete = 0.35D
            Case "AM"
                PercentualFrete = 0.6D
                'Case "A" to "D"
                'Case 1 To 10
                'Case Is > 10
            Case Else
                PercentualFrete = 0.75D
        End Select

        ValorTotal = ValorCarga*(1 + PercentualFrete)
    End Sub
End Class
