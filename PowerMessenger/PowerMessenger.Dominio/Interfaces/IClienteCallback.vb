Imports System.ServiceModel
Imports PowerMessenger.Dominio.Entidades

Namespace Interfaces
    Public Interface IClienteCallback
        <OperationContract()>
        Sub Receber(mensagem As Mensagem)
        <OperationContract()>
        Sub SelecionarClientesLogados(clientes As IList(Of Contato))
    End Interface
End Namespace