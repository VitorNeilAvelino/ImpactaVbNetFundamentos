Imports PowerMessenger.Dominio
Imports PowerMessenger.Dominio.Interfaces

Public Class ClienteAplicacao

End Class

Public Class ClienteCallback
    Implements IClienteCallback

    Public Function Receber(ByVal mensagem As Mensagem) As Mensagem Implements IClienteCallback.Receber
        Return mensagem
    End Function
End Class