Imports PowerMessenger.Dominio.Interfaces
Imports PowerMessenger.Dominio

<ServiceBehavior(ConcurrencyMode:=ConcurrencyMode.Reentrant, UseSynchronizationContext:=False)>
Public Class Servidor
    Implements IServidor

    Private Shared ReadOnly ClientesLogados As Dictionary(Of String, IClienteCallback)

    Shared Sub New()
        ClientesLogados = New Dictionary(Of String, IClienteCallback)()
    End Sub

    Private ReadOnly Property ClienteCallback As IClienteCallback
        Get
            Return OperationContext.Current.GetCallbackChannel(Of IClienteCallback)()
        End Get
    End Property

    Public Sub Enviar(ByVal mensagem As Mensagem) Implements IServidor.Enviar
        'Logar(mensagem.Destinatario)
        Dim clienteCallback = ClientesLogados.First(Function(x) x.Key = mensagem.Destinatario.Login).Value
        clienteCallback.Receber(mensagem)
    End Sub

    Public Sub Logar(cliente As Cliente) Implements IServidor.Logar
        If Not ClientesLogados.Any(Function(x) x.Key = cliente.Login) Then
            ClientesLogados.Add(cliente.Login, ClienteCallback)
        End If
    End Sub
End Class