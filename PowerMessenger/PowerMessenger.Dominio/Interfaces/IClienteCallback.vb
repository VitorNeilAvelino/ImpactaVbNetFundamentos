Imports System.ServiceModel

Namespace Interfaces

    Public Interface IClienteCallback
        <OperationContract()>
        Sub Receber(mensagem As Mensagem)
    End Interface
End Namespace