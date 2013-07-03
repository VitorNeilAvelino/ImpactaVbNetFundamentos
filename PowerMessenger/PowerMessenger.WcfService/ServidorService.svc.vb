Imports PowerMessenger.Dominio.Entidades
Imports PowerMessenger.Dominio.Interfaces

<ServiceBehavior(ConcurrencyMode:=ConcurrencyMode.Reentrant, UseSynchronizationContext:=False)>
Public Class ServidorService
    Implements IServidor

    Private Shared ReadOnly ClientesLogados As Dictionary(Of Contato, IClienteCallback)

    Shared Sub New()
        ClientesLogados = New Dictionary(Of Contato, IClienteCallback)()
    End Sub

    Private ReadOnly Property CallbackClienteAtual As IClienteCallback
        Get
            Return OperationContext.Current.GetCallbackChannel(Of IClienteCallback)()
        End Get
    End Property

    Public Sub Enviar(ByVal mensagem As Mensagem) Implements IServidor.Enviar
        ObterCallbackClienteDestino(mensagem.Destinatario).Receber(mensagem)
    End Sub

    Private Function ObterCallbackClienteDestino(contato As Contato) As IClienteCallback
        Return ClientesLogados.First(Function(x) x.Key.Login = contato.Login).Value
    End Function

    Public Sub Logar(contato As Contato) Implements IServidor.Logar
        If Not ClientesLogados.Any(Function(x) x.Key.Login = contato.Login) Then
            ClientesLogados.Add(contato, CallbackClienteAtual)
        End If
        AtualizarListaDeContatosLogados()
    End Sub

    Public Sub Deslogar(ByVal contato As Contato) Implements IServidor.Deslogar
        Dim clienteADeslogar = ClientesLogados.FirstOrDefault(Function(x) x.Key.Login = contato.Login).Key
        ClientesLogados.Remove(clienteADeslogar)
        AtualizarListaDeContatosLogados()
    End Sub

    Private Shared Sub AtualizarListaDeContatosLogados()
        For Each contato In ClientesLogados
            contato.Value.SelecionarClientesLogados(ClientesLogados.Keys.ToList())
        Next
    End Sub
End Class