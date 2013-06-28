Imports PowerMessenger.Dominio
Imports PowerMessenger.Aplicacao.ServidorServiceReference
Imports System.ServiceModel

<CallbackBehavior(ConcurrencyMode:=ConcurrencyMode.Reentrant, UseSynchronizationContext:=False)>
Public Class ClienteCallback
    Implements IServidorCallback

    'Public Delegate Function ReceberMensagemEventHandler(mensagem As Mensagem)
    Public Event ReceberMensagem(mensagem As Mensagem)

    Public Sub Receber(ByVal mensagem As Mensagem) Implements IServidorCallback.Receber
        RaiseEvent ReceberMensagem(mensagem)
    End Sub
End Class