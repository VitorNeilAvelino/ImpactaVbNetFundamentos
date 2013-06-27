Imports System.ServiceModel

Namespace Interfaces

    <ServiceContract(CallbackContract:=GetType(IClienteCallback))>
    Public Interface IServidor
        <OperationContract()>
        Sub Enviar(mensagem As Mensagem)
        Sub Logar(cliente As Cliente)
    End Interface
End NameSpace