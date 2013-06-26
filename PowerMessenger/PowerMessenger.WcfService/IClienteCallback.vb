Imports PowerMessenger.Dominio

Public Interface IClienteCallback
    <OperationContract()>
    Sub Receber(mensagem As Mensagem)
End Interface