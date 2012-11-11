Public Class RegraNegocioException
    Inherits Exception

    Sub New(mensagem As String)
        'MyBase.Message = mensagem
        MyBase.New(mensagem)
    End Sub
End Class