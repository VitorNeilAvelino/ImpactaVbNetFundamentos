Imports PowerMessenger.Dominio.Interfaces
Imports PowerMessenger.Dominio

<ServiceBehavior(ConcurrencyMode:=ConcurrencyMode.Reentrant, UseSynchronizationContext:=False)>
Public Class Servidor
    Implements IServidor

    Private Shared ReadOnly ClientesLogados As Dictionary(Of Cliente, IClienteCallback)

    Shared Sub New()
        ClientesLogados = New Dictionary(Of Cliente, IClienteCallback)()
    End Sub

    Private ReadOnly Property CallbackClienteAtual As IClienteCallback
        Get
            Return OperationContext.Current.GetCallbackChannel(Of IClienteCallback)()
        End Get
    End Property

    Public Sub Enviar(ByVal mensagem As Mensagem) Implements IServidor.Enviar
        ObterCallbackClienteDestino(mensagem.Destinatario).Receber(mensagem)
    End Sub

    Private Function ObterCallbackClienteDestino(cliente As Cliente) As IClienteCallback
        Return ClientesLogados.First(Function(x) x.Key.Login = cliente.Login).Value
    End Function

    Public Sub Logar(cliente As Cliente) Implements IServidor.Logar
        If Not ClientesLogados.Any(Function(x) x.Key.Login = cliente.Login) Then
            ClientesLogados.Add(cliente, CallbackClienteAtual)
            CallbackClienteAtual.SelecionarClientesLogados(ClientesLogados)
        End If
    End Sub
End Class