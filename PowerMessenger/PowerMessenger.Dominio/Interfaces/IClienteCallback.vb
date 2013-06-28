Imports System.ServiceModel

Namespace Interfaces
    Public Interface IClienteCallback
        <OperationContract()>
        Sub Receber(mensagem As Mensagem)
        <OperationContract()>
        Sub SelecionarClientesLogados(clientes As IList(Of Cliente))
    End Interface
End Namespace