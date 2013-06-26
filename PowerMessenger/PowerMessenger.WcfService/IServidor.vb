Imports PowerMessenger.Dominio

<ServiceContract(CallbackContract:=GetType(IClienteCallback))>
Public Interface IServidor
    <OperationContract()>
    Sub Enviar(mensagem As Mensagem)
    Sub Logar(ByVal cliente As Cliente)
End Interface