Imports System.ServiceModel
Imports PowerMessenger.Dominio.Entidades

Namespace Interfaces
    <ServiceContract(CallbackContract:=GetType(IClienteCallback))>
    Public Interface IServidor
        <OperationContract()>
        Sub Enviar(mensagem As Mensagem)
        <OperationContract()>
        Sub Logar(contato As Contato)
        <OperationContract()>
        Sub Deslogar(contato As Contato)
    End Interface
End NameSpace