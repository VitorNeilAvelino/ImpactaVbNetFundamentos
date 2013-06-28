Imports System.ServiceModel

Namespace Interfaces

    <ServiceContract(CallbackContract:=GetType(IClienteCallback))>
    Public Interface IServidor
        <OperationContract()>
        Sub Enviar(mensagem As Mensagem)
        <OperationContract()>
        Sub Logar(cliente As Cliente)
    End Interface
End NameSpace