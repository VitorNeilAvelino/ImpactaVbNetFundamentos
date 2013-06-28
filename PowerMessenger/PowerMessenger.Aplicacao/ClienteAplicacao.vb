Imports PowerMessenger.Dominio
Imports System.ServiceModel
Imports PowerMessenger.Aplicacao.ServidorServiceReference

Public Class ClienteAplicacao
    Public Property ClienteCallback() As New ClienteCallback()
    ReadOnly _contexto = New InstanceContext(ClienteCallback)
    ReadOnly _servidor = New ServidorClient(_contexto)

    Public Sub Enviar(mensagem As Mensagem)
        _servidor.Enviar(mensagem)
        '_servidor.Close()
    End Sub

    Public Sub Logar(ByVal cliente As Cliente)
        _servidor.Logar(cliente)
        '_servidor.Close()
    End Sub
End Class