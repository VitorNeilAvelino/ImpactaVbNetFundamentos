Public Class Tabuada
    Private _valor As Int32

    Public Sub New(valor As Int32)
        _valor = valor
    End Sub

    Shared Sub New()
        Throw New Exception("Membro compartilhado foi acessado.")
    End Sub

    Public Shared Function Calcular(valor As Int32) As List(Of String)
        Return New List(Of String)() From {valor.ToString()}
    End Function
End Class