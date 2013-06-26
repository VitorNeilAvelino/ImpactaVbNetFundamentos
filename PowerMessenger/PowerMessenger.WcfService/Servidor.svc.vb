Imports PowerMessenger.Dominio

Public Class Servidor
    Implements IServidor

    'Private _clienteCallback As IClienteCallback
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
        Dim clienteCallback = ClientesLogados.First(Function(x) x.Key = mensagem.Destinatario.Login).Value
        clienteCallback.Receber(mensagem)
    End Sub

    Public Sub Logar(cliente As Cliente) Implements IServidor.Logar
        ClientesLogados.Add(cliente.Login, ClienteCallback)
    End Sub
End Class