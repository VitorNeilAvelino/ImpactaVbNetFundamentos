

Namespace Entidades

    Public Class Mensagem

        Sub New()
            Destinatario = New Contato()
        End Sub

        Public Property Destinatario() As Contato
        Public Property Corpo() As String
    End Class
End NameSpace