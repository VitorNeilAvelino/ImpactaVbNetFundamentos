Imports PowerMessenger.Dominio
Imports PowerMessenger.Aplicacao.ServidorServiceReference
Imports System.ServiceModel

<CallbackBehavior(ConcurrencyMode:=ConcurrencyMode.Reentrant, UseSynchronizationContext:=False)>
Public Class ClienteCallback
    Implements IServidorCallback

    Public Event AoReceberMensagem(mensagem As Mensagem)
    Public Event AoSelecionarClientesLogados(clientes As IList(Of Cliente))

    Public Sub Receber(ByVal mensagem As Mensagem) Implements IServidorCallback.Receber
        RaiseEvent AoReceberMensagem(mensagem)
    End Sub

    Public Sub SelecionarClientesLogados(ByVal clientes As List(Of Cliente)) Implements IServidorCallback.SelecionarClientesLogados
        RaiseEvent AoSelecionarClientesLogados(clientes)
    End Sub
End Class