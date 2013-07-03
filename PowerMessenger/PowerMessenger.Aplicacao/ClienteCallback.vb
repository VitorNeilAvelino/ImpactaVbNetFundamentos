Imports PowerMessenger.Dominio.Entidades
Imports PowerMessenger.Aplicacao.ServidorServiceReference
Imports System.ServiceModel

<CallbackBehavior(ConcurrencyMode:=ConcurrencyMode.Reentrant, UseSynchronizationContext:=False)>
Public Class ClienteCallback
    Implements IServidorCallback    'Eu acho que essa interface deveria ser chamar IClienteCallback, como definido, mas o nome é composto na criação do service reference.

    Public Event AoReceberMensagem(mensagem As Mensagem)
    Public Event AoSelecionarClientesLogados(clientes As IList(Of Contato))

    Public Sub Receber(ByVal mensagem As Mensagem) Implements IServidorCallback.Receber
        RaiseEvent AoReceberMensagem(mensagem)
    End Sub

    Public Sub SelecionarClientesLogados(ByVal clientes As List(Of Contato)) Implements IServidorCallback.SelecionarClientesLogados
        RaiseEvent AoSelecionarClientesLogados(clientes)
    End Sub
End Class