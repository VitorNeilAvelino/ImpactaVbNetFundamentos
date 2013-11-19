Public Class Usuario
    Inherits Pessoa

    Public Property Login() As String
    Public Property Senha() As String

    Public Overrides Sub Validar()
        Throw New NotImplementedException()
    End Sub
End Class