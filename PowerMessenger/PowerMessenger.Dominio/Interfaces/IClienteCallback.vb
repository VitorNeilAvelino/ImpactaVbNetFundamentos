Imports System.ServiceModel

Namespace Interfaces

    Public Interface IClienteCallback
        <OperationContract()>
        Function Receber(mensagem As Mensagem) As Mensagem
    End Interface
End Namespace