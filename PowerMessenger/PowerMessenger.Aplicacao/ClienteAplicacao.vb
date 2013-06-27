Imports PowerMessenger.Dominio
Imports System.ServiceModel
Imports PowerMessenger.Aplicacao.ServidorServiceReference

Public Class ClienteAplicacao
    'Implements IServidor

    Public Property ClienteCallback() As New ClienteCallback()

    Public Sub Enviar(mensagem As Mensagem) 'Implements IServidor.Enviar
        Dim contexto = New InstanceContext(ClienteCallback)

        Dim servidor = New ServidorClient(contexto)

        'servidor.Logar(mensagem.Destinatario)
        servidor.Enviar(mensagem)
    End Sub

    Public Sub Logar(ByVal cliente As Cliente) 'Implements IServidor.Logar
        Throw New NotImplementedException()
    End Sub
End Class

<CallbackBehavior(ConcurrencyMode:=ConcurrencyMode.Reentrant, UseSynchronizationContext:=False)>
Public Class ClienteCallback
    Implements IServidorCallback

    'Public Delegate Function ReceberMensagemEventHandler(mensagem As Mensagem)
    Public Event ReceberMensagem(mensagem As Mensagem)

    Public Sub Receber(ByVal mensagem As Mensagem) Implements IServidorCallback.Receber
        RaiseEvent ReceberMensagem(mensagem)
    End Sub
End Class