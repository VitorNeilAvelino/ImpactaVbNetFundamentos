Public Class Mensagem

    Sub New()
        Destinatario = New Cliente()
    End Sub

    Public Property Destinatario() As Cliente
    Public Property Corpo() As String
End Class